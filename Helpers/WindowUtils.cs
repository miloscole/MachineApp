using System.Runtime.InteropServices;

namespace MachineApp.Helpers
{
    public static class WindowUtils
    {
        [DllImport("user32.DLL")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL")]
        private static extern void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

        public static void EnableDrag(IntPtr handle)
        {
            ReleaseCapture();
            SendMessage(handle, 0x112, 0xf012, 0);
        }
    }
}

