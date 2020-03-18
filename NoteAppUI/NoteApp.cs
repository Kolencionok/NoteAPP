using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
    public partial class NoteApp: UserControl
    { 
        
        public NoteApp()
        {
            InitializeComponent();
            var note = new Note("FJKJFDK", NoteCategory.Home, "aaaaaaaaaaaaaaaaaa");
            MessageBox.Show(note.Name + " " + note.Category.ToString());
            ProjectManager test = new ProjectManager();
            test.SetWorkFileName();
            Project gg = new Project();
            gg.Notes = new List<Note>();
            gg.Notes.Add(note);
            test.SaveToFile(gg);
            MessageBox.Show(gg.Notes[0].Text + gg.Notes[0].Category);
           
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
