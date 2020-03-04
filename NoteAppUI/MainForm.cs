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
    public partial class MainForm: UserControl
    {
        public MainForm()
        {
            InitializeComponent();
            var note = new Note("", NoteCategory.People, "adsffasdfadsf");
            MessageBox.Show(note.Name + " " + note.Category.ToString());
            ProjectManager test = new ProjectManager();
            Project gg = new Project();
            gg.Notes = new List<Note>();
            gg.Notes.Add(note);
            gg = test.LoadFromFile();
            MessageBox.Show(gg.Notes[0].Text + gg.Notes[0].Category);
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
