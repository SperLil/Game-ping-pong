using pingpong;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace game
{
    public partial class frmMenu : Form
    {
        private Label label1;
        private Button button1;
        private Button button2;
        private Button btnIniciante;

        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnIniciante_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1(200);
            frm1.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1(100);
            frm1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1(50);
            frm1.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.btnIniciante = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIniciante
            // 
            this.btnIniciante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnIniciante.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciante.Location = new System.Drawing.Point(13, 98);
            this.btnIniciante.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIniciante.Name = "btnIniciante";
            this.btnIniciante.Size = new System.Drawing.Size(375, 85);
            this.btnIniciante.TabIndex = 2;
            this.btnIniciante.Text = "Iniciante";
            this.btnIniciante.UseVisualStyleBackColor = false;
            this.btnIniciante.Click += new System.EventHandler(this.btnIniciante_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Escolha o nível";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 193);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(375, 85);
            this.button1.TabIndex = 4;
            this.button1.Text = "Intermediario";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(13, 288);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(375, 85);
            this.button2.TabIndex = 5;
            this.button2.Text = "Dificil";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmMenu
            // 
            this.ClientSize = new System.Drawing.Size(427, 410);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIniciante);
            this.Name = "frmMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }





     
    }
}