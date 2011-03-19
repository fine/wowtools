﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WoWPacketViewer.Parsers.Warden;

namespace WoWPacketViewer
{
    internal partial class FrmWardenDebug : Form
    {
        public FrmWardenDebug()
        {
            InitializeComponent();
        }

        public byte XorByte { get; set; }

        private TextBox[] GetTextBoxes()
        {
            return new[]
            {
                tbMemCheck,
                tbPageCheckA,
                tbPageCheckB,
                tbMpqCheck,
                tbLuaStrCheck,
                tbDriverCheck,
                tbTimingCheck,
                tbProcCheck,
                tbModuleCheck
            };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WardenData.InitCheckTypes();

            Hide();
        }

        private void toolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tbInfo.SelectedText == String.Empty) return;

            foreach (var tb in GetTextBoxes())
            {
                if (tb.TabIndex == Convert.ToInt32(((ToolStripMenuItem)sender).Tag))
                {
                    var tempCheckId = Convert.ToByte(tbInfo.SelectedText.Trim(), 16);
                    var checkId = (byte)(tempCheckId ^ XorByte);
                    tb.Text = checkId.ToString("X2");
                    break;
                }
            }
        }

        public void SetInfo(string value)
        {
            tbInfo.Text = value;
        }

        public IDictionary<byte, CheckType> CheckTypes
        {
            get
            {
                var checkTypes = new Dictionary<byte, CheckType>();
                foreach (var tb in GetTextBoxes())
                {
                    if (tb.Text != String.Empty)
                    {
                        try
                        {
                            checkTypes.Add(Convert.ToByte(tb.Text, 16), (CheckType)tb.TabIndex);
                        }
                        catch
                        {
                            MessageBox.Show("Duplicate check type detected!");
                        }
                    }
                }
                return checkTypes;
            }
            set
            {
                foreach (TextBox tb in GetTextBoxes())
                {
                    byte val = 0;
                    if (GetByteForCheckType((CheckType)tb.TabIndex, ref val, value))
                        tb.Text = String.Format("{0:X2}", val);
                }
            }
        }

        private static bool GetByteForCheckType(CheckType checkType, ref byte val, IEnumerable<KeyValuePair<byte, CheckType>> dictionary)
        {
            foreach (var temp in dictionary)
            {
                if (temp.Value == checkType)
                {
                    val = temp.Key;
                    return true;
                }
            }
            return false;
        }
    }
}
