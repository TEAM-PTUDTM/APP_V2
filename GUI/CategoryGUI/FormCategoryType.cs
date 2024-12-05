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
    public partial class FormCategoryType : Form
    {
        public FormCategoryType()
        {
            InitializeComponent();
        }

        private void FormCategoryType_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sHOP.danhmuc' table. You can move, or remove it, as needed.
            this.danhmucTableAdapter.Fill(this.sHOP.danhmuc);

        }

        private void danhmucBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.danhmucBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sHOP);

        }
    }
}
