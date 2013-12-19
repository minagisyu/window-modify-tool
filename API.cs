using System;
using System.Runtime.InteropServices;

// 「warning CS0649: フィールド 'xxx' は割り当てられません。常に既定値 を使用します。」の抑制。
#pragma warning disable 649

using HDC = System.IntPtr;
using HHOOK = System.IntPtr;
using HWND = System.IntPtr;
using WPARAM = System.IntPtr;
using LPARAM = System.IntPtr;
using System.Text;

class API
{
	const string User32 = "user32.dll";

	public static readonly HWND HWND_TOP = (IntPtr)0;
	public static readonly HWND HWND_BOTTOM = (IntPtr)1;
	public static readonly HWND HWND_TOPMOST = (IntPtr)(-1);
	public static readonly HWND HWND_NOTOPMOST = (IntPtr)(-2);

	[DllImport(User32, CharSet = CharSet.Auto)]
	public static extern bool EnumWindows(WNDENUMPROC lpEnumFunc, LPARAM lParam);

	public delegate bool WNDENUMPROC(HWND hWnd, LPARAM lParam);

	[DllImport(User32, CharSet = CharSet.Auto)]
	public static extern bool IsWindow(HWND hWnd);

	[DllImport(User32, CharSet = CharSet.Auto)]
	public static extern bool IsWindowVisible(HWND hWnd);

	[DllImport(User32, CharSet = CharSet.Auto)]
	public static extern HWND GetParent(HWND hWnd);

	[DllImport(User32, CharSet = CharSet.Auto)]
	public static extern int GetWindowText(HWND hWnd, StringBuilder lpString, int nMaxCount);

	[DllImport(User32, CharSet = CharSet.Auto)]
	public static extern int GetWindowThreadProcessId(HWND hWnd, out int lpdwProcessId);

	[DllImport(User32, CharSet = CharSet.Auto)]
	public static extern IntPtr GetWindowLong(HWND hWnd, GWL nIndex);

	[DllImport(User32, CharSet = CharSet.Auto)]
	public static extern IntPtr SetWindowLong(HWND hWnd, GWL nIndex, IntPtr dwNewLong);

	[DllImport(User32, CharSet = CharSet.Auto)]
	public static extern IntPtr SendMessage(HWND hWnd, int msg, IntPtr wParam, IntPtr lParam);

	[DllImport(User32, CharSet = CharSet.Auto)]
	public static extern int GetClassLong(HWND hWnd, GCW nIndex);
	[DllImport(User32, CharSet = CharSet.Auto)]
	public static extern int GetClassLong(HWND hWnd, GCL nIndex);

	[DllImport(User32, CharSet = CharSet.Auto)]
	public static extern bool SetForegroundWindow(HWND hWnd);

	[DllImport(User32, CharSet = CharSet.Auto)]
	public static extern bool SetLayeredWindowAttributes(HWND hwnd, int crKey, byte bAlpha, LWA dwFlags);

	[DllImport(User32, CharSet = CharSet.Auto)]
	public static extern bool SetWindowPos(HWND hWnd, HWND hWndInsertAfter, int x, int y, int cx, int cy, SWP flags);

	[Flags]
	public enum SWP : int
	{
		NOSIZE = 0x0001,
		NOMOVE = 0x0002,
		NOZORDER = 0x0004,
		NOREDRAW = 0x0008,
		NOACTIVATE = 0x0010,
		FRAMECHANGED = 0x0020, // The frame changed: send WM_NCCALCSIZE
		SHOWWINDOW = 0x0040,
		HIDEWINDOW = 0x0080,
		NOCOPYBITS = 0x0100,
		NOOWNERZORDER = 0x0200, // Don't do owner Z ordering
		NOSENDCHANGING = 0x0400, // Don't send WM_WINDOWPOSCHANGING

		DRAWFRAME = SWP.FRAMECHANGED,
		NOREPOSITION = SWP.NOOWNERZORDER,

		DEFERERASE = 0x2000,
		ASYNCWINDOWPOS = 0x4000,
	}

	[Flags]
	public enum LWA : int
	{
		COLORKEY = 0x00000001,
		ALPHA = 0x00000002,
	}

	public enum GCL : int
	{
		MENUNAME = (-8),
		HBRBACKGROUND = (-10),
		HCURSOR = (-12),
		HICON = (-14),
		HMODULE = (-16),
		CBWNDEXTRA = (-18),
		CBCLSEXTRA = (-20),
		WNDPROC = (-24),
		STYLE = (-26),
		HICONSM = (-34),
	}

	public enum GCW : int
	{
		ATOM = (-32),
	}

	public enum GWL : int
	{
		WNDPROC = (-4),
		HINSTANCE = (-6),
		HWNDPARENT = (-8),
		STYLE = (-16),
		EXSTYLE = (-20),
		USERDATA = (-21),
		ID = (-12),
	}

