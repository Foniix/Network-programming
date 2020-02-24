namespace ChatClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_connect = new System.Windows.Forms.Button();
            this.lb_chat = new System.Windows.Forms.ListBox();
            this.tb_msg = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NickName";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(75, 6);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(210, 20);
            this.tb_name.TabIndex = 1;
            // 
            // tb_connect
            // 
            this.tb_connect.Location = new System.Drawing.Point(291, 6);
            this.tb_connect.Name = "tb_connect";
            this.tb_connect.Size = new System.Drawing.Size(75, 23);
            this.tb_connect.TabIndex = 2;
            this.tb_connect.Text = "Connect";
            this.tb_connect.UseVisualStyleBackColor = true;
            this.tb_connect.Click += new System.EventHandler(this.btn_connetc_Click);
            // 
            // lb_chat
            // 
            this.lb_chat.FormattingEnabled = true;
            this.lb_chat.Location = new System.Drawing.Point(15, 35);
            this.lb_chat.Name = "lb_chat";
            this.lb_chat.Size = new System.Drawing.Size(351, 368);
            this.lb_chat.TabIndex = 3;
            // 
            // tb_msg
            // 
            this.tb_msg.Enabled = false;
            this.tb_msg.Location = new System.Drawing.Point(17, 427);
            this.tb_msg.Multiline = true;
            this.tb_msg.Name = "tb_msg";
            this.tb_msg.Size = new System.Drawing.Size(274, 43);
            this.tb_msg.TabIndex = 4;
            // 
            // btn_send
            // 
            this.btn_send.Enabled = false;
            this.btn_send.Location = new System.Drawing.Point(297, 427);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(69, 43);
            this.btn_send.TabIndex = 5;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 492);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.tb_msg);
            this.Controls.Add(this.lb_chat);
            this.Controls.Add(this.tb_connect);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Button tb_connect;
        private System.Windows.Forms.ListBox lb_chat;
        private System.Windows.Forms.TextBox tb_msg;
        private System.Windows.Forms.Button btn_send;
    }
}

