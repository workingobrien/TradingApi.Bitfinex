namespace TradingCoins.Controls
{
   partial class ExchangeAcctCtrl
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
         this.gbAcctInfo = new System.Windows.Forms.GroupBox();
         this.btnSendMultiple = new System.Windows.Forms.Button();
         this.txtBalances = new System.Windows.Forms.TextBox();
         this.btnGetBalances = new System.Windows.Forms.Button();
         this.btnSend = new System.Windows.Forms.Button();
         this.label2 = new System.Windows.Forms.Label();
         this.txtPrice = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.txtSize = new System.Windows.Forms.TextBox();
         this.lblBuySell = new System.Windows.Forms.Label();
         this.cbBuySell = new System.Windows.Forms.ComboBox();
         this.txtUsdBalance = new System.Windows.Forms.TextBox();
         this.txtLtcBalance = new System.Windows.Forms.TextBox();
         this.txtBtcBalance = new System.Windows.Forms.TextBox();
         this.lblUsdBalance = new System.Windows.Forms.Label();
         this.lblLtcBalance = new System.Windows.Forms.Label();
         this.lblBtcBalance = new System.Windows.Forms.Label();
         this.btnCancelReplace = new System.Windows.Forms.Button();
         this.txtCancelReplaceId = new System.Windows.Forms.TextBox();
         this.gbAcctInfo.SuspendLayout();
         this.SuspendLayout();
         // 
         // gbAcctInfo
         // 
         this.gbAcctInfo.Controls.Add(this.txtCancelReplaceId);
         this.gbAcctInfo.Controls.Add(this.btnCancelReplace);
         this.gbAcctInfo.Controls.Add(this.btnSendMultiple);
         this.gbAcctInfo.Controls.Add(this.txtBalances);
         this.gbAcctInfo.Controls.Add(this.btnGetBalances);
         this.gbAcctInfo.Controls.Add(this.btnSend);
         this.gbAcctInfo.Controls.Add(this.label2);
         this.gbAcctInfo.Controls.Add(this.txtPrice);
         this.gbAcctInfo.Controls.Add(this.label1);
         this.gbAcctInfo.Controls.Add(this.txtSize);
         this.gbAcctInfo.Controls.Add(this.lblBuySell);
         this.gbAcctInfo.Controls.Add(this.cbBuySell);
         this.gbAcctInfo.Controls.Add(this.txtUsdBalance);
         this.gbAcctInfo.Controls.Add(this.txtLtcBalance);
         this.gbAcctInfo.Controls.Add(this.txtBtcBalance);
         this.gbAcctInfo.Controls.Add(this.lblUsdBalance);
         this.gbAcctInfo.Controls.Add(this.lblLtcBalance);
         this.gbAcctInfo.Controls.Add(this.lblBtcBalance);
         this.gbAcctInfo.Dock = System.Windows.Forms.DockStyle.Fill;
         this.gbAcctInfo.Location = new System.Drawing.Point(0, 0);
         this.gbAcctInfo.Name = "gbAcctInfo";
         this.gbAcctInfo.Size = new System.Drawing.Size(636, 118);
         this.gbAcctInfo.TabIndex = 0;
         this.gbAcctInfo.TabStop = false;
         this.gbAcctInfo.Text = "Account Info";
         // 
         // btnSendMultiple
         // 
         this.btnSendMultiple.Location = new System.Drawing.Point(518, 45);
         this.btnSendMultiple.Name = "btnSendMultiple";
         this.btnSendMultiple.Size = new System.Drawing.Size(96, 23);
         this.btnSendMultiple.TabIndex = 15;
         this.btnSendMultiple.Text = "Send Multiple";
         this.btnSendMultiple.UseVisualStyleBackColor = true;
         this.btnSendMultiple.Click += new System.EventHandler(this.btnSendMultiple_Click);
         // 
         // txtBalances
         // 
         this.txtBalances.Location = new System.Drawing.Point(132, 58);
         this.txtBalances.Name = "txtBalances";
         this.txtBalances.Size = new System.Drawing.Size(337, 20);
         this.txtBalances.TabIndex = 14;
         // 
         // btnGetBalances
         // 
         this.btnGetBalances.Location = new System.Drawing.Point(18, 58);
         this.btnGetBalances.Name = "btnGetBalances";
         this.btnGetBalances.Size = new System.Drawing.Size(108, 23);
         this.btnGetBalances.TabIndex = 13;
         this.btnGetBalances.Text = "Get Balances";
         this.btnGetBalances.UseVisualStyleBackColor = true;
         this.btnGetBalances.Click += new System.EventHandler(this.button1_Click);
         // 
         // btnSend
         // 
         this.btnSend.Location = new System.Drawing.Point(539, 16);
         this.btnSend.Name = "btnSend";
         this.btnSend.Size = new System.Drawing.Size(75, 23);
         this.btnSend.TabIndex = 12;
         this.btnSend.Text = "Send Order";
         this.btnSend.UseVisualStyleBackColor = true;
         this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(450, 16);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(31, 13);
         this.label2.TabIndex = 11;
         this.label2.Text = "Price";
         // 
         // txtPrice
         // 
         this.txtPrice.Location = new System.Drawing.Point(453, 32);
         this.txtPrice.Name = "txtPrice";
         this.txtPrice.Size = new System.Drawing.Size(59, 20);
         this.txtPrice.TabIndex = 10;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(375, 16);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(22, 13);
         this.label1.TabIndex = 9;
         this.label1.Text = "Sz:";
         // 
         // txtSize
         // 
         this.txtSize.Location = new System.Drawing.Point(378, 33);
         this.txtSize.Name = "txtSize";
         this.txtSize.Size = new System.Drawing.Size(59, 20);
         this.txtSize.TabIndex = 8;
         // 
         // lblBuySell
         // 
         this.lblBuySell.AutoSize = true;
         this.lblBuySell.Location = new System.Drawing.Point(272, 16);
         this.lblBuySell.Name = "lblBuySell";
         this.lblBuySell.Size = new System.Drawing.Size(68, 13);
         this.lblBuySell.TabIndex = 7;
         this.lblBuySell.Text = "Usd Balance";
         // 
         // cbBuySell
         // 
         this.cbBuySell.FormattingEnabled = true;
         this.cbBuySell.Location = new System.Drawing.Point(275, 32);
         this.cbBuySell.Name = "cbBuySell";
         this.cbBuySell.Size = new System.Drawing.Size(86, 21);
         this.cbBuySell.TabIndex = 6;
         // 
         // txtUsdBalance
         // 
         this.txtUsdBalance.Location = new System.Drawing.Point(187, 32);
         this.txtUsdBalance.Name = "txtUsdBalance";
         this.txtUsdBalance.Size = new System.Drawing.Size(59, 20);
         this.txtUsdBalance.TabIndex = 5;
         // 
         // txtLtcBalance
         // 
         this.txtLtcBalance.Location = new System.Drawing.Point(100, 32);
         this.txtLtcBalance.Name = "txtLtcBalance";
         this.txtLtcBalance.Size = new System.Drawing.Size(59, 20);
         this.txtLtcBalance.TabIndex = 4;
         // 
         // txtBtcBalance
         // 
         this.txtBtcBalance.Location = new System.Drawing.Point(18, 32);
         this.txtBtcBalance.Name = "txtBtcBalance";
         this.txtBtcBalance.Size = new System.Drawing.Size(59, 20);
         this.txtBtcBalance.TabIndex = 3;
         // 
         // lblUsdBalance
         // 
         this.lblUsdBalance.AutoSize = true;
         this.lblUsdBalance.Location = new System.Drawing.Point(184, 16);
         this.lblUsdBalance.Name = "lblUsdBalance";
         this.lblUsdBalance.Size = new System.Drawing.Size(68, 13);
         this.lblUsdBalance.TabIndex = 2;
         this.lblUsdBalance.Text = "Usd Balance";
         // 
         // lblLtcBalance
         // 
         this.lblLtcBalance.AutoSize = true;
         this.lblLtcBalance.Location = new System.Drawing.Point(97, 16);
         this.lblLtcBalance.Name = "lblLtcBalance";
         this.lblLtcBalance.Size = new System.Drawing.Size(64, 13);
         this.lblLtcBalance.TabIndex = 1;
         this.lblLtcBalance.Text = "Ltc Balance";
         // 
         // lblBtcBalance
         // 
         this.lblBtcBalance.AutoSize = true;
         this.lblBtcBalance.Location = new System.Drawing.Point(15, 16);
         this.lblBtcBalance.Name = "lblBtcBalance";
         this.lblBtcBalance.Size = new System.Drawing.Size(62, 13);
         this.lblBtcBalance.TabIndex = 0;
         this.lblBtcBalance.Text = "BtcBalance";
         // 
         // btnCancelReplace
         // 
         this.btnCancelReplace.Location = new System.Drawing.Point(416, 89);
         this.btnCancelReplace.Name = "btnCancelReplace";
         this.btnCancelReplace.Size = new System.Drawing.Size(96, 23);
         this.btnCancelReplace.TabIndex = 16;
         this.btnCancelReplace.Text = "Cancel Replace";
         this.btnCancelReplace.UseVisualStyleBackColor = true;
         this.btnCancelReplace.Click += new System.EventHandler(this.btnCancelReplace_Click);
         // 
         // txtCancelReplaceId
         // 
         this.txtCancelReplaceId.Location = new System.Drawing.Point(518, 89);
         this.txtCancelReplaceId.Name = "txtCancelReplaceId";
         this.txtCancelReplaceId.Size = new System.Drawing.Size(96, 20);
         this.txtCancelReplaceId.TabIndex = 17;
         // 
         // ExchangeAcctCtrl
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.gbAcctInfo);
         this.Name = "ExchangeAcctCtrl";
         this.Size = new System.Drawing.Size(636, 118);
         this.gbAcctInfo.ResumeLayout(false);
         this.gbAcctInfo.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.GroupBox gbAcctInfo;
      private System.Windows.Forms.Label lblUsdBalance;
      private System.Windows.Forms.Label lblLtcBalance;
      private System.Windows.Forms.Label lblBtcBalance;
      private System.Windows.Forms.TextBox txtUsdBalance;
      private System.Windows.Forms.TextBox txtLtcBalance;
      private System.Windows.Forms.TextBox txtBtcBalance;
      private System.Windows.Forms.Button btnSend;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox txtPrice;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox txtSize;
      private System.Windows.Forms.Label lblBuySell;
      private System.Windows.Forms.ComboBox cbBuySell;
      private System.Windows.Forms.Button btnGetBalances;
      private System.Windows.Forms.TextBox txtBalances;
      private System.Windows.Forms.Button btnSendMultiple;
      private System.Windows.Forms.Button btnCancelReplace;
      private System.Windows.Forms.TextBox txtCancelReplaceId;
   }
}
