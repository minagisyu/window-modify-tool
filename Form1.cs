using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Text;

namespace WindowsFormsApplication1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		void RefreshWindowList()
		{
			listView1.Items.Clear();
			imageList1.Images.Clear();

			API.EnumWindows((hWnd, lParam) =>
			{
				// 絞り込み。タイトルがない・非表示・親があるものは省く。
				if(API.IsWindow(hWnd) == false) return true;
				if(API.IsWindowVisible(hWnd) == false) return true;
				if(API.GetParent(hWnd) != IntPtr.Zero) return true;
				var title = new StringBuilder(1024);
				if(API.GetWindowText(hWnd, title, title.Capacity) == 0) return true;
				var style = (API.WS)API.GetWindowLong(hWnd, API.GWL.STYLE);
				if((style & API.WS.CAPTION) == 0) return true;

				// モジュール名を取得してリストに追加
				int pid;
				API.GetWindowThreadProcessId(hWnd, out pid);
				var filename = Process.GetProcessById(pid).MainModule.FileName;

				// イメージリストにアイコン追加
				if(imageList1.Images.ContainsKey(filename) == false)
				{
					IntPtr hIcon;
					// XP以降: システム提供ウィンドウスモールアイコン
					if((hIcon = API.SendMessage(hWnd, (int)API.WM.GETICON, (IntPtr)2, IntPtr.Zero)) == IntPtr.Zero)
					{
						// ウィンドウ・スモールアイコン
						if((hIcon = API.SendMessage(hWnd, (int)API.WM.GETICON, (IntPtr)0, IntPtr.Zero)) == IntPtr.Zero)
						{
							// ウィンドウクラス・スモールアイコン
							if((hIcon = (IntPtr)API.GetClassLong(hWnd, API.GCL.HICONSM)) == IntPtr.Zero)
							{
								// ウィンドウ・アイコン
								if((hIcon = API.SendMessage(hWnd, (int)API.WM.GETICON, (IntPtr)1, IntPtr.Zero)) == IntPtr.Zero)
								{
									// ウィンドウクラス・アイコン
									if((hIcon = (IntPtr)API.GetClassLong(hWnd, API.GCL.HICON)) == IntPtr.Zero)
									{
										hIcon = IntPtr.Zero;
									}
								}
							}
						}
					}

					Icon icon = null;
					if(hIcon != IntPtr.Zero)
						icon = Icon.FromHandle(hIcon);
					if(icon == null)
						icon = Icon.ExtractAssociatedIcon(filename);

					// アイコンがあるときのみ。
					if(icon != null)
						imageList1.Images.Add(filename, icon);
				}

				var listItem = new ListViewItem(title.ToString());
				listItem.Tag = new WindowEntry() { WindowHandle = hWnd, ModulePath = filename, };
				listItem.ImageKey = filename;
				listItem.SubItems.Add(filename);
				listView1.Items.Add(listItem);
				return true;
			}, IntPtr.Zero);
		}


		void Form1_Load(object sender, EventArgs e)
		{
			RefreshWindowList();
		}

		void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if(listView1.SelectedItems.Count == 0)
			{
				r_layeredwindow.Enabled = false;
				r_opacity.Enabled = false;
				r_topmost.Enabled = false;
				r_transparent.Enabled = false;
				return;
			}

			r_layeredwindow.Enabled = true;
			r_opacity.Enabled = true;
			r_topmost.Enabled = true;
			r_transparent.Enabled = true;

			var entry = (WindowEntry)listView1.SelectedItems[0].Tag;
			var style = (API.WS_EX)API.GetWindowLong(entry.WindowHandle, API.GWL.EXSTYLE);

			r_layeredwindow.Checked = (style & API.WS_EX.LAYERED) == API.WS_EX.LAYERED;
			r_opacity.Enabled = r_layeredwindow.Checked;
			r_topmost.Checked = (style & API.WS_EX.TOPMOST) == API.WS_EX.TOPMOST;
			r_transparent.Checked = (style & API.WS_EX.TRANSPARENT) == API.WS_EX.TRANSPARENT;
		}

		private void r_refresh_Click(object sender, EventArgs e)
		{
			RefreshWindowList();
		}

		void ModifyStyle(API.WS_EX style, bool isRemove)
		{
			var entry = (WindowEntry)listView1.SelectedItems[0].Tag;
			var style0 = (API.WS_EX)API.GetWindowLong(entry.WindowHandle, API.GWL.EXSTYLE);

			if(isRemove)
			{
				// フラグを外す
				style0 &= ~style;
			}
			else
			{
				style0 |= style;
			}

			var swpStyle = IntPtr.Zero;
			if(style == API.WS_EX.TOPMOST)
			{
				swpStyle = (isRemove) ? API.HWND_NOTOPMOST : API.HWND_TOPMOST;
			}

			API.SetForegroundWindow(entry.WindowHandle);
			API.SetWindowLong(entry.WindowHandle, API.GWL.EXSTYLE, (IntPtr)style0);
			API.SetWindowPos(entry.WindowHandle, swpStyle, 0, 0, 0, 0,
				API.SWP.NOMOVE | API.SWP.NOSIZE | API.SWP.FRAMECHANGED);
		}

		void ModyfyOpacity(byte opacity)
		{
			var entry = (WindowEntry)listView1.SelectedItems[0].Tag;
			API.SetLayeredWindowAttributes(entry.WindowHandle, 0, (byte)((255 / 100.0) * opacity), API.LWA.ALPHA);
		}

		void r_layeredwindow_Click(object sender, EventArgs e)
		{
			ModifyStyle(API.WS_EX.LAYERED, r_layeredwindow.Checked);
		}

		void r_opacity_100_Click(object sender, EventArgs e)
		{
			ModyfyOpacity(100);
		}

		void r_opacity_90_Click(object sender, EventArgs e)
		{
			ModyfyOpacity(90);
		}

		void r_opacity_80_Click(object sender, EventArgs e)
		{
			ModyfyOpacity(80);
		}

		void r_opacity_70_Click(object sender, EventArgs e)
		{
			ModyfyOpacity(70);
		}

		void r_opacity_60_Click(object sender, EventArgs e)
		{
			ModyfyOpacity(60);
		}

		void r_opacity_50_Click(object sender, EventArgs e)
		{
			ModyfyOpacity(50);
		}

		void r_opacity_40_Click(object sender, EventArgs e)
		{
			ModyfyOpacity(40);
		}

		void r_opacity_30_Click(object sender, EventArgs e)
		{
			ModyfyOpacity(30);
		}

		void r_opacity_20_Click(object sender, EventArgs e)
		{
			ModyfyOpacity(20);
		}

		void r_opacity_10_Click(object sender, EventArgs e)
		{
			ModyfyOpacity(10);
		}

		void r_opacity_0_Click(object sender, EventArgs e)
		{
			ModyfyOpacity(0);
		}

		void r_topmost_Click(object sender, EventArgs e)
		{
			ModifyStyle(API.WS_EX.TOPMOST, r_topmost.Checked);
		}

		void r_transparent_Click(object sender, EventArgs e)
		{
			ModifyStyle(API.WS_EX.TRANSPARENT, r_transparent.Checked);
		}

	}

	class WindowEntry
	{
		public IntPtr WindowHandle;
		public string ModulePath;
	}


}
