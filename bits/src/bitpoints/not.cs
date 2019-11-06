//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using static zfunc;
    using static As;
    using static AsIn;

    unsafe partial class BitPoints
    {
        [MethodImpl(Inline)]
        public static void not<T>(in T rA, ref T rDst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               not(in uint8(in rA), ref uint8(ref rDst));
            else if(typeof(T) == typeof(ushort))
                gparts.not(n, in rA, ref rDst);
            else if(typeof(T) == typeof(uint))
                gparts.not(n, 4, 8, in rA, ref rDst);
            else if(typeof(T) == typeof(ulong))
                gparts.not(n, 16, 4, in rA, ref rDst);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static unsafe void not(in byte rA, ref byte rDst)
            => content(math.not(content(rA)), ref rDst);

        // [MethodImpl(Inline)]
        // public static unsafe void not<T>(in T rA, ref T rDst)
        //     where T : unmanaged
        // {
        //     if(typeof(T) == typeof(byte))
        //        not(in uint8(in rA), ref uint8(ref rDst));
        //     else if(typeof(T) == typeof(ushort))
        //        not(in uint16(in rA), ref uint16(ref rDst));
        //     else if(typeof(T) == typeof(uint))
        //        not(in uint32(in rA), ref uint32(ref rDst));
        //     else if(typeof(T) == typeof(ulong))
        //        not(in uint64(in rA), ref uint64(ref rDst));
        //     else
        //         throw unsupported<T>();
        // }

        // [MethodImpl(Inline)]
        // static unsafe void not(in byte rA, ref byte rDst)
        //     => content(math.not(content(in rA)), ref rDst);

        // [MethodImpl(Inline)]
        // static void not(in ushort rA, ref ushort rDst)
        //     => ginx.vnot(n, in rA, ref rDst);
        
        // [MethodImpl(Inline)]
        // static void not(in uint rA, ref uint rDst)
        // {
        //     const int segments = 4;
        //     const int segsize = 8;
        //     for(int i=0, offset = 0; i < segments; i++, offset += segsize)
        //         ginx.vnot(n, in skip(in rA, offset), ref seek(ref rDst, offset));
        // }

        // [MethodImpl(Inline)]
        // static void not(in ulong rA, ref ulong rDst)
        // {
        //     const int segments = 16;
        //     const int segsize = 4;
        //     for(int i=0, offset = 0; i < segments; i++, offset += segsize)
        //         ginx.vnot(n, in skip(in rA, offset), ref seek(ref rDst, offset));
        // }

    }
}