namespace Exersare
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;

        // Controale pentru Departament
        private System.Windows.Forms.TextBox txtNrDepartament;
        private System.Windows.Forms.TextBox txtDepartament;
        private System.Windows.Forms.TextBox txtSef;
        private System.Windows.Forms.Button btnCreateDepartament;
        private System.Windows.Forms.Button btnUpdateDepartament;
        private System.Windows.Forms.Button btnDeleteDepartament;

        // Controale pentru Angajat
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.DateTimePicker dtpDataNasterii;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtStagiu;
        private System.Windows.Forms.Button btnCreateAngajat;
        private System.Windows.Forms.Button btnUpdateAngajat;
        private System.Windows.Forms.Button btnDeleteAngajat;

        // Rapoarte
        private System.Windows.Forms.Button btnAngajatiStagiuMare;
        private System.Windows.Forms.Button btnDepartamente;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();

            this.txtNrDepartament = new System.Windows.Forms.TextBox();
            this.txtDepartament = new System.Windows.Forms.TextBox();
            this.txtSef = new System.Windows.Forms.TextBox();
            this.btnCreateDepartament = new System.Windows.Forms.Button();
            this.btnUpdateDepartament = new System.Windows.Forms.Button();
            this.btnDeleteDepartament = new System.Windows.Forms.Button();

            this.txtNume = new System.Windows.Forms.TextBox();
            this.dtpDataNasterii = new System.Windows.Forms.DateTimePicker();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtStagiu = new System.Windows.Forms.TextBox();
            this.btnCreateAngajat = new System.Windows.Forms.Button();
            this.btnUpdateAngajat = new System.Windows.Forms.Button();
            this.btnDeleteAngajat = new System.Windows.Forms.Button();

            this.btnAngajatiStagiuMare = new System.Windows.Forms.Button();
            this.btnDepartamente = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // dataGridView1
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Size = new System.Drawing.Size(600, 200);

            // Departament controls
            this.txtNrDepartament.Location = new System.Drawing.Point(12, 230);
            this.txtNrDepartament.Width = 50;

            this.txtDepartament.Location = new System.Drawing.Point(70, 230);
            this.txtDepartament.Width = 150;

            this.txtSef.Location = new System.Drawing.Point(230, 230);
            this.txtSef.Width = 150;

            this.btnCreateDepartament.Location = new System.Drawing.Point(400, 230);
            this.btnCreateDepartament.Text = "Adaugă Departament";
            this.btnCreateDepartament.Click += new System.EventHandler(this.btnCreateDepartament_Click);

            this.btnUpdateDepartament.Location = new System.Drawing.Point(400, 260);
            this.btnUpdateDepartament.Text = "Update Departament";
            this.btnUpdateDepartament.Click += new System.EventHandler(this.btnUpdateDepartament_Click);

            this.btnDeleteDepartament.Location = new System.Drawing.Point(400, 290);
            this.btnDeleteDepartament.Text = "Delete Departament";
            this.btnDeleteDepartament.Click += new System.EventHandler(this.btnDeleteDepartament_Click);

            // Angajat controls
            this.txtNume.Location = new System.Drawing.Point(12, 330);
            this.txtNume.Width = 150;

            this.dtpDataNasterii.Location = new System.Drawing.Point(170, 330);
            this.dtpDataNasterii.Width = 150;

            this.txtAdresa.Location = new System.Drawing.Point(330, 330);
            this.txtAdresa.Width = 150;

            this.txtTelefon.Location = new System.Drawing.Point(12, 360);
            this.txtTelefon.Width = 150;

            this.txtStagiu.Location = new System.Drawing.Point(170, 360);
            this.txtStagiu.Width = 50;

            this.btnCreateAngajat.Location = new System.Drawing.Point(330, 360);
            this.btnCreateAngajat.Text = "Adaugă Angajat";
            this.btnCreateAngajat.Click += new System.EventHandler(this.btnCreateAngajat_Click);

            this.btnUpdateAngajat.Location = new System.Drawing.Point(330, 390);
            this.btnUpdateAngajat.Text = "Update Angajat";
            this.btnUpdateAngajat.Click += new System.EventHandler(this.btnUpdateAngajat_Click);

            this.btnDeleteAngajat.Location = new System.Drawing.Point(330, 420);
            this.btnDeleteAngajat.Text = "Delete Angajat";
            this.btnDeleteAngajat.Click += new System.EventHandler(this.btnDeleteAngajat_Click);

            // Rapoarte
            this.btnAngajatiStagiuMare.Location = new System.Drawing.Point(12, 420);
            this.btnAngajatiStagiuMare.Text = "Angajați > 20 ani";
            this.btnAngajatiStagiuMare.Click += new System.EventHandler(this.btnAngajatiStagiuMare_Click);

            this.btnDepartamente.Location = new System.Drawing.Point(150, 420);
            this.btnDepartamente.Text = "Lista Departamente";
            this.btnDepartamente.Click += new System.EventHandler(this.btnDepartamente_Click);

            // Form1
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.dataGridView1);

            this.Controls.Add(this.txtNrDepartament);
            this.Controls.Add(this.txtDepartament);
            this.Controls.Add(this.txtSef);
            this.Controls.Add(this.btnCreateDepartament);
            this.Controls.Add(this.btnUpdateDepartament);
            this.Controls.Add(this.btnDeleteDepartament);

            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.dtpDataNasterii);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtStagiu);
            this.Controls.Add(this.btnCreateAngajat);
            this.Controls.Add(this.btnUpdateAngajat);
            this.Controls.Add(this.btnDeleteAngajat);

            this.Controls.Add(this.btnAngajatiStagiuMare);
            this.Controls.Add(this.btnDepartamente);

            this.Text = "CRUD ExersareExamen";

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
