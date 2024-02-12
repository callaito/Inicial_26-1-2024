namespace Inicial_26_1_2024
{
    partial class Form1
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
            btn_Procesar=new Button();
            btn_Limpiar=new Button();
            btn_Salir=new Button();
            txt_Edad=new TextBox();
            txt_Situacion=new TextBox();
            txt_Genero=new TextBox();
            label1=new Label();
            label2=new Label();
            label3=new Label();
            label4=new Label();
            SuspendLayout();
            // 
            // btn_Procesar
            // 
            btn_Procesar.BackColor=SystemColors.ControlLight;
            btn_Procesar.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Procesar.Location=new Point(532, 94);
            btn_Procesar.Name="btn_Procesar";
            btn_Procesar.Size=new Size(103, 35);
            btn_Procesar.TabIndex=0;
            btn_Procesar.Text="Procesar";
            btn_Procesar.UseVisualStyleBackColor=false;
            btn_Procesar.Click+=btn_Procesar_Click;
            // 
            // btn_Limpiar
            // 
            btn_Limpiar.BackColor=SystemColors.ControlLight;
            btn_Limpiar.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Limpiar.Location=new Point(532, 135);
            btn_Limpiar.Name="btn_Limpiar";
            btn_Limpiar.Size=new Size(103, 37);
            btn_Limpiar.TabIndex=1;
            btn_Limpiar.Text="Limpiar";
            btn_Limpiar.UseVisualStyleBackColor=false;
            btn_Limpiar.Click+=btn_Limpiar_Click_1;
            // 
            // btn_Salir
            // 
            btn_Salir.BackColor=SystemColors.ControlLight;
            btn_Salir.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Salir.Location=new Point(532, 178);
            btn_Salir.Name="btn_Salir";
            btn_Salir.Size=new Size(103, 36);
            btn_Salir.TabIndex=2;
            btn_Salir.Text="Salir";
            btn_Salir.UseVisualStyleBackColor=false;
            btn_Salir.Click+=btn_Salir_Click;
            // 
            // txt_Edad
            // 
            txt_Edad.Location=new Point(307, 115);
            txt_Edad.Name="txt_Edad";
            txt_Edad.Size=new Size(76, 23);
            txt_Edad.TabIndex=3;
            // 
            // txt_Situacion
            // 
            txt_Situacion.Location=new Point(307, 183);
            txt_Situacion.Name="txt_Situacion";
            txt_Situacion.Size=new Size(196, 23);
            txt_Situacion.TabIndex=4;
            txt_Situacion.TextChanged+=txt_Situacion_TextChanged;
            // 
            // txt_Genero
            // 
            txt_Genero.Location=new Point(307, 144);
            txt_Genero.Name="txt_Genero";
            txt_Genero.Size=new Size(76, 23);
            txt_Genero.TabIndex=5;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location=new Point(226, 118);
            label1.Name="label1";
            label1.Size=new Size(40, 15);
            label1.TabIndex=6;
            label1.Text="EDAD";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location=new Point(226, 147);
            label2.Name="label2";
            label2.Size=new Size(57, 15);
            label2.TabIndex=7;
            label2.Text="GENERO";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Font=new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location=new Point(226, 183);
            label3.Name="label3";
            label3.Size=new Size(75, 15);
            label3.TabIndex=8;
            label3.Text="SITUACION";
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Font=new Font("Impact", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location=new Point(343, 9);
            label4.Name="label4";
            label4.Size=new Size(143, 34);
            label4.TabIndex=9;
            label4.Text="DISCOTECA";
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=SystemColors.ActiveCaption;
            ClientSize=new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_Genero);
            Controls.Add(txt_Situacion);
            Controls.Add(txt_Edad);
            Controls.Add(btn_Salir);
            Controls.Add(btn_Limpiar);
            Controls.Add(btn_Procesar);
            Name="Form1";
            Text="Form1";
            Load+=Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Procesar;
        private Button btn_Limpiar;
        private Button btn_Salir;
        private TextBox txt_Edad;
        private TextBox txt_Situacion;
        private TextBox txt_Genero;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}