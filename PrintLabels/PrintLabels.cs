﻿using System;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace PrintLabels
{
    public partial class PrintLabels : Form
    {
        readonly private string definedLines;
        readonly private string outputLabelFile;
        private BindingList<LabelRow> labelRows;
        public PrintLabels()
        {
            InitializeComponent();
            definedLines = Properties.Settings.Default.DefinedLines;
            outputLabelFile = Properties.Settings.Default.OutputLabelFile;
        }

        private void PrintLabels_Load(object sender, EventArgs e)
        {
            #region read pre defined lines

            if (File.Exists(definedLines))
            {
                XmlSerializer reader = new XmlSerializer(typeof(BindingList<LabelRow>));
                StreamReader file = new StreamReader(definedLines);
                try
                {
                    labelRows = (BindingList<LabelRow>)reader.Deserialize(file);
                }
                catch
                {
                    labelRows = new BindingList<LabelRow>();
                }
                finally
                {
                    file.Close();
                }
            }
            else
            {
                labelRows = new BindingList<LabelRow>();
            }
            
            #endregion

            #region configure data grid

            dataGridView1.DataSource = labelRows;
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 90;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            #endregion

            textBoxPrinterName.Text = Properties.Settings.Default.PrinterName;
            dataGridView1.Columns[1].Visible = Properties.Settings.Default.ShowCommand;
            checkBoxShowCommand.Checked = Properties.Settings.Default.ShowCommand;

            Text = $"Print Labels v{Application.ProductVersion}";
        }

        private void PrintLabels_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.ShowCommand = dataGridView1.Columns[1].Visible;
            Properties.Settings.Default.PrinterName = textBoxPrinterName.Text.ToString();
            Properties.Settings.Default.Save();

            var writer = new XmlSerializer(typeof(BindingList<LabelRow>));
            var file = new StreamWriter(definedLines);
            writer.Serialize(file, labelRows);
            file.Close();
        }

        private void checkBoxShowCommand_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Columns[1].Visible = checkBoxShowCommand.Checked ? true : false;
        }

        private void buttonSelectPrinter_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            if (pd.ShowDialog() == DialogResult.OK)
            {
                textBoxPrinterName.Text = pd.PrinterSettings.PrinterName;
            }
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            #region create output label file

            try
            {
                StreamWriter streamWriter = new StreamWriter(outputLabelFile, false, Encoding.ASCII);
                streamWriter.WriteLine("N");
                foreach (LabelRow r in labelRows)
                {
                    if (r.Print)
                    {
                        streamWriter.WriteLine("{0},\"{1}\"", r.Command, r.Text);
                    }
                }
                streamWriter.WriteLine("P{0}", textBoxQuantity.Text.ToString());
                streamWriter.Close();
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show(ex.Message, "Stop", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            #endregion

            #region send label file to printer

            //Connection connection = ConnectionBuilder.Build(String.Format("USB:{0}", textBoxPrinterName.Text));
            //try
            //{
            //    connection.Open();
            //    ZebraPrinter printer = ZebraPrinterFactory.GetInstance(connection);
            //    printer.SendFileContents(outputLabelFile);
            //}
            //catch (Exception ex)
            //{
            //    _ = MessageBox.Show(ex.Message, "Stop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //finally
            //{
            //    connection.Close();
            //}

            RawPrinterHelper.SendFileToPrinter(textBoxPrinterName.Text, outputLabelFile);

            #endregion
        }
    }
}
