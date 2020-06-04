using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Paper_Mario_Randomizer
{
    public partial class ByteTextbox : TextBox
    {
        private int SetByteLength = 0;
        private byte[] _Bytes;

        public ByteTextbox()
        {
            InitializeComponent();
        }

        public ByteTextbox(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        public virtual void SetBytes(byte[] Bytes)
        {
            if (Bytes == null)
            {
                SetByteLength = 0;
                this.Text = "";
            }
            else
            {
                SetByteLength = Bytes.Length;
                this.Text = ByteOps.GetFormattedByteString(Bytes);
            }
        }

        public virtual byte[] GetBytes()
        {
            byte[] Parsed = ByteOps.FormattedByteStringToByteArray(this.Text);
            _Bytes = Parsed == null ? _Bytes : Parsed;
            return _Bytes;
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);

            byte[] Parsed = ByteOps.FormattedByteStringToByteArray(this.Text);

            if (Parsed != null && Parsed.Length == SetByteLength)
                this.BackColor = Color.White;
            else
                this.BackColor = Color.PaleVioletRed;
        }
    }
}
