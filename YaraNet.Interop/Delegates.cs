using System;
using System.Runtime.InteropServices;

namespace YaraNet.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int YaraScanCallback(
        IntPtr context,
        int message,
        IntPtr message_data,
        IntPtr user_data);
}
