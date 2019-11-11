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

    static partial class BitBlocks
    {
        static N256 n => n256;


        [MethodImpl(Inline)]
        public static void not<T>(in T rA, ref T rDst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               not(in uint8(in rA), ref uint8(ref rDst));
            else if(typeof(T) == typeof(ushort))
                vblock.not(n, in rA, ref rDst);
            else if(typeof(T) == typeof(uint))
                vblock.not(n, 4, 8, in rA, ref rDst);
            else if(typeof(T) == typeof(ulong))
                vblock.not(n, 16, 4, in rA, ref rDst);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static void not(in byte rA, ref byte rDst)
            => content(math.not(content(rA)), ref rDst);
 
        [MethodImpl(Inline)]
        public static void select<T>(in T rA, in T rB, in T rC, ref T rDst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               select(in uint8(in rA), in uint8(in rB), in uint8(in rC), ref uint8(ref rDst));
            else if(typeof(T) == typeof(ushort))
                vblock.select(n, in rA, in rB, in rC, ref rDst);
            else if(typeof(T) == typeof(uint))
                vblock.select(n, 4, 8, in rA, in rB, in rC, ref rDst);
            else if(typeof(T) == typeof(ulong))
                vblock.select(n, 16, 4, in rA, in rB, in rC, ref rDst);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static void select(in byte rA, in byte rB, in byte rC, ref byte rDst)
            => content(gmath.select(content(rA), content(rB), content(rC)), ref rDst);

        [MethodImpl(Inline)]
        public static void and<T>(in T a, in T b, ref T z)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               and(in uint8(in a), in uint8(in b), ref uint8(ref z));
            else if(typeof(T) == typeof(ushort))
                vblock.and(n, in a, in b, ref z);
            else if(typeof(T) == typeof(uint))
                vblock.and(n, 4, 8, in a, in b, ref z);
            else if(typeof(T) == typeof(ulong))
                vblock.and(n, 16, 4, in a, in b, ref z);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static void and(in byte rA, in byte rB, ref byte rDst)
            => content(math.and(content(rA), content(rB)), ref rDst);
 
         [MethodImpl(Inline)]
        public static void nand<T>(in T rA, in T rB, ref T rDst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               nand(in uint8(in rA), in uint8(in rB), ref uint8(ref rDst));
            else if(typeof(T) == typeof(ushort))
                vblock.nand(n, in rA, in rB, ref rDst);
            else if(typeof(T) == typeof(uint))
                vblock.nand(n, 4, 8, in rA, in rB, ref rDst);
            else if(typeof(T) == typeof(ulong))
                vblock.nand(n, 16, 4, in rA, in rB, ref rDst);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static void nand(in byte rA, in byte rB, ref byte rDst)
            => content(math.nand(content(rA), content(rB)), ref rDst);


        [MethodImpl(Inline)]
        public static void or<T>(in T rA, in T rB, ref T rDst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               or(in uint8(in rA), in uint8(in rB), ref uint8(ref rDst));
            else if(typeof(T) == typeof(ushort))
                vblock.or(n, in rA, in rB, ref rDst);
            else if(typeof(T) == typeof(uint))
                vblock.or(n, 4, 8, in rA, in rB, ref rDst);
            else if(typeof(T) == typeof(ulong))
                vblock.or(n, 16, 4, in rA, in rB, ref rDst);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static void or(in byte rA, in byte rB, ref byte rDst)
            => content(math.or(content(rA), content(rB)), ref rDst);

        [MethodImpl(Inline)]
        public static void nor<T>(in T rA, in T rB, ref T rDst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               nor(in uint8(in rA), in uint8(in rB), ref uint8(ref rDst));
            else if(typeof(T) == typeof(ushort))
                vblock.nor(n, in rA, in rB, ref rDst);
            else if(typeof(T) == typeof(uint))
                vblock.nor(n, 4, 8, in rA, in rB, ref rDst);
            else if(typeof(T) == typeof(ulong))
                vblock.nor(n, 16, 4, in rA, in rB, ref rDst);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static void nor(in byte rA, in byte rB, ref byte rDst)
            => content(math.nor(content(rA), content(rB)), ref rDst);

        [MethodImpl(Inline)]
        public static void xor<T>(in T rA, in T rB, ref T rDst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               xor(in uint8(in rA), in uint8(in rB), ref uint8(ref rDst));
            else if(typeof(T) == typeof(ushort))
                vblock.xor(n, in rA, in rB, ref rDst);
            else if(typeof(T) == typeof(uint))
                vblock.xor(n, 4, 8, in rA, in rB, ref rDst);
            else if(typeof(T) == typeof(ulong))
                vblock.xor(n, 16, 4, in rA, in rB, ref rDst);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static void xor(in byte rA, in byte rB, ref byte rDst)
            => content(math.xor(content(rA), content(rB)), ref rDst);

        [MethodImpl(Inline)]
        public static void xnor<T>(in T rA, in T rB, ref T rDst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               xnor(in uint8(in rA), in uint8(in rB), ref uint8(ref rDst));
            else if(typeof(T) == typeof(ushort))
                vblock.xnor(n, in rA, in rB, ref rDst);
            else if(typeof(T) == typeof(uint))
                vblock.xnor(n, 4, 8, in rA, in rB, ref rDst);
            else if(typeof(T) == typeof(ulong))
                vblock.xnor(n, 16, 4, in rA, in rB, ref rDst);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static void xnor(in byte rA, in byte rB, ref byte rDst)
            => content(math.xnor(content(rA), content(rB)), ref rDst);

        [MethodImpl(Inline)]
        public static void imply<T>(in T rA, in T rB, ref T rDst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               imply(in uint8(in rA), in uint8(in rB), ref uint8(ref rDst));
            else if(typeof(T) == typeof(ushort))
                vblock.imply(n, in rA, in rB, ref rDst);
            else if(typeof(T) == typeof(uint))
                vblock.imply(n, 4, 8, in rA, in rB, ref rDst);
            else if(typeof(T) == typeof(ulong))
                vblock.imply(n, 16, 4, in rA, in rB, ref rDst);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static void notimply<T>(in T rA, in T rB, ref T rDst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               notimply(in uint8(in rA), in uint8(in rB), ref uint8(ref rDst));
            else if(typeof(T) == typeof(ushort))
                vblock.notimply(n, in rA, in rB, ref rDst);
            else if(typeof(T) == typeof(uint))
                vblock.notimply(n, 4, 8, in rA, in rB, ref rDst);
            else if(typeof(T) == typeof(ulong))
                vblock.notimply(n, 16, 4, in rA, in rB, ref rDst);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static void notimply(in byte rA, in byte rB, ref byte rDst)
            => content(math.notimply(content(rA), content(rB)), ref rDst);

        [MethodImpl(Inline)]
        static void imply(in byte rA, in byte rB, ref byte rDst)
            => content(math.imply(content(rA), content(rB)), ref rDst);

        [MethodImpl(Inline)]
        public static void cimply<T>(in T rA, in T rB, ref T rDst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               cimply(in uint8(in rA), in uint8(in rB), ref uint8(ref rDst));
            else if(typeof(T) == typeof(ushort))
                vblock.cimply(n, in rA, in rB, ref rDst);
            else if(typeof(T) == typeof(uint))
                vblock.cimply(n, 4, 8, in rA, in rB, ref rDst);
            else if(typeof(T) == typeof(ulong))
                vblock.cimply(n, 16, 4, in rA, in rB, ref rDst);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static void cimply(in byte rA, in byte rB, ref byte rDst)
            => content(math.cimply(content(rA), content(rB)), ref rDst);

         [MethodImpl(Inline)]
        public static void cnotimply<T>(in T rA, in T rB, ref T rDst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               cnotimply(in uint8(in rA), in uint8(in rB), ref uint8(ref rDst));
            else if(typeof(T) == typeof(ushort))
                vblock.cnotimply(n, in rA, in rB, ref rDst);
            else if(typeof(T) == typeof(uint))
                vblock.cnotimply(n, 4, 8, in rA, in rB, ref rDst);
            else if(typeof(T) == typeof(ulong))
                vblock.cnotimply(n, 16, 4, in rA, in rB, ref rDst);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static void cnotimply(in byte rA, in byte rB, ref byte rDst)
            => content(math.cnotimply(content(rA), content(rB)), ref rDst);
 
         [MethodImpl(Inline)]
        public static void xornot<T>(in T rA, in T rB, ref T rDst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               xornot(in uint8(in rA), in uint8(in rB), ref uint8(ref rDst));
            else if(typeof(T) == typeof(ushort))
               xornot(in uint16(in rA), in uint16(in rB), ref uint16(ref rDst));
            else if(typeof(T) == typeof(uint))
               xornot(in uint32(in rA), in uint32(in rB), ref uint32(ref rDst));
            else if(typeof(T) == typeof(ulong))
               xornot(in uint64(in rA), in uint64(in rB), ref uint64(ref rDst));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static void xornot(in byte rA, in byte rB, ref byte rDst)
            => content(math.xor(content(in rA), math.not(content(in rB))), ref rDst);

        [MethodImpl(Inline)]
        static void xornot(in ushort rA, in ushort rB, ref ushort rDst)
            => ginx.vstore(ginx.vxornot(n, in rA, in rB), ref rDst);
        
        [MethodImpl(Inline)]
        static void xornot(in uint rA, in uint rB, ref uint rDst)
        {
            const int segments = 4;
            const int segsize = 8;
            for(int i=0, offset = 0; i < segments; i++, offset += segsize)
                ginx.vxornot(n, in skip(in rA, offset), in skip(in rB, offset), ref seek(ref rDst, offset));
        }

        [MethodImpl(Inline)]
        static void xornot(in ulong rA, in ulong rB, ref ulong rDst)
        {
            const int segments = 16;
            const int segsize = 4;
            for(int i=0, offset = 0; i < segments; i++, offset += segsize)
                ginx.vxornot(n, in skip(in rA, offset), in skip(in rB, offset), ref seek(ref rDst, offset));
        }

        [MethodImpl(Inline)]
        public static bit testz<T>(in T rA, in T rB)
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
        static bit testz(in byte rA, in byte rB)
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


        [MethodImpl(Inline)]
        public static bit testc<T>(in T a)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               return testc(in uint8(in a));
            else if(typeof(T) == typeof(ushort))
               return vblock.vtestc(n, in a);
            else if(typeof(T) == typeof(uint))
               return vblock.testc(n, 4, 8, in a);
            else if(typeof(T) == typeof(ulong))
                return vblock.testc(n, 16, 4, in a);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bit testc<T>(in T a, in T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               return testc(in uint8(in a),in uint8(in b));
            else if(typeof(T) == typeof(ushort))
               return vblock.vtestc(n, in a,in b);
            else if(typeof(T) == typeof(uint))
               return vblock.testc(n, 4, 8, in a, in b);
            else if(typeof(T) == typeof(ulong))
                return vblock.testc(n, 16, 4, in a, in b);
            else
                throw unsupported<T>();
        }


        [MethodImpl(Inline)]
        static bit testc(in byte rA)
        {
            var a = content(in rA);
            var x = ginx.vbroadcast(n128,a);
            return ginx.vtestc(x);
        }

        [MethodImpl(Inline)]
        static bit testc(in byte rA, in byte rB)
        {
            var a = content(in rA);
            var b = content(in rB);
            var x = ginx.vbroadcast(n128,a);
            var y = ginx.vbroadcast(n128,b);
            return ginx.vtestc(x,y);
        }

        [MethodImpl(Inline)]
        static unsafe ulong content(in byte rA)
            => *(ulong*)As.constptr(in rA);

        [MethodImpl(Inline)]
        static unsafe void content(ulong src, ref byte pDst)
             => *((ulong*)As.refptr(ref pDst)) = src;
    }
}