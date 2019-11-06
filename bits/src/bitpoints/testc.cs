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
        public static unsafe bit testc<T>(in T rA)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               return testc(in uint8(in rA));
            else if(typeof(T) == typeof(ushort))
               return testc(in uint16(in rA));
            else if(typeof(T) == typeof(uint))
               return testc(in uint32(in rA));
            else if(typeof(T) == typeof(ulong))
               return testc(in uint64(in rA));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static unsafe bit testc<T>(in T rA, in T rB)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               return testc(in uint8(in rA), in uint8(in rB));
            else if(typeof(T) == typeof(ushort))
               return testc(in uint16(in rA), in uint16(in rB));
            else if(typeof(T) == typeof(uint))
               return testc(in uint32(in rA), in uint32(in rB));
            else if(typeof(T) == typeof(ulong))
               return testc(in uint64(in rA), in uint64(in rB));
            else
                throw unsupported<T>();
        }


        [MethodImpl(Inline)]
        static unsafe bit testc(in byte rA)
        {
            var a = content(in rA);
            var x = ginx.vbroadcast(n128,a);
            return ginx.vtestc(x);
        }

        [MethodImpl(Inline)]
        static unsafe bit testc(in ushort rA)
            => ginx.vtestc(n, in rA);

        [MethodImpl(Inline)]
        static unsafe bit testc(in uint rA)
        {
            const int segments = 4;
            const int segsize = 8;

            var result = on;
            for(int i=0, offset = 0; i < segments; i++, offset += segsize)
                result &= ginx.vtestc(n, in skip(in rA, offset));
            return result;
        }

        [MethodImpl(Inline)]
        static unsafe bit testc(in ulong rA)
        {
            const int segments = 16;
            const int segsize = 4;
            var result = on;
            for(int i=0, offset = 0; i < segments; i++, offset += segsize)
                result &= ginx.vtestc(n, in skip(in rA, offset));
            return result;
        }

        [MethodImpl(Inline)]
        static unsafe bit testc(in byte rA, in byte rB)
        {
            var a = content(in rA);
            var b = content(in rB);
            var x = dinx.vbroadcast(n128, a);
            var y = dinx.vbroadcast(n128, b);
            return dinx.vtestc(x,y);
        }

        [MethodImpl(Inline)]
        static bit testc(in ushort rA, in ushort rB)
            => ginx.vtestc(n, in rA, in rB);
        
        [MethodImpl(Inline)]
        static bit testc(in uint rA, in uint rB)
        {
            const int segments = 4;
            const int segsize = 8;

            var result = on;
            for(int i=0, offset = 0; i < segments; i++, offset += segsize)
                result &= ginx.vtestc(n, in skip(in rA, offset), in skip(in rB, offset));
            return result;
        }

        [MethodImpl(Inline)]
        static bit testc(in ulong rA, in ulong rB)
        {
            const int segments = 16;
            const int segsize = 4;
            var result = on;
            for(int i=0, offset = 0; i < segments; i++, offset += segsize)
                result &= ginx.vtestc(n, in skip(in rA, offset), in skip(in rB, offset));
            return result;
        }

    }
}