	[Flags]
	public enum WS : int
	{
		OVERLAPPED = 0x00000000,
		POPUP = unchecked((int)0x80000000),
		CHILD = 0x40000000,
		MINIMIZE = 0x20000000,
		VISIBLE = 0x10000000,
		DISABLED = 0x08000000,
		CLIPSIBLINGS = 0x04000000,
		CLIPCHILDREN = 0x02000000,
		MAXIMIZE = 0x01000000,
		CAPTION = WS.BORDER | WS.DLGFRAME,
		BORDER = 0x00800000,
		DLGFRAME = 0x00400000,
		VSCROLL = 0x00200000,
		HSCROLL = 0x00100000,
		SYSMENU = 0x00080000,
		THICKFRAME = 0x00040000,
		GROUP = 0x00020000,
		TABSTOP = 0x00010000,
		MINIMIZEBOX = 0x00020000,
		MAXIMIZEBOX = 0x00010000,
		TILED = WS.OVERLAPPED,
		ICONIC = WS.MINIMIZE,
		SIZEBOX = WS.THICKFRAME,
		TILEDWINDOW = WS.OVERLAPPEDWINDOW,
		OVERLAPPEDWINDOW = (WS.OVERLAPPED | WS.CAPTION | WS.SYSMENU | WS.THICKFRAME | WS.MINIMIZEBOX | WS.MAXIMIZEBOX),
		POPUPWINDOW = (WS.POPUP | WS.BORDER | WS.SYSMENU),
		CHILDWINDOW = WS.CHILD,
	}

	[Flags]
	public enum WS_EX : int
	{
		DLGMODALFRAME = 0x00000001,
		NOPARENTNOTIFY = 0x00000004,
		TOPMOST = 0x00000008,
		ACCEPTFILES = 0x00000010,
		TRANSPARENT = 0x00000020,
		MDICHILD = 0x00000040,
		TOOLWINDOW = 0x00000080,
		WINDOWEDGE = 0x00000100,
		CLIENTEDGE = 0x00000200,
		CONTEXTHELP = 0x00000400,
		RIGHT = 0x00001000,
		LEFT = 0x00000000,
		RTLREADING = 0x00002000,
		LTRREADING = 0x00000000,
		LEFTSCROLLBAR = 0x00004000,
		RIGHTSCROLLBAR = 0x00000000,
		CONTROLPARENT = 0x00010000,
		STATICEDGE = 0x00020000,
		APPWINDOW = 0x00040000,
		OVERLAPPEDWINDOW = (WS_EX.WINDOWEDGE | WS_EX.CLIENTEDGE),
		PALETTEWINDOW = (WS_EX.WINDOWEDGE | WS_EX.TOOLWINDOW | WS_EX.TOPMOST),
		LAYERED = 0x00080000,
		NOINHERITLAYOUT = 0x00100000,
		LAYOUTRTL = 0x00400000,
		COMPOSITED = 0x02000000,
		NOACTIVATE = 0x08000000,
	}

	[Flags]
	public enum WM : int
	{
		CREATE = 0x0001,
		DESTROY = 0x0002,
		MOVE = 0x0003,

		SIZE = 0x0005,

		PAINT = 0x000F,
		CLOSE = 0x0010,

		QUIT = 0x0012,

		ERASEBKGND = 0x0014,

		GETMINMAXINFO = 0x0024,

		NOTIFY = 0x004E,

		GETICON = 0x007F,

		NCHITTEST = 0x0084,

		NCMOUSEMOVE = 0x00A0,
		NCLBUTTONDOWN = 0x00A1,
		NCLBUTTONUP = 0x00A2,
		NCLBUTTONDBLCLK = 0x00A3,
		NCRBUTTONDOWN = 0x00A4,
		NCRBUTTONUP = 0x00A5,
		NCRBUTTONDBLCLK = 0x00A6,
		NCMBUTTONDOWN = 0x00A7,
		NCMBUTTONUP = 0x00A8,
		NCMBUTTONDBLCLK = 0x00A9,

		KEYDOWN = 0x0100,
		KEYUP = 0x0101,
		CHAR = 0x0102,
		DEADCHAR = 0x0103,
		SYSKEYDOWN = 0x0104,
		SYSKEYUP = 0x0105,
		SYSCHAR = 0x0106,
		SYSDEADCHAR = 0x0107,

		UNICHAR = 0x0109,

		COMMAND = 0x0111,
		SYSCOMMAND = 0x0112,

		MOUSEFIRST = 0x0200,
		MOUSEMOVE = 0x0200,
		LBUTTONDOWN = 0x0201,
		LBUTTONUP = 0x0202,
		LBUTTONDBLCLK = 0x0203,
		RBUTTONDOWN = 0x204,
		RBUTTONUP = 0x205,
		RBUTTONDBLCLK = 0x206,
		MBUTTONDOWN = 0x0207,
		MBUTTONUP = 0x0208,
		MBUTTONDBLCLK = 0x0209,
		MOUSEWHEEL = 0x20A,
		XBUTTONDOWN = 0x020B,
		XBUTTONUP = 0x020C,
		XBUTTONDBLCLK = 0x020D,
		MOUSEHWHEEL = 0x020E,

		SIZING = 0x0214,
		MOVING = 0x0216,

		ENTERSIZEMOVE = 0x0231,
		EXITSIZEMOVE = 0x0232,

		APP = 0x8000,
	}

}
