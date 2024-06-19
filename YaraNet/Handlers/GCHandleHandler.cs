using System.Runtime.InteropServices;

namespace YaraNet.Handlers
{
    /// <summary>
    /// RAII wrapper for GCHandle.
    /// </summary>
    public class GCHandleHandler 
        : IDisposable
    {
        public GCHandle Handle { get; }

        public GCHandleHandler(object value)
        {
            Handle = GCHandle.Alloc(value);
        }

        public GCHandleHandler(
            object value, 
            GCHandleType handleType)
        {
            Handle = GCHandle.Alloc(value, handleType);
        }

        public void Dispose()
        {
            if (Handle != null)
                Handle.Free();
        }

        public IntPtr GetPointer()
        {
            return GCHandle.ToIntPtr(Handle);
        }
    }
}