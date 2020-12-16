namespace IRF_projekt
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.car_btn_save = new System.Windows.Forms.Button();
            this.exit_timer = new System.Windows.Forms.Timer(this.components);
            this.lblexit = new System.Windows.Forms.Label();
            this.reset_btn = new System.Windows.Forms.Button();
            this.car_btn = new System.Windows.Forms.Button();
            this.people_btn = new System.Windows.Forms.Button();
            this.store_btn = new System.Windows.Forms.Button();
            this.people_btn_save = new System.Windows.Forms.Button();
            this.store_btn_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(714, 272);
            this.dataGridView1.TabIndex = 0;
            // 
            // car_btn_save
            // 
            this.car_btn_save.Location = new System.Drawing.Point(12, 389);
            this.car_btn_save.Name = "car_btn_save";
            this.car_btn_save.Size = new System.Drawing.Size(124, 49);
            this.car_btn_save.TabIndex = 1;
            this.car_btn_save.Text = "Autók-Mentés";
            this.car_btn_save.UseVisualStyleBackColor = true;
            this.car_btn_save.Click += new System.EventHandler(this.car_btn_save_Click);
            // 
            // exit_timer
            // 
            this.exit_timer.Enabled = true;
            this.exit_timer.Interval = 1000;
            this.exit_timer.Tick += new System.EventHandler(this.exit_timer_Tick);
            // 
            // lblexit
            // 
            this.lblexit.AutoSize = true;
            this.lblexit.Location = new System.Drawing.Point(797, 27);
            this.lblexit.Name = "lblexit";
            this.lblexit.Size = new System.Drawing.Size(51, 20);
            this.lblexit.TabIndex = 2;
            this.lblexit.Text = "label1";
            // 
            // reset_btn
            // 
            this.reset_btn.Location = new System.Drawing.Point(801, 86);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(75, 43);
            this.reset_btn.TabIndex = 3;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // car_btn
            // 
            this.car_btn.Location = new System.Drawing.Point(12, 332);
            this.car_btn.Name = "car_btn";
            this.car_btn.Size = new System.Drawing.Size(75, 40);
            this.car_btn.TabIndex = 4;
            this.car_btn.Text = "Autók";
            this.car_btn.UseVisualStyleBackColor = true;
            this.car_btn.Click += new System.EventHandler(this.car_btn_Click);
            // 
            // people_btn
            // 
            this.people_btn.Location = new System.Drawing.Point(93, 332);
            this.people_btn.Name = "people_btn";
            this.people_btn.Size = new System.Drawing.Size(85, 40);
            this.people_btn.TabIndex = 5;
            this.people_btn.Text = "Emberek";
            this.people_btn.UseVisualStyleBackColor = true;
            this.people_btn.Click += new System.EventHandler(this.people_btn_Click);
            // 
            // store_btn
            // 
            this.store_btn.Location = new System.Drawing.Point(184, 332);
            this.store_btn.Name = "store_btn";
            this.store_btn.Size = new System.Drawing.Size(75, 40);
            this.store_btn.TabIndex = 6;
            this.store_btn.Text = "Bolt";
            this.store_btn.UseVisualStyleBackColor = true;
            this.store_btn.Click += new System.EventHandler(this.store_btn_Click);
            // 
            // people_btn_save
            // 
            this.people_btn_save.Location = new System.Drawing.Point(142, 389);
            this.people_btn_save.Name = "people_btn_save";
            this.people_btn_save.Size = new System.Drawing.Size(161, 49);
            this.people_btn_save.TabIndex = 7;
            this.people_btn_save.Text = "Emberek-Mentés";
            this.people_btn_save.UseVisualStyleBackColor = true;
            this.people_btn_save.Click += new System.EventHandler(this.people_btn_save_Click);
            // 
            // store_btn_save
            // 
            this.store_btn_save.Location = new System.Drawing.Point(309, 389);
            this.store_btn_save.Name = "store_btn_save";
            this.store_btn_save.Size = new System.Drawing.Size(124, 49);
            this.store_btn_save.TabIndex = 8;
            this.store_btn_save.Text = "Bolt-Mentés";
            this.store_btn_save.UseVisualStyleBackColor = true;
            this.store_btn_save.Click += new System.EventHandler(this.store_btn_save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 450);
            this.Controls.Add(this.store_btn_save);
            this.Controls.Add(this.people_btn_save);
            this.Controls.Add(this.store_btn);
            this.Controls.Add(this.people_btn);
            this.Controls.Add(this.car_btn);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.lblexit);
            this.Controls.Add(this.car_btn_save);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button car_btn_save;
        private System.Windows.Forms.Timer exit_timer;
        private System.Windows.Forms.Label lblexit;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Button car_btn;
        private System.Windows.Forms.Button people_btn;
        private System.Windows.Forms.Button store_btn;
        private System.Windows.Forms.Button people_btn_save;
        private System.Windows.Forms.Button store_btn_save;
    }
}

