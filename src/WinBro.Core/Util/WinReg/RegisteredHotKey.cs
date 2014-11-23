using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinBro.Core.Util
{
    class RegisteredHotKey
    {
        public int Id { get; set; }
        public IntPtr Handle { get; set; }
        public HotKey.HotKeyHandler Handler { get; set; }
    }
}
