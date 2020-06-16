using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private IContainer components = null;
        private FlowLayoutPanel FlowLayoutPanel;
        private Label PrimaryLabel;
        private Label SecondaryLabel;
       
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
          this.components = new Container();
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(292, 266);
            this.Text = "FlowLayout";
            this.BackColor = Color.RosyBrown;

            this.FlowLayoutPanel = new FlowLayoutPanel();
            this.FlowLayoutPanel.Dock = DockStyle.Fill;
            this.FlowLayoutPanel.BackColor = Color.Pink;
            this.FlowLayoutPanel.FlowDirection = FlowDirection.TopDown; // BottomUp; LeftToRight; RightToLeft;

            this.PrimaryLabel = new Label();
            this.PrimaryLabel.Text = "Primeira Label";
            this.PrimaryLabel.ForeColor = Color.White;

            this.SecondaryLabel = new Label();
            this.SecondaryLabel.Text = "Segunda Label";
            this.SecondaryLabel.ForeColor = Color.White;

            this.FlowLayoutPanel.Controls.Add(this.PrimaryLabel);
            this.FlowLayoutPanel.Controls.Add(this.SecondaryLabel);
            this.Controls.Add(FlowLayoutPanel);
        }

        #endregion
    }
}

