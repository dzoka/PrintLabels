namespace PrintLabels
{
    partial class PrintLabels
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxPrinterName = new System.Windows.Forms.TextBox();
            this.buttonSelectPrinter = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.checkBoxShowCommand = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(460, 308);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBoxPrinterName
            // 
            this.textBoxPrinterName.Location = new System.Drawing.Point(120, 328);
            this.textBoxPrinterName.Name = "textBoxPrinterName";
            this.textBoxPrinterName.ReadOnly = true;
            this.textBoxPrinterName.Size = new System.Drawing.Size(148, 20);
            this.textBoxPrinterName.TabIndex = 1;
            // 
            // buttonSelectPrinter
            // 
            this.buttonSelectPrinter.Location = new System.Drawing.Point(274, 326);
            this.buttonSelectPrinter.Name = "buttonSelectPrinter";
            this.buttonSelectPrinter.Size = new System.Drawing.Size(26, 23);
            this.buttonSelectPrinter.TabIndex = 2;
            this.buttonSelectPrinter.Text = "...";
            this.buttonSelectPrinter.UseVisualStyleBackColor = true;
            this.buttonSelectPrinter.Click += new System.EventHandler(this.buttonSelectPrinter_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(397, 326);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(75, 23);
            this.buttonPrint.TabIndex = 3;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quantity";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(358, 328);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(33, 20);
            this.textBoxQuantity.TabIndex = 5;
            this.textBoxQuantity.Text = "1";
            this.textBoxQuantity.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxQuantity_Validating);
            this.textBoxQuantity.Validated += new System.EventHandler(this.textBoxQuantity_Validated);
            // 
            // checkBoxShowCommand
            // 
            this.checkBoxShowCommand.AutoSize = true;
            this.checkBoxShowCommand.Location = new System.Drawing.Point(12, 330);
            this.checkBoxShowCommand.Name = "checkBoxShowCommand";
            this.checkBoxShowCommand.Size = new System.Drawing.Size(102, 17);
            this.checkBoxShowCommand.TabIndex = 6;
            this.checkBoxShowCommand.Text = "Show command";
            this.checkBoxShowCommand.UseVisualStyleBackColor = true;
            this.checkBoxShowCommand.CheckedChanged += new System.EventHandler(this.checkBoxShowCommand_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PrintLabels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.checkBoxShowCommand);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonSelectPrinter);
            this.Controls.Add(this.textBoxPrinterName);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PrintLabels";
            this.Text = "Print Labels";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrintLabels_FormClosing);
            this.Load += new System.EventHandler(this.PrintLabels_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxPrinterName;
        private System.Windows.Forms.Button buttonSelectPrinter;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.CheckBox checkBoxShowCommand;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

