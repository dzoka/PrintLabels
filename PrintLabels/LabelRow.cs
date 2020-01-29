using System;

namespace PrintLabels
{
    [Serializable]
    public class LabelRow
    {
        public bool Print { get; set; }
        public string Command { get; set; }
        public string Text { get; set; }
    }
}
