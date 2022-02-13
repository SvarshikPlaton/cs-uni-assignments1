
namespace lb5WinApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.status = new System.Windows.Forms.GroupBox();
            this.gaugeBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.plusTemperature = new System.Windows.Forms.Button();
            this.minusTemperature = new System.Windows.Forms.Button();
            this.journal = new System.Windows.Forms.RichTextBox();
            this.thermometr = new System.Windows.Forms.PictureBox();
            this.status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thermometr)).BeginInit();
            this.SuspendLayout();
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.status.Controls.Add(this.gaugeBox);
            this.status.Controls.Add(this.label1);
            this.status.Controls.Add(this.plusTemperature);
            this.status.Controls.Add(this.minusTemperature);
            this.status.Dock = System.Windows.Forms.DockStyle.Top;
            this.status.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.status.Location = new System.Drawing.Point(0, 0);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(346, 159);
            this.status.TabIndex = 1;
            this.status.TabStop = false;
            this.status.Text = "Отопление: включено";
            // 
            // gaugeBox
            // 
            this.gaugeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gaugeBox.FormattingEnabled = true;
            this.gaugeBox.Items.AddRange(new object[] {
            "+ 50°C",
            "+ 40°C",
            "+ 30°C",
            "+ 20°C",
            "+ 10°C",
            "    0°C",
            "- 10°C",
            "- 20°C",
            "- 30°C",
            "- 40°C",
            "- 50°C"});
            this.gaugeBox.Location = new System.Drawing.Point(182, 119);
            this.gaugeBox.Name = "gaugeBox";
            this.gaugeBox.Size = new System.Drawing.Size(158, 28);
            this.gaugeBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Порог отопления:";
            // 
            // plusTemperature
            // 
            this.plusTemperature.Location = new System.Drawing.Point(12, 26);
            this.plusTemperature.Name = "plusTemperature";
            this.plusTemperature.Size = new System.Drawing.Size(328, 28);
            this.plusTemperature.TabIndex = 1;
            this.plusTemperature.Text = "+ 10°C";
            this.plusTemperature.UseVisualStyleBackColor = true;
            this.plusTemperature.Click += new System.EventHandler(this.plusTemperature_Click);
            // 
            // minusTemperature
            // 
            this.minusTemperature.Location = new System.Drawing.Point(12, 60);
            this.minusTemperature.Name = "minusTemperature";
            this.minusTemperature.Size = new System.Drawing.Size(328, 28);
            this.minusTemperature.TabIndex = 0;
            this.minusTemperature.Text = "- 10°C";
            this.minusTemperature.UseVisualStyleBackColor = true;
            this.minusTemperature.Click += new System.EventHandler(this.minusTemperature_Click);
            // 
            // journal
            // 
            this.journal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.journal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.journal.Location = new System.Drawing.Point(0, 159);
            this.journal.Name = "journal";
            this.journal.ReadOnly = true;
            this.journal.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.journal.Size = new System.Drawing.Size(346, 225);
            this.journal.TabIndex = 0;
            this.journal.Text = "";
            // 
            // thermometr
            // 
            this.thermometr.Dock = System.Windows.Forms.DockStyle.Right;
            this.thermometr.Image = ((System.Drawing.Image)(resources.GetObject("thermometr.Image")));
            this.thermometr.Location = new System.Drawing.Point(346, 0);
            this.thermometr.Name = "thermometr";
            this.thermometr.Size = new System.Drawing.Size(153, 384);
            this.thermometr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.thermometr.TabIndex = 0;
            this.thermometr.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 384);
            this.Controls.Add(this.journal);
            this.Controls.Add(this.status);
            this.Controls.Add(this.thermometr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Погода";
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thermometr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox status;
        private System.Windows.Forms.RichTextBox journal;
        private System.Windows.Forms.ComboBox gaugeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button plusTemperature;
        private System.Windows.Forms.Button minusTemperature;
        private System.Windows.Forms.PictureBox thermometr;
    }
}

