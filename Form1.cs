using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace Sportclub
{
    public partial class MainForm : Form
    {
        private LedenContext? dbContext;

        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.dbContext = new LedenContext();

            // Uncomment the line below to start fresh with a new database.
            // this.dbContext.Database.EnsureDeleted();
            this.dbContext.Database.EnsureCreated();

            this.dbContext.Groepen.Load();

            this.groepBindingSource.DataSource = dbContext.Groepen.Local.ToBindingList();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.dbContext?.Dispose();
            this.dbContext = null;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.dbContext!.SaveChanges();

            this.dataGridViewGroepen.Refresh();
            this.dataGridViewLeden.Refresh();
        }

        private void dataGridViewGroepen_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dbContext != null)
            {
                var groep = (Groep)this.dataGridViewGroepen.CurrentRow.DataBoundItem;

                if (groep != null)
                {
                    this.dbContext.Entry(groep).Collection(e => e.Leden).Load();
                }
            }
        }
    }
}