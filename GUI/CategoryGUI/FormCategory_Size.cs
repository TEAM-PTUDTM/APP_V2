using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.CategoryGUI
{
    public partial class FormCategory_Size : Form
    {
        public FormCategory_Size()
        {
            InitializeComponent();
        }

        private void FormCategory_Size_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sHOP.mausac' table. You can move, or remove it, as needed.
            this.mausacTableAdapter.Fill(this.sHOP.mausac);

        }

        private void mausacBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mausacBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sHOP);

        }
    }
}
