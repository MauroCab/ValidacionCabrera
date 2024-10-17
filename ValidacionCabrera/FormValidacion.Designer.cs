namespace ValidacionCabrera
{
    partial class FormValidacion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabMenu = new System.Windows.Forms.TabControl();
            this.PatenteTab = new System.Windows.Forms.TabPage();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btIngresarPatente = new System.Windows.Forms.Button();
            this.lblTitulo1 = new System.Windows.Forms.Label();
            this.lblPatente = new System.Windows.Forms.Label();
            this.tbxPatente = new System.Windows.Forms.TextBox();
            this.CUILTab = new System.Windows.Forms.TabPage();
            this.lblDNI = new System.Windows.Forms.Label();
            this.btIngresarCUIL = new System.Windows.Forms.Button();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.lblCUIL = new System.Windows.Forms.Label();
            this.mtbxCUIL = new System.Windows.Forms.MaskedTextBox();
            this.TabMenu.SuspendLayout();
            this.PatenteTab.SuspendLayout();
            this.CUILTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabMenu
            // 
            this.TabMenu.Controls.Add(this.PatenteTab);
            this.TabMenu.Controls.Add(this.CUILTab);
            this.TabMenu.Location = new System.Drawing.Point(45, 43);
            this.TabMenu.Name = "TabMenu";
            this.TabMenu.SelectedIndex = 0;
            this.TabMenu.Size = new System.Drawing.Size(482, 294);
            this.TabMenu.TabIndex = 1;
            // 
            // PatenteTab
            // 
            this.PatenteTab.BackColor = System.Drawing.SystemColors.Control;
            this.PatenteTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PatenteTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PatenteTab.Controls.Add(this.lblResultado);
            this.PatenteTab.Controls.Add(this.btIngresarPatente);
            this.PatenteTab.Controls.Add(this.lblTitulo1);
            this.PatenteTab.Controls.Add(this.lblPatente);
            this.PatenteTab.Controls.Add(this.tbxPatente);
            this.PatenteTab.Location = new System.Drawing.Point(4, 22);
            this.PatenteTab.Name = "PatenteTab";
            this.PatenteTab.Padding = new System.Windows.Forms.Padding(3);
            this.PatenteTab.Size = new System.Drawing.Size(474, 268);
            this.PatenteTab.TabIndex = 0;
            this.PatenteTab.Text = "Patentes";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(226, 135);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(223, 21);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "La patente ingresada es: Válida";
            // 
            // btIngresarPatente
            // 
            this.btIngresarPatente.Location = new System.Drawing.Point(39, 162);
            this.btIngresarPatente.Name = "btIngresarPatente";
            this.btIngresarPatente.Size = new System.Drawing.Size(75, 23);
            this.btIngresarPatente.TabIndex = 5;
            this.btIngresarPatente.Text = "Ingresar";
            this.btIngresarPatente.UseVisualStyleBackColor = true;
            this.btIngresarPatente.Click += new System.EventHandler(this.btIngresarPatente_Click_1);
            // 
            // lblTitulo1
            // 
            this.lblTitulo1.AutoSize = true;
            this.lblTitulo1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo1.Location = new System.Drawing.Point(119, 15);
            this.lblTitulo1.Name = "lblTitulo1";
            this.lblTitulo1.Size = new System.Drawing.Size(223, 26);
            this.lblTitulo1.TabIndex = 4;
            this.lblTitulo1.Text = "Validación de Patentes";
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatente.Location = new System.Drawing.Point(35, 106);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(137, 21);
            this.lblPatente.TabIndex = 3;
            this.lblPatente.Text = "Ingrese su Patente";
            // 
            // tbxPatente
            // 
            this.tbxPatente.BackColor = System.Drawing.Color.White;
            this.tbxPatente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPatente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPatente.Location = new System.Drawing.Point(39, 130);
            this.tbxPatente.Name = "tbxPatente";
            this.tbxPatente.Size = new System.Drawing.Size(152, 26);
            this.tbxPatente.TabIndex = 0;
            this.tbxPatente.TextChanged += new System.EventHandler(this.tbxPatente_TextChanged);
            // 
            // CUILTab
            // 
            this.CUILTab.BackColor = System.Drawing.SystemColors.Control;
            this.CUILTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CUILTab.Controls.Add(this.mtbxCUIL);
            this.CUILTab.Controls.Add(this.lblDNI);
            this.CUILTab.Controls.Add(this.btIngresarCUIL);
            this.CUILTab.Controls.Add(this.lblTitulo2);
            this.CUILTab.Controls.Add(this.lblCUIL);
            this.CUILTab.Cursor = System.Windows.Forms.Cursors.Default;
            this.CUILTab.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CUILTab.Location = new System.Drawing.Point(4, 22);
            this.CUILTab.Name = "CUILTab";
            this.CUILTab.Padding = new System.Windows.Forms.Padding(3);
            this.CUILTab.Size = new System.Drawing.Size(474, 268);
            this.CUILTab.TabIndex = 1;
            this.CUILTab.Text = "CUIL a DNI";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(46, 182);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(210, 21);
            this.lblDNI.TabIndex = 11;
            this.lblDNI.Text = "El DNI del CUIL ingresado es:";
            // 
            // btIngresarCUIL
            // 
            this.btIngresarCUIL.Location = new System.Drawing.Point(50, 116);
            this.btIngresarCUIL.Name = "btIngresarCUIL";
            this.btIngresarCUIL.Size = new System.Drawing.Size(75, 23);
            this.btIngresarCUIL.TabIndex = 10;
            this.btIngresarCUIL.Text = "Ingresar";
            this.btIngresarCUIL.UseVisualStyleBackColor = true;
            this.btIngresarCUIL.Click += new System.EventHandler(this.btIngresarCUIL_Click);
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo2.Location = new System.Drawing.Point(177, 13);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(115, 26);
            this.lblTitulo2.TabIndex = 9;
            this.lblTitulo2.Text = "CUIL a DNI";
            // 
            // lblCUIL
            // 
            this.lblCUIL.AutoSize = true;
            this.lblCUIL.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCUIL.Location = new System.Drawing.Point(46, 60);
            this.lblCUIL.Name = "lblCUIL";
            this.lblCUIL.Size = new System.Drawing.Size(118, 21);
            this.lblCUIL.TabIndex = 8;
            this.lblCUIL.Text = "Ingrese su CUIL";
            // 
            // mtbxCUIL
            // 
            this.mtbxCUIL.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbxCUIL.Location = new System.Drawing.Point(50, 82);
            this.mtbxCUIL.Mask = "00-00000000-0";
            this.mtbxCUIL.Name = "mtbxCUIL";
            this.mtbxCUIL.Size = new System.Drawing.Size(170, 28);
            this.mtbxCUIL.TabIndex = 12;
            // 
            // FormValidacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 371);
            this.Controls.Add(this.TabMenu);
            this.Name = "FormValidacion";
            this.Text = "Validación";
            this.TabMenu.ResumeLayout(false);
            this.PatenteTab.ResumeLayout(false);
            this.PatenteTab.PerformLayout();
            this.CUILTab.ResumeLayout(false);
            this.CUILTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabMenu;
        private System.Windows.Forms.Button btIngresarPatente;
        private System.Windows.Forms.Label lblTitulo1;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.TextBox tbxPatente;
        private System.Windows.Forms.TabPage CUILTab;
        private System.Windows.Forms.Button btIngresarCUIL;
        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.Label lblCUIL;
        private System.Windows.Forms.TabPage PatenteTab;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.MaskedTextBox mtbxCUIL;
    }
}

