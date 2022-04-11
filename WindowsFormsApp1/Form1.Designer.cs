
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_connect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_target_IP = new System.Windows.Forms.TextBox();
            this.textBox_target_Port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_listen_Port = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton_red = new System.Windows.Forms.RadioButton();
            this.radioButton_green = new System.Windows.Forms.RadioButton();
            this.radioButton_blue = new System.Windows.Forms.RadioButton();
            this.radioButton_black = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(647, 82);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(75, 23);
            this.button_connect.TabIndex = 0;
            this.button_connect.Text = "連線";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(68, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "目標IP";
            // 
            // textBox_target_IP
            // 
            this.textBox_target_IP.Location = new System.Drawing.Point(125, 83);
            this.textBox_target_IP.Name = "textBox_target_IP";
            this.textBox_target_IP.Size = new System.Drawing.Size(100, 22);
            this.textBox_target_IP.TabIndex = 2;
            // 
            // textBox_target_Port
            // 
            this.textBox_target_Port.Location = new System.Drawing.Point(321, 84);
            this.textBox_target_Port.Name = "textBox_target_Port";
            this.textBox_target_Port.Size = new System.Drawing.Size(100, 22);
            this.textBox_target_Port.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(254, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "目標Port";
            // 
            // textBox_listen_Port
            // 
            this.textBox_listen_Port.Location = new System.Drawing.Point(518, 82);
            this.textBox_listen_Port.Name = "textBox_listen_Port";
            this.textBox_listen_Port.Size = new System.Drawing.Size(100, 22);
            this.textBox_listen_Port.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(451, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "接聽Port";
            // 
            // radioButton_red
            // 
            this.radioButton_red.AutoSize = true;
            this.radioButton_red.Location = new System.Drawing.Point(47, 169);
            this.radioButton_red.Name = "radioButton_red";
            this.radioButton_red.Size = new System.Drawing.Size(38, 16);
            this.radioButton_red.TabIndex = 7;
            this.radioButton_red.TabStop = true;
            this.radioButton_red.Text = "red";
            this.radioButton_red.UseVisualStyleBackColor = true;
            // 
            // radioButton_green
            // 
            this.radioButton_green.AutoSize = true;
            this.radioButton_green.Location = new System.Drawing.Point(91, 169);
            this.radioButton_green.Name = "radioButton_green";
            this.radioButton_green.Size = new System.Drawing.Size(49, 16);
            this.radioButton_green.TabIndex = 8;
            this.radioButton_green.TabStop = true;
            this.radioButton_green.Text = "green";
            this.radioButton_green.UseVisualStyleBackColor = true;
            // 
            // radioButton_blue
            // 
            this.radioButton_blue.AutoSize = true;
            this.radioButton_blue.Location = new System.Drawing.Point(146, 169);
            this.radioButton_blue.Name = "radioButton_blue";
            this.radioButton_blue.Size = new System.Drawing.Size(43, 16);
            this.radioButton_blue.TabIndex = 9;
            this.radioButton_blue.TabStop = true;
            this.radioButton_blue.Text = "blue";
            this.radioButton_blue.UseVisualStyleBackColor = true;
            // 
            // radioButton_black
            // 
            this.radioButton_black.AutoSize = true;
            this.radioButton_black.Location = new System.Drawing.Point(195, 169);
            this.radioButton_black.Name = "radioButton_black";
            this.radioButton_black.Size = new System.Drawing.Size(48, 16);
            this.radioButton_black.TabIndex = 10;
            this.radioButton_black.TabStop = true;
            this.radioButton_black.Text = "black";
            this.radioButton_black.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButton_black);
            this.Controls.Add(this.radioButton_blue);
            this.Controls.Add(this.radioButton_green);
            this.Controls.Add(this.radioButton_red);
            this.Controls.Add(this.textBox_listen_Port);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_target_Port);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_target_IP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_connect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_target_IP;
        private System.Windows.Forms.TextBox textBox_target_Port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_listen_Port;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton_red;
        private System.Windows.Forms.RadioButton radioButton_green;
        private System.Windows.Forms.RadioButton radioButton_blue;
        private System.Windows.Forms.RadioButton radioButton_black;
    }
}

