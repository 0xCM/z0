//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using static zfunc;

    /// <summary>
    /// Reads native data for a jitted method
    /// </summary>
    public static class MethodReader
    {
        public static MethodData ReadMethod(MethodInfo m)
            => ReadMethod(m, new byte[128]);
        
        public static MethodData ReadMethod<T>(string method)
            => ReadMethod(method<T>(method),new byte[128]);

        public static MethodData ReadMethod<N,T>(string name, Span<byte> dst)
            where N : unmanaged, ITypeNat
                => ReadMethod(method<T>(name), dst);

        public static unsafe MethodData ReadMethod(MethodInfo m, Span<byte> dst)
        {            
            var pSrc = (byte*)m.Prepare().ToPointer();            
            var pSrcCurrent = pSrc;            
            var endAddress = Capture(pSrc, dst);            
            var startAddress = (ulong)pSrc;
            var bytesRead = (int)(endAddress - startAddress);
            return new MethodData(m, startAddress, endAddress, dst.Slice(0, bytesRead).ToArray());         
        }

        // Determined by inspection to detect the end of a method; seems to work
        static ReadOnlySpan<byte> Footer
            => new byte[8]{0x19, 0x0, 0x0, 0x0, 0x40, 0x0, 0x0, 0x0};

        static unsafe ulong Capture(byte* pSrc, Span<byte> dst)
        {
            var maxcount = dst.Length;
            var offset = 0;
            var pSrcCurrent = pSrc;    
            var footer = Footer.TakeUInt64();        
            while(offset < maxcount)
            {
                Read(pSrcCurrent++, ref dst[offset++]);

                if(offset >= 9)
                {
                    var i = (offset - 1) - 8;
                    if(dst.Slice(i,8).TakeUInt64() == footer)
                        return ((ulong)pSrcCurrent) - 9;                        
                }                    
            }
            return (ulong)pSrcCurrent;
        }

        [MethodImpl(Inline)]
        static unsafe ref byte Read(byte* pByte, ref byte dst)
        {
            dst = Unsafe.Read<byte>(pByte);
            return ref dst;
        }
    }

}