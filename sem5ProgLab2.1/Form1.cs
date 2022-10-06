using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sem5ProgLab2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Note();
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                propertyGrid1.SelectedObject = listBox1.SelectedItem;
            }
        }

        private void Note()
        {
            var serializer = new XmlSerializer(typeof(Notepad));
            var NotepadFromXml = new List<Note>();

            using (var reader = new FileStream("test.xml", FileMode.Open))
            {
                NotepadFromXml = ((Notepad)serializer.Deserialize(reader)).Items;
            }

            foreach (var Note in NotepadFromXml)
            {
                listBox1.Items.Add(Note);
            }
        }

        #region для переноса текста в listbox на след строку  (теперь без этого не отображаются объекты в listbox)
        private void lst_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = (int)e.Graphics.MeasureString(listBox1.Items[e.Index].ToString(), listBox1.Font, listBox1.Width).Height;
        }

        private void lst_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                e.DrawBackground();
                e.DrawFocusRectangle();
                e.Graphics.DrawString(listBox1.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
            }
        }
        #endregion

    }
}
