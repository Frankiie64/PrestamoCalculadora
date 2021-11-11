
namespace CalculadoraPrestamos
{
    partial class frmConvertidor
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
            this.LBLCantPrestamo = new System.Windows.Forms.Label();
            this.TXTCantPrestamo = new System.Windows.Forms.TextBox();
            this.LBLCuotaAnual = new System.Windows.Forms.Label();
            this.BTMCalcular = new System.Windows.Forms.Button();
            this.LBLCuotaMensual = new System.Windows.Forms.Label();
            this.TXTCuotaMensual = new System.Windows.Forms.TextBox();
            this.LBLTipoPrestamo = new System.Windows.Forms.Label();
            this.CBXTipoPrestamo = new System.Windows.Forms.ComboBox();
            this.LBLMembrete = new System.Windows.Forms.Label();
            this.LBLSubMembrete = new System.Windows.Forms.Label();
            this.LBLCreditos = new System.Windows.Forms.Label();
            this.LBLTasaAnual = new System.Windows.Forms.Label();
            this.TXTTasaAnual = new System.Windows.Forms.TextBox();
            this.CBXCuotasMensuales = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LBLCantPrestamo
            // 
            this.LBLCantPrestamo.AutoSize = true;
            this.LBLCantPrestamo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBLCantPrestamo.Location = new System.Drawing.Point(244, 99);
            this.LBLCantPrestamo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLCantPrestamo.Name = "LBLCantPrestamo";
            this.LBLCantPrestamo.Size = new System.Drawing.Size(255, 32);
            this.LBLCantPrestamo.TabIndex = 0;
            this.LBLCantPrestamo.Text = "Monto del prestamo:";
            // 
            // TXTCantPrestamo
            // 
            this.TXTCantPrestamo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TXTCantPrestamo.Location = new System.Drawing.Point(525, 92);
            this.TXTCantPrestamo.Margin = new System.Windows.Forms.Padding(4);
            this.TXTCantPrestamo.Name = "TXTCantPrestamo";
            this.TXTCantPrestamo.Size = new System.Drawing.Size(405, 31);
            this.TXTCantPrestamo.TabIndex = 1;
            // 
            // LBLCuotaAnual
            // 
            this.LBLCuotaAnual.AutoSize = true;
            this.LBLCuotaAnual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBLCuotaAnual.Location = new System.Drawing.Point(132, 234);
            this.LBLCuotaAnual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLCuotaAnual.Name = "LBLCuotaAnual";
            this.LBLCuotaAnual.Size = new System.Drawing.Size(367, 32);
            this.LBLCuotaAnual.TabIndex = 5;
            this.LBLCuotaAnual.Text = "Cantidad de cuotas mensuales:";
            // 
            // BTMCalcular
            // 
            this.BTMCalcular.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTMCalcular.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BTMCalcular.Location = new System.Drawing.Point(782, 292);
            this.BTMCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.BTMCalcular.Name = "BTMCalcular";
            this.BTMCalcular.Size = new System.Drawing.Size(157, 44);
            this.BTMCalcular.TabIndex = 6;
            this.BTMCalcular.Text = "Calcular";
            this.BTMCalcular.UseVisualStyleBackColor = false;
            this.BTMCalcular.Click += new System.EventHandler(this.BTMCalcular_Click);
            // 
            // LBLCuotaMensual
            // 
            this.LBLCuotaMensual.AutoSize = true;
            this.LBLCuotaMensual.Location = new System.Drawing.Point(297, 365);
            this.LBLCuotaMensual.Name = "LBLCuotaMensual";
            this.LBLCuotaMensual.Size = new System.Drawing.Size(202, 32);
            this.LBLCuotaMensual.TabIndex = 7;
            this.LBLCuotaMensual.Text = "Cuotas mensual:";
            // 
            // TXTCuotaMensual
            // 
            this.TXTCuotaMensual.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TXTCuotaMensual.Location = new System.Drawing.Point(525, 358);
            this.TXTCuotaMensual.Name = "TXTCuotaMensual";
            this.TXTCuotaMensual.ReadOnly = true;
            this.TXTCuotaMensual.Size = new System.Drawing.Size(414, 31);
            this.TXTCuotaMensual.TabIndex = 8;
            // 
            // LBLTipoPrestamo
            // 
            this.LBLTipoPrestamo.AutoSize = true;
            this.LBLTipoPrestamo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBLTipoPrestamo.Location = new System.Drawing.Point(266, 140);
            this.LBLTipoPrestamo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLTipoPrestamo.Name = "LBLTipoPrestamo";
            this.LBLTipoPrestamo.Size = new System.Drawing.Size(233, 32);
            this.LBLTipoPrestamo.TabIndex = 9;
            this.LBLTipoPrestamo.Text = "Tipo de prestamos:";
            // 
            // CBXTipoPrestamo
            // 
            this.CBXTipoPrestamo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CBXTipoPrestamo.FormattingEnabled = true;
            this.CBXTipoPrestamo.Location = new System.Drawing.Point(525, 137);
            this.CBXTipoPrestamo.Name = "CBXTipoPrestamo";
            this.CBXTipoPrestamo.Size = new System.Drawing.Size(405, 33);
            this.CBXTipoPrestamo.TabIndex = 10;
            this.CBXTipoPrestamo.SelectedValueChanged += new System.EventHandler(this.CBXTipoPrestamo_SelectedValueChanged);
            // 
            // LBLMembrete
            // 
            this.LBLMembrete.AutoSize = true;
            this.LBLMembrete.Location = new System.Drawing.Point(297, 9);
            this.LBLMembrete.Name = "LBLMembrete";
            this.LBLMembrete.Size = new System.Drawing.Size(438, 32);
            this.LBLMembrete.TabIndex = 11;
            this.LBLMembrete.Text = "Calculadora de Prestamos Mensuales";
            // 
            // LBLSubMembrete
            // 
            this.LBLSubMembrete.AutoSize = true;
            this.LBLSubMembrete.Location = new System.Drawing.Point(40, 41);
            this.LBLSubMembrete.Name = "LBLSubMembrete";
            this.LBLSubMembrete.Size = new System.Drawing.Size(927, 32);
            this.LBLSubMembrete.TabIndex = 12;
            this.LBLSubMembrete.Text = "Completa los siguiestes campos para poder asistirte de la mejor manera posible";
            // 
            // LBLCreditos
            // 
            this.LBLCreditos.AutoSize = true;
            this.LBLCreditos.Location = new System.Drawing.Point(12, 452);
            this.LBLCreditos.Name = "LBLCreditos";
            this.LBLCreditos.Size = new System.Drawing.Size(619, 32);
            this.LBLCreditos.TabIndex = 13;
            this.LBLCreditos.Text = "Programa desarrollado y diseñado por Franklyn Brea";
            // 
            // LBLTasaAnual
            // 
            this.LBLTasaAnual.AutoSize = true;
            this.LBLTasaAnual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBLTasaAnual.Location = new System.Drawing.Point(239, 191);
            this.LBLTasaAnual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLTasaAnual.Name = "LBLTasaAnual";
            this.LBLTasaAnual.Size = new System.Drawing.Size(260, 32);
            this.LBLTasaAnual.TabIndex = 15;
            this.LBLTasaAnual.Text = "Tasa de interes anual:";
            // 
            // TXTTasaAnual
            // 
            this.TXTTasaAnual.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TXTTasaAnual.Location = new System.Drawing.Point(525, 184);
            this.TXTTasaAnual.Margin = new System.Windows.Forms.Padding(4);
            this.TXTTasaAnual.Name = "TXTTasaAnual";
            this.TXTTasaAnual.ReadOnly = true;
            this.TXTTasaAnual.Size = new System.Drawing.Size(405, 31);
            this.TXTTasaAnual.TabIndex = 14;
            // 
            // CBXCuotasMensuales
            // 
            this.CBXCuotasMensuales.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CBXCuotasMensuales.FormattingEnabled = true;
            this.CBXCuotasMensuales.Location = new System.Drawing.Point(525, 234);
            this.CBXCuotasMensuales.Name = "CBXCuotasMensuales";
            this.CBXCuotasMensuales.Size = new System.Drawing.Size(405, 33);
            this.CBXCuotasMensuales.TabIndex = 16;
            // 
            // frmConvertidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(989, 493);
            this.Controls.Add(this.CBXCuotasMensuales);
            this.Controls.Add(this.LBLTasaAnual);
            this.Controls.Add(this.TXTTasaAnual);
            this.Controls.Add(this.LBLCreditos);
            this.Controls.Add(this.LBLSubMembrete);
            this.Controls.Add(this.LBLMembrete);
            this.Controls.Add(this.CBXTipoPrestamo);
            this.Controls.Add(this.LBLTipoPrestamo);
            this.Controls.Add(this.TXTCuotaMensual);
            this.Controls.Add(this.LBLCuotaMensual);
            this.Controls.Add(this.BTMCalcular);
            this.Controls.Add(this.LBLCuotaAnual);
            this.Controls.Add(this.TXTCantPrestamo);
            this.Controls.Add(this.LBLCantPrestamo);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmConvertidor";
            this.Text = "Calculadora de Prestamos";
            this.Load += new System.EventHandler(this.frmConvertidor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLCantPrestamo;
        private System.Windows.Forms.TextBox TXTCantPrestamo;
        private System.Windows.Forms.Label LBLCuotaAnual;
        private System.Windows.Forms.Button BTMCalcular;
        private System.Windows.Forms.Label LBLCuotaMensual;
        private System.Windows.Forms.TextBox TXTCuotaMensual;
        private System.Windows.Forms.Label LBLTipoPrestamo;
        private System.Windows.Forms.ComboBox CBXTipoPrestamo;
        private System.Windows.Forms.Label LBLMembrete;
        private System.Windows.Forms.Label LBLSubMembrete;
        private System.Windows.Forms.Label LBLCreditos;
        private System.Windows.Forms.Label LBLTasaAnual;
        private System.Windows.Forms.TextBox TXTTasaAnual;
        private System.Windows.Forms.ComboBox CBXCuotasMensuales;
    }
}

