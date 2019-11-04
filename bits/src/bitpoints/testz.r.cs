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
        public static unsafe bit testz<T>(in T rA, in T rB, ref T rDst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               return testz(in uint8(in rA), in uint8(in rB));
            else if(typeof(T) == typeof(ushort))
               return testz(in uint16(in rA), in uint16(in rB));
            else if(typeof(T) == typeof(uint))
               return testz(in uint32(in rA), in uint32(in rB));
            else if(typeof(T) == typeof(ulong))
               return testz(in uint64(in rA), in uint64(in rB));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static unsafe bit testz(in byte rA, in byte rB)
        {
            var a = content(in rA);
            var b = content(in rB);
            var x = dinx.vbroadcast(n128, a);
            var y = dinx.vbroadcast(n128, b);
            return dinx.vtestz(x,y);
        }

        [MethodImpl(Inline)]
        static bit testz(in ushort rA, in ushort rB)
            => ginx.vtestz(n, in rA, in rB);
        
        [MethodImpl(Inline)]
        static bit testz(in uint rA, in uint rB)
        {
            const int segments = 4;
            const int segsize = 8;

            var result = on;
            for(int i=0, offset = 0; i < segments; i++, offset += segsize)
                result &= ginx.vtestz(n, in skip(in rA, offset), in skip(in rB, offset));
            return result;
        }

        [MethodImpl(Inline)]
        static bit testz(in ulong rA, in ulong rB)
        {
            const int segments = 16;
            const int segsize = 4;
            var result = on;
            for(int i=0, offset = 0; i < segments; i++, offset += segsize)
                result &= ginx.vtestz(n, in skip(in rA, offset), in skip(in rB, offset));
            return result;
        }

    }
}