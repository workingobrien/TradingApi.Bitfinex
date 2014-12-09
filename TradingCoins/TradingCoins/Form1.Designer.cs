namespace TradingCoins
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
         this.btnStart = new System.Windows.Forms.Button();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.btnMarginInfo = new System.Windows.Forms.Button();
         this.btnAccountInfo = new System.Windows.Forms.Button();
         this.btnDeposit = new System.Windows.Forms.Button();
         this.label5 = new System.Windows.Forms.Label();
         this.cbDepositTo = new System.Windows.Forms.ComboBox();
         this.btnGetMyTrades = new System.Windows.Forms.Button();
         this.label4 = new System.Windows.Forms.Label();
         this.cbSymbols = new System.Windows.Forms.ComboBox();
         this.label3 = new System.Windows.Forms.Label();
         this.cbWalletType = new System.Windows.Forms.ComboBox();
         this.btnGetHistory = new System.Windows.Forms.Button();
         this.btnGetActivePos = new System.Windows.Forms.Button();
         this.btnGetActiveOrders = new System.Windows.Forms.Button();
         this.btnGetLends = new System.Windows.Forms.Button();
         this.btnGetLendbook = new System.Windows.Forms.Button();
         this.btnGetSymbols = new System.Windows.Forms.Button();
         this.lbGenericData = new System.Windows.Forms.ListBox();
         this.btnGetDataFromCallType = new System.Windows.Forms.Button();
         this.label2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.cbCallTypes = new System.Windows.Forms.ComboBox();
         this.cbPair = new System.Windows.Forms.ComboBox();
         this.txtCancelMultiple = new System.Windows.Forms.TextBox();
         this.btnCancelMultiple = new System.Windows.Forms.Button();
         this.btnCancelAll = new System.Windows.Forms.Button();
         this.btnCancelOrder = new System.Windows.Forms.Button();
         this.txtOrderId = new System.Windows.Forms.TextBox();
         this.btnGetOrderStatus = new System.Windows.Forms.Button();
         this.gbExchange1 = new System.Windows.Forms.GroupBox();
         this.pnlExchange1Trading = new System.Windows.Forms.Panel();
         this.pnlExchange1MarketData = new System.Windows.Forms.Panel();
         this.lbLogger = new System.Windows.Forms.ListBox();
         this.groupBox2 = new System.Windows.Forms.GroupBox();
         this.label6 = new System.Windows.Forms.Label();
         this.cbCurrency = new System.Windows.Forms.ComboBox();
         this.txtOfferAmount = new System.Windows.Forms.TextBox();
         this.label7 = new System.Windows.Forms.Label();
         this.label8 = new System.Windows.Forms.Label();
         this.txtRate = new System.Windows.Forms.TextBox();
         this.label9 = new System.Windows.Forms.Label();
         this.txtDays = new System.Windows.Forms.TextBox();
         this.label10 = new System.Windows.Forms.Label();
         this.cbDirection = new System.Windows.Forms.ComboBox();
         this.btnSendNewOffer = new System.Windows.Forms.Button();
         this.btnCancelOffer = new System.Windows.Forms.Button();
         this.btnGetOfferStatus = new System.Windows.Forms.Button();
         this.btnGetActiveOffers = new System.Windows.Forms.Button();
         this.btnGetActiveCredits = new System.Windows.Forms.Button();
         this.btnGetActiveSwapsInMarginPos = new System.Windows.Forms.Button();
         this.btnCloseSwap = new System.Windows.Forms.Button();
         this.btnClaimPosition = new System.Windows.Forms.Button();
         this.groupBox1.SuspendLayout();
         this.gbExchange1.SuspendLayout();
         this.groupBox2.SuspendLayout();
         this.SuspendLayout();
         // 
         // btnStart
         // 
         this.btnStart.Location = new System.Drawing.Point(687, 19);
         this.btnStart.Name = "btnStart";
         this.btnStart.Size = new System.Drawing.Size(128, 23);
         this.btnStart.TabIndex = 4;
         this.btnStart.Text = "Start Market Data";
         this.btnStart.UseVisualStyleBackColor = true;
         this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.btnClaimPosition);
         this.groupBox1.Controls.Add(this.btnCloseSwap);
         this.groupBox1.Controls.Add(this.btnGetOfferStatus);
         this.groupBox1.Controls.Add(this.btnCancelOffer);
         this.groupBox1.Controls.Add(this.btnMarginInfo);
         this.groupBox1.Controls.Add(this.btnAccountInfo);
         this.groupBox1.Controls.Add(this.btnDeposit);
         this.groupBox1.Controls.Add(this.label5);
         this.groupBox1.Controls.Add(this.cbDepositTo);
         this.groupBox1.Controls.Add(this.btnGetMyTrades);
         this.groupBox1.Controls.Add(this.label4);
         this.groupBox1.Controls.Add(this.cbSymbols);
         this.groupBox1.Controls.Add(this.label3);
         this.groupBox1.Controls.Add(this.cbWalletType);
         this.groupBox1.Controls.Add(this.btnGetHistory);
         this.groupBox1.Controls.Add(this.btnGetActivePos);
         this.groupBox1.Controls.Add(this.btnGetActiveOrders);
         this.groupBox1.Controls.Add(this.btnGetLends);
         this.groupBox1.Controls.Add(this.btnGetLendbook);
         this.groupBox1.Controls.Add(this.btnGetSymbols);
         this.groupBox1.Controls.Add(this.lbGenericData);
         this.groupBox1.Controls.Add(this.btnGetDataFromCallType);
         this.groupBox1.Controls.Add(this.label2);
         this.groupBox1.Controls.Add(this.label1);
         this.groupBox1.Controls.Add(this.cbCallTypes);
         this.groupBox1.Controls.Add(this.cbPair);
         this.groupBox1.Controls.Add(this.txtCancelMultiple);
         this.groupBox1.Controls.Add(this.btnCancelMultiple);
         this.groupBox1.Controls.Add(this.btnCancelAll);
         this.groupBox1.Controls.Add(this.btnCancelOrder);
         this.groupBox1.Controls.Add(this.txtOrderId);
         this.groupBox1.Controls.Add(this.btnGetOrderStatus);
         this.groupBox1.Controls.Add(this.btnStart);
         this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
         this.groupBox1.Location = new System.Drawing.Point(0, 0);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(853, 307);
         this.groupBox1.TabIndex = 5;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "General Stuff";
         // 
         // btnMarginInfo
         // 
         this.btnMarginInfo.Location = new System.Drawing.Point(258, 209);
         this.btnMarginInfo.Name = "btnMarginInfo";
         this.btnMarginInfo.Size = new System.Drawing.Size(99, 23);
         this.btnMarginInfo.TabIndex = 32;
         this.btnMarginInfo.Text = "Get Margin Info";
         this.btnMarginInfo.UseVisualStyleBackColor = true;
         this.btnMarginInfo.Click += new System.EventHandler(this.btnMarginInfo_Click);
         // 
         // btnAccountInfo
         // 
         this.btnAccountInfo.Location = new System.Drawing.Point(148, 209);
         this.btnAccountInfo.Name = "btnAccountInfo";
         this.btnAccountInfo.Size = new System.Drawing.Size(99, 23);
         this.btnAccountInfo.TabIndex = 31;
         this.btnAccountInfo.Text = "Get Account Info";
         this.btnAccountInfo.UseVisualStyleBackColor = true;
         this.btnAccountInfo.Click += new System.EventHandler(this.btnAccountInfo_Click);
         // 
         // btnDeposit
         // 
         this.btnDeposit.Location = new System.Drawing.Point(519, 276);
         this.btnDeposit.Name = "btnDeposit";
         this.btnDeposit.Size = new System.Drawing.Size(99, 23);
         this.btnDeposit.TabIndex = 30;
         this.btnDeposit.Text = "Deposit";
         this.btnDeposit.UseVisualStyleBackColor = true;
         this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(389, 259);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(62, 13);
         this.label5.TabIndex = 29;
         this.label5.Text = "Deposit To:";
         this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // cbDepositTo
         // 
         this.cbDepositTo.FormattingEnabled = true;
         this.cbDepositTo.Location = new System.Drawing.Point(392, 278);
         this.cbDepositTo.Name = "cbDepositTo";
         this.cbDepositTo.Size = new System.Drawing.Size(121, 21);
         this.cbDepositTo.TabIndex = 28;
         // 
         // btnGetMyTrades
         // 
         this.btnGetMyTrades.Location = new System.Drawing.Point(15, 209);
         this.btnGetMyTrades.Name = "btnGetMyTrades";
         this.btnGetMyTrades.Size = new System.Drawing.Size(99, 23);
         this.btnGetMyTrades.TabIndex = 27;
         this.btnGetMyTrades.Text = "Get My Trades";
         this.btnGetMyTrades.UseVisualStyleBackColor = true;
         this.btnGetMyTrades.Click += new System.EventHandler(this.btnGetMyTrades_Click);
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(255, 259);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(44, 13);
         this.label4.TabIndex = 26;
         this.label4.Text = "Symbol:";
         // 
         // cbSymbols
         // 
         this.cbSymbols.FormattingEnabled = true;
         this.cbSymbols.Location = new System.Drawing.Point(258, 278);
         this.cbSymbols.Name = "cbSymbols";
         this.cbSymbols.Size = new System.Drawing.Size(121, 21);
         this.cbSymbols.TabIndex = 25;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(109, 259);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(67, 13);
         this.label3.TabIndex = 24;
         this.label3.Text = "Wallet Type:";
         this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // cbWalletType
         // 
         this.cbWalletType.FormattingEnabled = true;
         this.cbWalletType.Location = new System.Drawing.Point(112, 278);
         this.cbWalletType.Name = "cbWalletType";
         this.cbWalletType.Size = new System.Drawing.Size(121, 21);
         this.cbWalletType.TabIndex = 23;
         // 
         // btnGetHistory
         // 
         this.btnGetHistory.Location = new System.Drawing.Point(6, 278);
         this.btnGetHistory.Name = "btnGetHistory";
         this.btnGetHistory.Size = new System.Drawing.Size(99, 23);
         this.btnGetHistory.TabIndex = 22;
         this.btnGetHistory.Text = "Get History";
         this.btnGetHistory.UseVisualStyleBackColor = true;
         this.btnGetHistory.Click += new System.EventHandler(this.btnGetHistory_Click);
         // 
         // btnGetActivePos
         // 
         this.btnGetActivePos.Location = new System.Drawing.Point(148, 180);
         this.btnGetActivePos.Name = "btnGetActivePos";
         this.btnGetActivePos.Size = new System.Drawing.Size(99, 23);
         this.btnGetActivePos.TabIndex = 21;
         this.btnGetActivePos.Text = "Get Active Pos";
         this.btnGetActivePos.UseVisualStyleBackColor = true;
         this.btnGetActivePos.Click += new System.EventHandler(this.btnGetActivePos_Click);
         // 
         // btnGetActiveOrders
         // 
         this.btnGetActiveOrders.Location = new System.Drawing.Point(148, 151);
         this.btnGetActiveOrders.Name = "btnGetActiveOrders";
         this.btnGetActiveOrders.Size = new System.Drawing.Size(99, 23);
         this.btnGetActiveOrders.TabIndex = 20;
         this.btnGetActiveOrders.Text = "Get Active Orders";
         this.btnGetActiveOrders.UseVisualStyleBackColor = true;
         this.btnGetActiveOrders.Click += new System.EventHandler(this.btnGetActiveOrders_Click);
         // 
         // btnGetLends
         // 
         this.btnGetLends.Location = new System.Drawing.Point(15, 180);
         this.btnGetLends.Name = "btnGetLends";
         this.btnGetLends.Size = new System.Drawing.Size(99, 23);
         this.btnGetLends.TabIndex = 19;
         this.btnGetLends.Text = "Get Lends";
         this.btnGetLends.UseVisualStyleBackColor = true;
         this.btnGetLends.Click += new System.EventHandler(this.btnGetLends_Click);
         // 
         // btnGetLendbook
         // 
         this.btnGetLendbook.Location = new System.Drawing.Point(15, 151);
         this.btnGetLendbook.Name = "btnGetLendbook";
         this.btnGetLendbook.Size = new System.Drawing.Size(99, 23);
         this.btnGetLendbook.TabIndex = 17;
         this.btnGetLendbook.Text = "Get Lendbook";
         this.btnGetLendbook.UseVisualStyleBackColor = true;
         this.btnGetLendbook.Click += new System.EventHandler(this.btnGetLendbook_Click);
         // 
         // btnGetSymbols
         // 
         this.btnGetSymbols.Location = new System.Drawing.Point(148, 122);
         this.btnGetSymbols.Name = "btnGetSymbols";
         this.btnGetSymbols.Size = new System.Drawing.Size(99, 23);
         this.btnGetSymbols.TabIndex = 16;
         this.btnGetSymbols.Text = "Get Symbols";
         this.btnGetSymbols.UseVisualStyleBackColor = true;
         this.btnGetSymbols.Click += new System.EventHandler(this.btnGetSymbols_Click);
         // 
         // lbGenericData
         // 
         this.lbGenericData.FormattingEnabled = true;
         this.lbGenericData.Location = new System.Drawing.Point(278, 95);
         this.lbGenericData.Name = "lbGenericData";
         this.lbGenericData.ScrollAlwaysVisible = true;
         this.lbGenericData.Size = new System.Drawing.Size(569, 95);
         this.lbGenericData.TabIndex = 7;
         // 
         // btnGetDataFromCallType
         // 
         this.btnGetDataFromCallType.Location = new System.Drawing.Point(15, 122);
         this.btnGetDataFromCallType.Name = "btnGetDataFromCallType";
         this.btnGetDataFromCallType.Size = new System.Drawing.Size(99, 23);
         this.btnGetDataFromCallType.TabIndex = 15;
         this.btnGetDataFromCallType.Text = "Get Generic Data";
         this.btnGetDataFromCallType.UseVisualStyleBackColor = true;
         this.btnGetDataFromCallType.Click += new System.EventHandler(this.btnGetDataFromCallType_Click);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(145, 76);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(54, 13);
         this.label2.TabIndex = 14;
         this.label2.Text = "Call Type:";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(12, 76);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(30, 13);
         this.label1.TabIndex = 13;
         this.label1.Text = "Pairs";
         // 
         // cbCallTypes
         // 
         this.cbCallTypes.FormattingEnabled = true;
         this.cbCallTypes.Location = new System.Drawing.Point(148, 95);
         this.cbCallTypes.Name = "cbCallTypes";
         this.cbCallTypes.Size = new System.Drawing.Size(121, 21);
         this.cbCallTypes.TabIndex = 12;
         this.cbCallTypes.SelectedIndexChanged += new System.EventHandler(this.cbCallTypes_SelectedIndexChanged);
         // 
         // cbPair
         // 
         this.cbPair.FormattingEnabled = true;
         this.cbPair.Location = new System.Drawing.Point(12, 95);
         this.cbPair.Name = "cbPair";
         this.cbPair.Size = new System.Drawing.Size(121, 21);
         this.cbPair.TabIndex = 11;
         this.cbPair.SelectedIndexChanged += new System.EventHandler(this.cbSymbols_SelectedIndexChanged);
         // 
         // txtCancelMultiple
         // 
         this.txtCancelMultiple.Location = new System.Drawing.Point(555, 48);
         this.txtCancelMultiple.Name = "txtCancelMultiple";
         this.txtCancelMultiple.Size = new System.Drawing.Size(169, 20);
         this.txtCancelMultiple.TabIndex = 10;
         // 
         // btnCancelMultiple
         // 
         this.btnCancelMultiple.Location = new System.Drawing.Point(450, 48);
         this.btnCancelMultiple.Name = "btnCancelMultiple";
         this.btnCancelMultiple.Size = new System.Drawing.Size(99, 23);
         this.btnCancelMultiple.TabIndex = 9;
         this.btnCancelMultiple.Text = "Cancel Multiple";
         this.btnCancelMultiple.UseVisualStyleBackColor = true;
         this.btnCancelMultiple.Click += new System.EventHandler(this.btnCancelMultiple_Click);
         // 
         // btnCancelAll
         // 
         this.btnCancelAll.Location = new System.Drawing.Point(450, 19);
         this.btnCancelAll.Name = "btnCancelAll";
         this.btnCancelAll.Size = new System.Drawing.Size(99, 23);
         this.btnCancelAll.TabIndex = 8;
         this.btnCancelAll.Text = "Cancel All";
         this.btnCancelAll.UseVisualStyleBackColor = true;
         this.btnCancelAll.Click += new System.EventHandler(this.btnCancelAll_Click);
         // 
         // btnCancelOrder
         // 
         this.btnCancelOrder.Location = new System.Drawing.Point(18, 45);
         this.btnCancelOrder.Name = "btnCancelOrder";
         this.btnCancelOrder.Size = new System.Drawing.Size(99, 23);
         this.btnCancelOrder.TabIndex = 7;
         this.btnCancelOrder.Text = "Cancel Order";
         this.btnCancelOrder.UseVisualStyleBackColor = true;
         this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
         // 
         // txtOrderId
         // 
         this.txtOrderId.Location = new System.Drawing.Point(236, 21);
         this.txtOrderId.Name = "txtOrderId";
         this.txtOrderId.Size = new System.Drawing.Size(100, 20);
         this.txtOrderId.TabIndex = 6;
         // 
         // btnGetOrderStatus
         // 
         this.btnGetOrderStatus.Location = new System.Drawing.Point(18, 19);
         this.btnGetOrderStatus.Name = "btnGetOrderStatus";
         this.btnGetOrderStatus.Size = new System.Drawing.Size(99, 23);
         this.btnGetOrderStatus.TabIndex = 5;
         this.btnGetOrderStatus.Text = "GetOrderStatus";
         this.btnGetOrderStatus.UseVisualStyleBackColor = true;
         this.btnGetOrderStatus.Click += new System.EventHandler(this.btnGetOrderStatus_Click);
         // 
         // gbExchange1
         // 
         this.gbExchange1.Controls.Add(this.pnlExchange1Trading);
         this.gbExchange1.Controls.Add(this.pnlExchange1MarketData);
         this.gbExchange1.Location = new System.Drawing.Point(12, 332);
         this.gbExchange1.Name = "gbExchange1";
         this.gbExchange1.Size = new System.Drawing.Size(829, 237);
         this.gbExchange1.TabIndex = 0;
         this.gbExchange1.TabStop = false;
         this.gbExchange1.Text = "Exchange 1";
         // 
         // pnlExchange1Trading
         // 
         this.pnlExchange1Trading.Dock = System.Windows.Forms.DockStyle.Fill;
         this.pnlExchange1Trading.Location = new System.Drawing.Point(3, 114);
         this.pnlExchange1Trading.Name = "pnlExchange1Trading";
         this.pnlExchange1Trading.Size = new System.Drawing.Size(823, 120);
         this.pnlExchange1Trading.TabIndex = 1;
         // 
         // pnlExchange1MarketData
         // 
         this.pnlExchange1MarketData.Dock = System.Windows.Forms.DockStyle.Top;
         this.pnlExchange1MarketData.Location = new System.Drawing.Point(3, 16);
         this.pnlExchange1MarketData.Name = "pnlExchange1MarketData";
         this.pnlExchange1MarketData.Size = new System.Drawing.Size(823, 98);
         this.pnlExchange1MarketData.TabIndex = 0;
         // 
         // lbLogger
         // 
         this.lbLogger.FormattingEnabled = true;
         this.lbLogger.Location = new System.Drawing.Point(12, 707);
         this.lbLogger.Name = "lbLogger";
         this.lbLogger.ScrollAlwaysVisible = true;
         this.lbLogger.Size = new System.Drawing.Size(820, 121);
         this.lbLogger.TabIndex = 6;
         // 
         // groupBox2
         // 
         this.groupBox2.Controls.Add(this.btnGetActiveSwapsInMarginPos);
         this.groupBox2.Controls.Add(this.btnGetActiveCredits);
         this.groupBox2.Controls.Add(this.btnGetActiveOffers);
         this.groupBox2.Controls.Add(this.btnSendNewOffer);
         this.groupBox2.Controls.Add(this.label10);
         this.groupBox2.Controls.Add(this.cbDirection);
         this.groupBox2.Controls.Add(this.label9);
         this.groupBox2.Controls.Add(this.txtDays);
         this.groupBox2.Controls.Add(this.label8);
         this.groupBox2.Controls.Add(this.txtRate);
         this.groupBox2.Controls.Add(this.label7);
         this.groupBox2.Controls.Add(this.txtOfferAmount);
         this.groupBox2.Controls.Add(this.label6);
         this.groupBox2.Controls.Add(this.cbCurrency);
         this.groupBox2.Location = new System.Drawing.Point(15, 585);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Size = new System.Drawing.Size(820, 100);
         this.groupBox2.TabIndex = 7;
         this.groupBox2.TabStop = false;
         this.groupBox2.Text = "groupBox2";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(6, 16);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(49, 13);
         this.label6.TabIndex = 34;
         this.label6.Text = "Currency";
         // 
         // cbCurrency
         // 
         this.cbCurrency.FormattingEnabled = true;
         this.cbCurrency.Location = new System.Drawing.Point(9, 35);
         this.cbCurrency.Name = "cbCurrency";
         this.cbCurrency.Size = new System.Drawing.Size(121, 21);
         this.cbCurrency.TabIndex = 33;
         // 
         // txtOfferAmount
         // 
         this.txtOfferAmount.Location = new System.Drawing.Point(136, 36);
         this.txtOfferAmount.Name = "txtOfferAmount";
         this.txtOfferAmount.Size = new System.Drawing.Size(100, 20);
         this.txtOfferAmount.TabIndex = 33;
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(135, 16);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(46, 13);
         this.label7.TabIndex = 35;
         this.label7.Text = "Amount:";
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Location = new System.Drawing.Point(242, 15);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(30, 13);
         this.label8.TabIndex = 37;
         this.label8.Text = "Rate";
         // 
         // txtRate
         // 
         this.txtRate.Location = new System.Drawing.Point(243, 35);
         this.txtRate.Name = "txtRate";
         this.txtRate.Size = new System.Drawing.Size(100, 20);
         this.txtRate.TabIndex = 36;
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.Location = new System.Drawing.Point(348, 15);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(34, 13);
         this.label9.TabIndex = 39;
         this.label9.Text = "Days:";
         // 
         // txtDays
         // 
         this.txtDays.Location = new System.Drawing.Point(349, 35);
         this.txtDays.Name = "txtDays";
         this.txtDays.Size = new System.Drawing.Size(100, 20);
         this.txtDays.TabIndex = 38;
         // 
         // label10
         // 
         this.label10.AutoSize = true;
         this.label10.Location = new System.Drawing.Point(449, 15);
         this.label10.Name = "label10";
         this.label10.Size = new System.Drawing.Size(49, 13);
         this.label10.TabIndex = 41;
         this.label10.Text = "Direction";
         // 
         // cbDirection
         // 
         this.cbDirection.FormattingEnabled = true;
         this.cbDirection.Location = new System.Drawing.Point(452, 34);
         this.cbDirection.Name = "cbDirection";
         this.cbDirection.Size = new System.Drawing.Size(121, 21);
         this.cbDirection.TabIndex = 40;
         // 
         // btnSendNewOffer
         // 
         this.btnSendNewOffer.Location = new System.Drawing.Point(579, 32);
         this.btnSendNewOffer.Name = "btnSendNewOffer";
         this.btnSendNewOffer.Size = new System.Drawing.Size(99, 23);
         this.btnSendNewOffer.TabIndex = 33;
         this.btnSendNewOffer.Text = "Send New Offer";
         this.btnSendNewOffer.UseVisualStyleBackColor = true;
         this.btnSendNewOffer.Click += new System.EventHandler(this.btnSendNewOffer_Click);
         // 
         // btnCancelOffer
         // 
         this.btnCancelOffer.Location = new System.Drawing.Point(134, 45);
         this.btnCancelOffer.Name = "btnCancelOffer";
         this.btnCancelOffer.Size = new System.Drawing.Size(99, 23);
         this.btnCancelOffer.TabIndex = 33;
         this.btnCancelOffer.Text = "Cancel Offer";
         this.btnCancelOffer.UseVisualStyleBackColor = true;
         this.btnCancelOffer.Click += new System.EventHandler(this.btnCancelOffer_Click);
         // 
         // btnGetOfferStatus
         // 
         this.btnGetOfferStatus.Location = new System.Drawing.Point(134, 16);
         this.btnGetOfferStatus.Name = "btnGetOfferStatus";
         this.btnGetOfferStatus.Size = new System.Drawing.Size(99, 23);
         this.btnGetOfferStatus.TabIndex = 34;
         this.btnGetOfferStatus.Text = "GetOfferStatus";
         this.btnGetOfferStatus.UseVisualStyleBackColor = true;
         this.btnGetOfferStatus.Click += new System.EventHandler(this.btnGetOfferStatus_Click);
         // 
         // btnGetActiveOffers
         // 
         this.btnGetActiveOffers.Location = new System.Drawing.Point(9, 62);
         this.btnGetActiveOffers.Name = "btnGetActiveOffers";
         this.btnGetActiveOffers.Size = new System.Drawing.Size(99, 23);
         this.btnGetActiveOffers.TabIndex = 42;
         this.btnGetActiveOffers.Text = "Get Active Offers";
         this.btnGetActiveOffers.UseVisualStyleBackColor = true;
         this.btnGetActiveOffers.Click += new System.EventHandler(this.btnGetActiveOffers_Click);
         // 
         // btnGetActiveCredits
         // 
         this.btnGetActiveCredits.Location = new System.Drawing.Point(114, 62);
         this.btnGetActiveCredits.Name = "btnGetActiveCredits";
         this.btnGetActiveCredits.Size = new System.Drawing.Size(140, 23);
         this.btnGetActiveCredits.TabIndex = 43;
         this.btnGetActiveCredits.Text = "Get Active Credits";
         this.btnGetActiveCredits.UseVisualStyleBackColor = true;
         this.btnGetActiveCredits.Click += new System.EventHandler(this.btnGetActiveCredits_Click);
         // 
         // btnGetActiveSwapsInMarginPos
         // 
         this.btnGetActiveSwapsInMarginPos.Location = new System.Drawing.Point(263, 61);
         this.btnGetActiveSwapsInMarginPos.Name = "btnGetActiveSwapsInMarginPos";
         this.btnGetActiveSwapsInMarginPos.Size = new System.Drawing.Size(186, 23);
         this.btnGetActiveSwapsInMarginPos.TabIndex = 44;
         this.btnGetActiveSwapsInMarginPos.Text = "Get Active Swaps In Margin Pos";
         this.btnGetActiveSwapsInMarginPos.UseVisualStyleBackColor = true;
         this.btnGetActiveSwapsInMarginPos.Click += new System.EventHandler(this.btnGetActiveSwapsInMarginPos_Click);
         // 
         // btnCloseSwap
         // 
         this.btnCloseSwap.Location = new System.Drawing.Point(236, 45);
         this.btnCloseSwap.Name = "btnCloseSwap";
         this.btnCloseSwap.Size = new System.Drawing.Size(99, 23);
         this.btnCloseSwap.TabIndex = 35;
         this.btnCloseSwap.Text = "Close Swap";
         this.btnCloseSwap.UseVisualStyleBackColor = true;
         this.btnCloseSwap.Click += new System.EventHandler(this.btnCloseSwap_Click);
         // 
         // btnClaimPosition
         // 
         this.btnClaimPosition.Location = new System.Drawing.Point(341, 45);
         this.btnClaimPosition.Name = "btnClaimPosition";
         this.btnClaimPosition.Size = new System.Drawing.Size(99, 23);
         this.btnClaimPosition.TabIndex = 36;
         this.btnClaimPosition.Text = "Claim Position";
         this.btnClaimPosition.UseVisualStyleBackColor = true;
         this.btnClaimPosition.Click += new System.EventHandler(this.btnClaimPosition_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(853, 898);
         this.Controls.Add(this.groupBox2);
         this.Controls.Add(this.lbLogger);
         this.Controls.Add(this.gbExchange1);
         this.Controls.Add(this.groupBox1);
         this.Name = "Form1";
         this.Text = "Form1";
         this.Load += new System.EventHandler(this.Form1_Load);
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.gbExchange1.ResumeLayout(false);
         this.groupBox2.ResumeLayout(false);
         this.groupBox2.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button btnStart;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.GroupBox gbExchange1;
      internal System.Windows.Forms.Panel pnlExchange1MarketData;
      internal System.Windows.Forms.Panel pnlExchange1Trading;
      private System.Windows.Forms.ListBox lbLogger;
      private System.Windows.Forms.TextBox txtOrderId;
      private System.Windows.Forms.Button btnGetOrderStatus;
      private System.Windows.Forms.Button btnCancelOrder;
      private System.Windows.Forms.Button btnCancelAll;
      private System.Windows.Forms.TextBox txtCancelMultiple;
      private System.Windows.Forms.Button btnCancelMultiple;
      private System.Windows.Forms.ListBox lbGenericData;
      private System.Windows.Forms.Button btnGetDataFromCallType;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button btnGetSymbols;
      private System.Windows.Forms.Button btnGetLends;
      private System.Windows.Forms.Button btnGetLendbook;
      private System.Windows.Forms.Button btnGetActivePos;
      private System.Windows.Forms.Button btnGetActiveOrders;
      private System.Windows.Forms.Button btnGetHistory;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Button btnGetMyTrades;
      public System.Windows.Forms.ComboBox cbCallTypes;
      public System.Windows.Forms.ComboBox cbPair;
      public System.Windows.Forms.ComboBox cbWalletType;
      public System.Windows.Forms.ComboBox cbSymbols;
      private System.Windows.Forms.Label label5;
      public System.Windows.Forms.ComboBox cbDepositTo;
      private System.Windows.Forms.Button btnDeposit;
      private System.Windows.Forms.Button btnAccountInfo;
      private System.Windows.Forms.Button btnMarginInfo;
      private System.Windows.Forms.GroupBox groupBox2;
      private System.Windows.Forms.Button btnSendNewOffer;
      private System.Windows.Forms.Label label10;
      public System.Windows.Forms.ComboBox cbDirection;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.TextBox txtDays;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.TextBox txtRate;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.TextBox txtOfferAmount;
      private System.Windows.Forms.Label label6;
      public System.Windows.Forms.ComboBox cbCurrency;
      private System.Windows.Forms.Button btnGetOfferStatus;
      private System.Windows.Forms.Button btnCancelOffer;
      private System.Windows.Forms.Button btnGetActiveCredits;
      private System.Windows.Forms.Button btnGetActiveOffers;
      private System.Windows.Forms.Button btnGetActiveSwapsInMarginPos;
      private System.Windows.Forms.Button btnCloseSwap;
      private System.Windows.Forms.Button btnClaimPosition;
   }
}

