namespace TradingCoins.Controls
{
   partial class MarketDataCtrl
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

      #region Component Designer generated code

      /// <summary> 
      /// Required method for Designer support - do not modify 
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.gbMarketData = new System.Windows.Forms.GroupBox();
         this.label4 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.txtAskSz = new System.Windows.Forms.TextBox();
         this.txtBidSz = new System.Windows.Forms.TextBox();
         this.txtAskPx = new System.Windows.Forms.TextBox();
         this.txtBidPx = new System.Windows.Forms.TextBox();
         this.gbMarketData.SuspendLayout();
         this.SuspendLayout();
         // 
         // gbMarketData
         // 
         this.gbMarketData.Controls.Add(this.label4);
         this.gbMarketData.Controls.Add(this.label3);
         this.gbMarketData.Controls.Add(this.label2);
         this.gbMarketData.Controls.Add(this.label1);
         this.gbMarketData.Controls.Add(this.txtAskSz);
         this.gbMarketData.Controls.Add(this.txtBidSz);
         this.gbMarketData.Controls.Add(this.txtAskPx);
         this.gbMarketData.Controls.Add(this.txtBidPx);
         this.gbMarketData.Dock = System.Windows.Forms.DockStyle.Fill;
         this.gbMarketData.Location = new System.Drawing.Point(0, 0);
         this.gbMarketData.Name = "gbMarketData";
         this.gbMarketData.Size = new System.Drawing.Size(365, 92);
         this.gbMarketData.TabIndex = 4;
         this.gbMarketData.TabStop = false;
         this.gbMarketData.Text = "MarketData";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(230, 27);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(40, 13);
         this.label4.TabIndex = 8;
         this.label4.Text = "Ask Sz";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(155, 27);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(40, 13);
         this.label3.TabIndex = 7;
         this.label3.Text = "Ask Px";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(84, 27);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(37, 13);
         this.label2.TabIndex = 6;
         this.label2.Text = "Bid Px";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(27, 27);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(37, 13);
         this.label1.TabIndex = 5;
         this.label1.Text = "Bid Sz";
         // 
         // txtAskSz
         // 
         this.txtAskSz.Location = new System.Drawing.Point(233, 43);
         this.txtAskSz.Name = "txtAskSz";
         this.txtAskSz.Size = new System.Drawing.Size(50, 20);
         this.txtAskSz.TabIndex = 4;
         // 
         // txtBidSz
         // 
         this.txtBidSz.Location = new System.Drawing.Point(30, 43);
         this.txtBidSz.Name = "txtBidSz";
         this.txtBidSz.Size = new System.Drawing.Size(51, 20);
         this.txtBidSz.TabIndex = 3;
         // 
         // txtAskPx
         // 
         this.txtAskPx.Location = new System.Drawing.Point(158, 43);
         this.txtAskPx.Name = "txtAskPx";
         this.txtAskPx.Size = new System.Drawing.Size(56, 20);
         this.txtAskPx.TabIndex = 2;
         // 
         // txtBidPx
         // 
         this.txtBidPx.Location = new System.Drawing.Point(87, 43);
         this.txtBidPx.Name = "txtBidPx";
         this.txtBidPx.Size = new System.Drawing.Size(56, 20);
         this.txtBidPx.TabIndex = 1;
         // 
         // MarketDataCtrl
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.gbMarketData);
         this.Name = "MarketDataCtrl";
         this.Size = new System.Drawing.Size(365, 92);
         this.gbMarketData.ResumeLayout(false);
         this.gbMarketData.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.GroupBox gbMarketData;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox txtAskSz;
      private System.Windows.Forms.TextBox txtBidSz;
      private System.Windows.Forms.TextBox txtAskPx;
      private System.Windows.Forms.TextBox txtBidPx;
   }
}
