using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinBro.Core.Util
{
    // Make Singleton
    public class HotKey
    {
        #region API
        public delegate void HotKeyHandler();

        public static void InvokeHandler(IntPtr hotkey_id)
        {
            var hotkey =_registeredHotKeys.SingleOrDefault(h => h.Id == (int) hotkey_id);
            if (hotkey == null)
            {
                throw new Exception("Fail to run hotkey handler");
            }

            hotkey.Handler();
        }
        public static void Register(System.Windows.Forms.Form form, Keys[] modifiers, Keys key, HotKeyHandler handler)
        {
            uint modifier = 0x0000;
            foreach (var m in modifiers)
            {
                modifier |= _virtualKeyCodes[m];
            }

            if (!RegisterHotKey(form.Handle, _id, modifier, _virtualKeyCodes[key]))
            {
                var error_code = GetLastError();
                if (error_code != 0 && error_code != 1409)
                {
                    throw new Exception("Hotkey registration failed. Error code: " + error_code);
                }
            }

            _registeredHotKeys.Add(new RegisteredHotKey
            {
                Id = _id,
                Handle = form.Handle,
                Handler = handler
            });

            _id++;
        }
        public static void UnregisterAll()
        {
            foreach (var hotkey in _registeredHotKeys)
            {
                if (!UnregisterHotKey(hotkey.Handle, hotkey.Id))
                {
                    var error_code = GetLastError();
                    if (error_code != 0)
                    {
                        throw new Exception("Hotkey unregistration failed");
                    }
                }
            }
        }

        #endregion
        #region Background

        private static int _id = 0;
        private static List<RegisteredHotKey> _registeredHotKeys = new List<RegisteredHotKey>();
        private static Dictionary<Keys, uint> _virtualKeyCodes = new Dictionary<System.Windows.Forms.Keys, uint>
        {
            { Keys.Shift, 0x0004 },
            { Keys.Control, 0x0002 },
            { Keys.Alt, 0x0001 },
            { Keys.Space, 0x20 },
            { Keys.A, 0x41 },
            { Keys.B, 0x42 },
            { Keys.C, 0x43 },
            { Keys.D, 0x44 },
            { Keys.E, 0x45 },
            { Keys.F, 0x46 },
            { Keys.G, 0x47 },
            { Keys.H, 0x48 },
            { Keys.I, 0x49 },
            { Keys.J, 0x4a },
            { Keys.K, 0x4b },
            { Keys.L, 0x4c },
            { Keys.M, 0x4d },
            { Keys.N, 0x4e },
            { Keys.O, 0x4f },
            { Keys.P, 0x50 },
            { Keys.Q, 0x51 },
            { Keys.R, 0x52 },
            { Keys.S, 0x53 },
            { Keys.T, 0x54 },
            { Keys.U, 0x55 },
            { Keys.V, 0x56 },
            { Keys.W, 0x57 },
            { Keys.X, 0x58 },
            { Keys.Y, 0x59 },
            { Keys.Z, 0x5a }
        };

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vlc);
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        [DllImport("kernel32.dll")]
        public static extern uint GetLastError();
        #endregion
    }
}
