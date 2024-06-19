using System.Runtime.InteropServices;


namespace YaraNet.Interop
{
    [StructLayout(LayoutKind.Sequential)]
    public struct SETJMP_FLOAT128
    {
        /// unsigned __int64[2]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.U8)]
        public ulong[] Part;
    }

}
