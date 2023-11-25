namespace DocRaul
{
    partial class frmPaciente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtNombre = new TextBox();
            txtApellidoMat = new TextBox();
            label2 = new Label();
            txtApellidoPat = new TextBox();
            label3 = new Label();
            txtEdad = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label6 = new Label();
            txtNumTel = new TextBox();
            label5 = new Label();
            txtDireccion = new TextBox();
            label7 = new Label();
            txtCommentary = new TextBox();
            label8 = new Label();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(66, 20);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(300, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtApellidoMat
            // 
            txtApellidoMat.Location = new Point(117, 97);
            txtApellidoMat.Name = "txtApellidoMat";
            txtApellidoMat.Size = new Size(249, 23);
            txtApellidoMat.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 59);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 2;
            label2.Text = "Apellido paterno";
            // 
            // txtApellidoPat
            // 
            txtApellidoPat.Location = new Point(117, 56);
            txtApellidoPat.Name = "txtApellidoPat";
            txtApellidoPat.Size = new Size(249, 23);
            txtApellidoPat.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 100);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 4;
            label3.Text = "Apellido materno";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(51, 164);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(64, 23);
            txtEdad.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 167);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 6;
            label4.Text = "Edad";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(123, 201);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(243, 23);
            txtEmail.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 204);
            label6.Name = "label6";
            label6.Size = new Size(105, 15);
            label6.TabIndex = 8;
            label6.Text = "Correo electronico";
            // 
            // txtNumTel
            // 
            txtNumTel.Location = new Point(229, 164);
            txtNumTel.Name = "txtNumTel";
            txtNumTel.Size = new Size(137, 23);
            txtNumTel.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(130, 167);
            label5.Name = "label5";
            label5.Size = new Size(93, 15);
            label5.TabIndex = 10;
            label5.Text = "Num. telefonico";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(117, 130);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(249, 23);
            txtDireccion.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 133);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 12;
            label7.Text = "Direccion";
            // 
            // txtCommentary
            // 
            txtCommentary.Location = new Point(88, 239);
            txtCommentary.Name = "txtCommentary";
            txtCommentary.Size = new Size(278, 23);
            txtCommentary.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 242);
            label8.Name = "label8";
            label8.Size = new Size(70, 15);
            label8.TabIndex = 14;
            label8.Text = "Comentario";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(42, 300);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 16;
            btnSave.Text = "button1";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // Paciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 450);
            Controls.Add(btnSave);
            Controls.Add(txtCommentary);
            Controls.Add(label8);
            Controls.Add(txtDireccion);
            Controls.Add(label7);
            Controls.Add(txtNumTel);
            Controls.Add(label5);
            Controls.Add(txtEmail);
            Controls.Add(label6);
            Controls.Add(txtEdad);
            Controls.Add(label4);
            Controls.Add(txtApellidoPat);
            Controls.Add(label3);
            Controls.Add(txtApellidoMat);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "Paciente";
            Text = "Paciente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private TextBox txtApellidoMat;
        private Label label2;
        private TextBox txtApellidoPat;
        private Label label3;
        private TextBox txtEdad;
        private Label label4;
        private TextBox txtEmail;
        private Label label6;
        private TextBox txtNumTel;
        private Label label5;
        private TextBox txtDireccion;
        private Label label7;
        private TextBox txtCommentary;
        private Label label8;
        private Button btnSave;
    }
}