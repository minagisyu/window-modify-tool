namespace WindowsFormsApplication1
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナ変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナで生成されたコード

		/// <summary>
		/// デザイナ サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディタで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.r_refresh = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.r_layeredwindow = new System.Windows.Forms.ToolStripMenuItem();
			this.r_opacity = new System.Windows.Forms.ToolStripMenuItem();
			this.r_opacity_100 = new System.Windows.Forms.ToolStripMenuItem();
			this.r_opacity_90 = new System.Windows.Forms.ToolStripMenuItem();
			this.r_opacity_80 = new System.Windows.Forms.ToolStripMenuItem();
			this.r_opacity_70 = new System.Windows.Forms.ToolStripMenuItem();
			this.r_opacity_60 = new System.Windows.Forms.ToolStripMenuItem();
			this.r_opacity_50 = new System.Windows.Forms.ToolStripMenuItem();
			this.r_opacity_40 = new System.Windows.Forms.ToolStripMenuItem();
			this.r_opacity_30 = new System.Windows.Forms.ToolStripMenuItem();
			this.r_opacity_20 = new System.Windows.Forms.ToolStripMenuItem();
			this.r_opacity_10 = new System.Windows.Forms.ToolStripMenuItem();
			this.r_opacity_0 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.r_topmost = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
			this.r_transparent = new System.Windows.Forms.ToolStripMenuItem();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
			this.listView1.ContextMenuStrip = this.contextMenuStrip1;
			this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView1.FullRowSelect = true;
			this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listView1.Location = new System.Drawing.Point(0, 0);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.ShowGroups = false;
			this.listView1.Size = new System.Drawing.Size(622, 194);
			this.listView1.SmallImageList = this.imageList1;
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "ウィンドウ名";
			this.columnHeader1.Width = 297;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "ファイル名";
			this.columnHeader2.Width = 301;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.r_refresh,
            this.toolStripMenuItem2,
            this.r_layeredwindow,
            this.r_opacity,
            this.toolStripMenuItem3,
            this.r_topmost,
            this.toolStripMenuItem4,
            this.r_transparent});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(176, 132);
			this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
			// 
			// r_refresh
			// 
			this.r_refresh.Name = "r_refresh";
			this.r_refresh.Size = new System.Drawing.Size(175, 22);
			this.r_refresh.Text = "ウィンドウ一覧の更新";
			this.r_refresh.Click += new System.EventHandler(this.r_refresh_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(172, 6);
			// 
			// r_layeredwindow
			// 
			this.r_layeredwindow.Name = "r_layeredwindow";
			this.r_layeredwindow.Size = new System.Drawing.Size(175, 22);
			this.r_layeredwindow.Text = "レイヤードウィンドウ";
			this.r_layeredwindow.Click += new System.EventHandler(this.r_layeredwindow_Click);
			// 
			// r_opacity
			// 
			this.r_opacity.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.r_opacity_100,
            this.r_opacity_90,
            this.r_opacity_80,
            this.r_opacity_70,
            this.r_opacity_60,
            this.r_opacity_50,
            this.r_opacity_40,
            this.r_opacity_30,
            this.r_opacity_20,
            this.r_opacity_10,
            this.r_opacity_0});
			this.r_opacity.Name = "r_opacity";
			this.r_opacity.Size = new System.Drawing.Size(175, 22);
			this.r_opacity.Text = "透明度";
			// 
			// r_opacity_100
			// 
			this.r_opacity_100.Name = "r_opacity_100";
			this.r_opacity_100.Size = new System.Drawing.Size(152, 22);
			this.r_opacity_100.Text = "100%";
			this.r_opacity_100.Click += new System.EventHandler(this.r_opacity_100_Click);
			// 
			// r_opacity_90
			// 
			this.r_opacity_90.Name = "r_opacity_90";
			this.r_opacity_90.Size = new System.Drawing.Size(152, 22);
			this.r_opacity_90.Text = "90%";
			this.r_opacity_90.Click += new System.EventHandler(this.r_opacity_90_Click);
			// 
			// r_opacity_80
			// 
			this.r_opacity_80.Name = "r_opacity_80";
			this.r_opacity_80.Size = new System.Drawing.Size(152, 22);
			this.r_opacity_80.Text = "80%";
			this.r_opacity_80.Click += new System.EventHandler(this.r_opacity_80_Click);
			// 
			// r_opacity_70
			// 
			this.r_opacity_70.Name = "r_opacity_70";
			this.r_opacity_70.Size = new System.Drawing.Size(152, 22);
			this.r_opacity_70.Text = "70%";
			this.r_opacity_70.Click += new System.EventHandler(this.r_opacity_70_Click);
			// 
			// r_opacity_60
			// 
			this.r_opacity_60.Name = "r_opacity_60";
			this.r_opacity_60.Size = new System.Drawing.Size(152, 22);
			this.r_opacity_60.Text = "60%";
			this.r_opacity_60.Click += new System.EventHandler(this.r_opacity_60_Click);
			// 
			// r_opacity_50
			// 
			this.r_opacity_50.Name = "r_opacity_50";
			this.r_opacity_50.Size = new System.Drawing.Size(152, 22);
			this.r_opacity_50.Text = "50%";
			this.r_opacity_50.Click += new System.EventHandler(this.r_opacity_50_Click);
			// 
			// r_opacity_40
			// 
			this.r_opacity_40.Name = "r_opacity_40";
			this.r_opacity_40.Size = new System.Drawing.Size(152, 22);
			this.r_opacity_40.Text = "40%";
			this.r_opacity_40.Click += new System.EventHandler(this.r_opacity_40_Click);
			// 
			// r_opacity_30
			// 
			this.r_opacity_30.Name = "r_opacity_30";
			this.r_opacity_30.Size = new System.Drawing.Size(152, 22);
			this.r_opacity_30.Text = "30%";
			this.r_opacity_30.Click += new System.EventHandler(this.r_opacity_30_Click);
			// 
			// r_opacity_20
			// 
			this.r_opacity_20.Name = "r_opacity_20";
			this.r_opacity_20.Size = new System.Drawing.Size(152, 22);
			this.r_opacity_20.Text = "20%";
			this.r_opacity_20.Click += new System.EventHandler(this.r_opacity_20_Click);
			// 
			// r_opacity_10
			// 
			this.r_opacity_10.Name = "r_opacity_10";
			this.r_opacity_10.Size = new System.Drawing.Size(152, 22);
			this.r_opacity_10.Text = "10%";
			this.r_opacity_10.Click += new System.EventHandler(this.r_opacity_10_Click);
			// 
			// r_opacity_0
			// 
			this.r_opacity_0.Name = "r_opacity_0";
			this.r_opacity_0.Size = new System.Drawing.Size(152, 22);
			this.r_opacity_0.Text = "0%";
			this.r_opacity_0.Click += new System.EventHandler(this.r_opacity_0_Click);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(172, 6);
			// 
			// r_topmost
			// 
			this.r_topmost.Name = "r_topmost";
			this.r_topmost.Size = new System.Drawing.Size(175, 22);
			this.r_topmost.Text = "最前面ウィンドウ";
			this.r_topmost.Click += new System.EventHandler(this.r_topmost_Click);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(172, 6);
			// 
			// r_transparent
			// 
			this.r_transparent.Name = "r_transparent";
			this.r_transparent.Size = new System.Drawing.Size(175, 22);
			this.r_transparent.Text = "透過ウィンドウ";
			this.r_transparent.Click += new System.EventHandler(this.r_transparent_Click);
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(622, 194);
			this.Controls.Add(this.listView1);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "ウィンドウいじくるツール";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem r_layeredwindow;
		private System.Windows.Forms.ToolStripMenuItem r_transparent;
		private System.Windows.Forms.ToolStripMenuItem r_topmost;
		private System.Windows.Forms.ToolStripMenuItem r_opacity;
		private System.Windows.Forms.ToolStripMenuItem r_opacity_100;
		private System.Windows.Forms.ToolStripMenuItem r_opacity_90;
		private System.Windows.Forms.ToolStripMenuItem r_opacity_80;
		private System.Windows.Forms.ToolStripMenuItem r_opacity_70;
		private System.Windows.Forms.ToolStripMenuItem r_opacity_60;
		private System.Windows.Forms.ToolStripMenuItem r_opacity_50;
		private System.Windows.Forms.ToolStripMenuItem r_opacity_40;
		private System.Windows.Forms.ToolStripMenuItem r_opacity_30;
		private System.Windows.Forms.ToolStripMenuItem r_opacity_20;
		private System.Windows.Forms.ToolStripMenuItem r_opacity_10;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem r_refresh;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem r_opacity_0;
	}
}

