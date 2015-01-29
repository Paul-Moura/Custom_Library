using System;
using System.IO;
using System.Windows.Forms;

namespace CustomControls.Radiography
{
    public partial class InspectionResults : UserControl
    {
        public DirectoryInfo ImagesDirectory { get; set; }

        public InspectionResults()
        {
            InitializeComponent();
        }

        private void InspectionResults_Load(object sender, EventArgs e)
        {
            this.comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.listView1.View = (View)this.comboBox1.SelectedIndex;
        }

        private void listView1_DragDrop(object sender, DragEventArgs e)
        {

        }
    }
}
