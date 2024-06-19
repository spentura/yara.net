using System;
using System.Runtime.InteropServices;


namespace YaraNet.Interop
{
    [StructLayout(LayoutKind.Sequential)]
    public struct YR_RELOC
    {

        /// uint32_t->unsigned int
        public uint offset;

        /// _YR_RELOC*
        public IntPtr next;
    }

}
