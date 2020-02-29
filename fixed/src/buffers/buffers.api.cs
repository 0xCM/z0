//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Security;
    using System.Runtime.CompilerServices;

    using static Root;

    [SuppressUnmanagedCodeSecurity]
    public static unsafe class buffers
    {
        /// <summary>
        /// Allocates an execution buffer
        /// </summary>
        /// <param name="length">The buffer length in bytes</param>
        [MethodImpl(Inline)]
        public static ExecBuffer alloc(int length)
            => ExecBuffer.Own((liberate(Marshal.AllocHGlobal(length), length), length));        

        [MethodImpl(Inline)]
        public static ExecBufferSpan spanalloc(int length)
        {
            var handle = liberate(Marshal.AllocHGlobal(length), length);            
            var content = new Span<byte>(handle.ToPointer(), length);
            content.Clear();
            return ExecBufferSpan.Own(handle,content);
        }

        /// <summary>
        /// Deallocates a native allocation
        /// </summary>
        /// <param name="handle">The allocation handle</param>
        [MethodImpl(Inline)]
        public static void release(IntPtr handle)
            => Marshal.FreeHGlobal(handle);

        /// <summary>
        /// Enables an executable memory segment
        /// </summary>
        /// <param name="src">The leading cell pointer</param>
        /// <param name="length">The length of the segment, in bytes</param>
        [MethodImpl(Inline)]
        static IntPtr liberate(IntPtr src, int length)
        {
            if (!VirtualProtectEx(CurrentProcess.Handle, src, (UIntPtr)(ulong)length, 0x40, out uint _))
                ThrowLiberationError(src, length);
            return src;
        }

        /// <summary>
        /// Enables en executable memory segment
        /// </summary>
        /// <param name="src">The leading cell reference</param>
        /// <param name="length">The length of the segment, in bytes</param>
        /// <typeparam name="T"></typeparam>
        [MethodImpl(Inline)]
        static IntPtr Liberate<T>(ref T src, int length)
            where T : unmanaged
        {
            IntPtr buffer = (IntPtr)Unsafe.AsPointer(ref src);
            if (!VirtualProtectEx(CurrentProcess.Handle, buffer, (UIntPtr)length, 0x40, out uint _))
                ThrowLiberationError(buffer, length);
            return buffer;
        }

        [MethodImpl(Inline)]
        static IntPtr Liberate(ReadOnlySpan<byte> src)
            => Liberate(ref mutable(in head(src)), src.Length);

        [MethodImpl(Inline)]
        static IntPtr Liberate(Span<byte> src)
            => Liberate(ref head(src), src.Length);

        static void ThrowLiberationError(IntPtr pCode, ReadOnlySpan<byte> src)
        {
            var start = (ulong)pCode;
            var end = start + (ulong)src.Length;            
            throw new Exception($"An attempt to liberate {src.Length} bytes of memory for execution failed");     
        }

        static void ThrowLiberationError(IntPtr pCode, ByteSize Length)
        {
            var start = (ulong)pCode;
            var end = start + (ulong)Length;            
            throw new Exception($"An attempt to liberate {Length} bytes of memory for execution failed");     
        }

        /// <summary>
        /// Windows API that applies memory protection attributes
        /// </summary>
        [DllImport(Kernel32)]
        static extern bool VirtualProtectEx(IntPtr hProc, IntPtr pCode, UIntPtr codelen, uint flags, out uint oldFlags); 

        [MethodImpl(Inline)]
        static T* Liberate<T>(T* pBuffer, int length)
            where T : unmanaged
        {
            IntPtr buffer = (IntPtr)(void*)pBuffer;
            if (!VirtualProtectEx(CurrentProcess.Handle, buffer, (UIntPtr)length, 0x40, out uint _))
                ThrowLiberationError(buffer, length);
            return pBuffer;
        }             
    }
}