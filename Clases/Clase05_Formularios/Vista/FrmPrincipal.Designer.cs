
namespace Vista
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.button1 = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.numEdad = new System.Windows.Forms.NumericUpDown();
            this.rbUno = new System.Windows.Forms.RadioButton();
            this.rbDos = new System.Windows.Forms.RadioButton();
            this.rbTres = new System.Windows.Forms.RadioButton();
            this.chCuatro = new System.Windows.Forms.CheckBox();
            this.chCinco = new System.Windows.Forms.CheckBox();
            this.chSeis = new System.Windows.Forms.CheckBox();
            this.gpbChecks = new System.Windows.Forms.GroupBox();
            this.gpbRadios = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).BeginInit();
            this.gpbChecks.SuspendLayout();
            this.gpbRadios.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNombre
            // 
            resources.ApplyResources(this.lblNombre, "lblNombre");
            this.lblNombre.Name = "lblNombre";
            // 
            // txtNombre
            // 
            resources.ApplyResources(this.txtNombre, "txtNombre");
            this.txtNombre.Name = "txtNombre";
            // 
            // btnIngresar
            // 
            resources.ApplyResources(this.btnIngresar, "btnIngresar");
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // numEdad
            // 
            resources.ApplyResources(this.numEdad, "numEdad");
            this.numEdad.Name = "numEdad";
            // 
            // rbUno
            // 
            resources.ApplyResources(this.rbUno, "rbUno");
            this.rbUno.Name = "rbUno";
            this.rbUno.TabStop = true;
            this.rbUno.UseVisualStyleBackColor = true;
            // 
            // rbDos
            // 
            resources.ApplyResources(this.rbDos, "rbDos");
            this.rbDos.Name = "rbDos";
            this.rbDos.TabStop = true;
            this.rbDos.UseVisualStyleBackColor = true;
            // 
            // rbTres
            // 
            resources.ApplyResources(this.rbTres, "rbTres");
            this.rbTres.Name = "rbTres";
            this.rbTres.TabStop = true;
            this.rbTres.UseVisualStyleBackColor = true;
            // 
            // chCuatro
            // 
            resources.ApplyResources(this.chCuatro, "chCuatro");
            this.chCuatro.Name = "chCuatro";
            this.chCuatro.UseVisualStyleBackColor = true;
            // 
            // chCinco
            // 
            resources.ApplyResources(this.chCinco, "chCinco");
            this.chCinco.Name = "chCinco";
            this.chCinco.UseVisualStyleBackColor = true;
            // 
            // chSeis
            // 
            resources.ApplyResources(this.chSeis, "chSeis");
            this.chSeis.Name = "chSeis";
            this.chSeis.UseVisualStyleBackColor = true;
            // 
            // gpbChecks
            // 
            this.gpbChecks.Controls.Add(this.chCuatro);
            this.gpbChecks.Controls.Add(this.chSeis);
            this.gpbChecks.Controls.Add(this.chCinco);
            resources.ApplyResources(this.gpbChecks, "gpbChecks");
            this.gpbChecks.Name = "gpbChecks";
            this.gpbChecks.TabStop = false;
            // 
            // gpbRadios
            // 
            this.gpbRadios.Controls.Add(this.rbUno);
            this.gpbRadios.Controls.Add(this.rbDos);
            this.gpbRadios.Controls.Add(this.rbTres);
            resources.ApplyResources(this.gpbRadios, "gpbRadios");
            this.gpbRadios.Name = "gpbRadios";
            this.gpbRadios.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            resources.ApplyResources(this.listBox1, "listBox1");
            this.listBox1.Name = "listBox1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            // 
            // FrmPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.gpbRadios);
            this.Controls.Add(this.gpbChecks);
            this.Controls.Add(this.numEdad);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.button1);
            this.Name = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).EndInit();
            this.gpbChecks.ResumeLayout(false);
            this.gpbChecks.PerformLayout();
            this.gpbRadios.ResumeLayout(false);
            this.gpbRadios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.NumericUpDown numEdad;
        private System.Windows.Forms.RadioButton rbUno;
        private System.Windows.Forms.RadioButton rbDos;
        private System.Windows.Forms.RadioButton rbTres;
        private System.Windows.Forms.CheckBox chCuatro;
        private System.Windows.Forms.CheckBox chCinco;
        private System.Windows.Forms.CheckBox chSeis;
        private System.Windows.Forms.GroupBox gpbChecks;
        private System.Windows.Forms.GroupBox gpbRadios;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

