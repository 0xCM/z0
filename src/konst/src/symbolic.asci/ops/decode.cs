//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;

    partial struct Asci
    {
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> decode(AsciCharCode src)
        {
            var storage = 0u;
            ref var dst = ref @as<uint,char>(storage);
            seek(dst, 0) = (char)(byte)src;
            return z.cover(dst, 2);
        }

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> decode(in asci2 src)
        {
            var storage = 0u;
            ref var dst = ref @as<uint,char>(storage);
            seek(dst, 0) = (char)(byte)(src.Storage >> 0);
            seek(dst, 1) = (char)(byte)(src.Storage >> 8);
            return z.cover(dst, 2);
        }

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> decode(in asci4 src)
        {
            var storage = 0ul;
            ref var dst = ref @as<ulong,char>(storage);
            seek(dst, 0) = (char)(byte)(src.Storage >> 0);
            seek(dst, 1) = (char)(byte)(src.Storage >> 8);
            seek(dst, 2) = (char)(byte)(src.Storage >> 16);
            seek(dst, 3) = (char)(byte)(src.Storage >> 24);
            return z.cover(dst, asci4.Size);
        }

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> decode(in asci8 src)
        {
            var decoded = cpu.vinflate(cpu.vbytes(w128, src.Storage));
            return z.recover<char>(z.bytes(vlo(decoded)));
        }

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> decode(in asci16 src)
            => z.recover<char>(z.bytes(cpu.vinflate(src.Storage)));

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> decode(in asci32 src)
        {
            var lo = cpu.vinflate(src.Storage, n0);
            var hi = cpu.vinflate(src.Storage, n1);
            return z.recover<char>(z.bytes(new Seg512(lo,hi)));
        }

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> decode(in asci64 src)
        {
            var x = src.Storage;
            var x0 = cpu.vinflate(x.Lo,n0);
            var x1 = cpu.vinflate(x.Lo,n1);
            var x2 = cpu.vinflate(x.Hi,n0);
            var x3 = cpu.vinflate(x.Hi,n1);
            return z.recover<char>(z.bytes(new Seg1024(x0,x1,x2,x3)));
        }

        [MethodImpl(Inline), Op]
        public static void decode(in asci8 src, ref char dst)
        {
            var decoded = cpu.vinflate(cpu.vbytes(w128, src.Storage));
            z.vstore(decoded.GetLower(), ref @as<char,ushort>(dst));
        }

        [MethodImpl(Inline), Op]
        public static void decode(in asci16 src, ref char dst)
        {
           var decoded = cpu.vinflate(src.Storage);
           z.vstore(decoded, ref @as<char,ushort>(dst));
        }

        [MethodImpl(Inline), Op]
        public static void decode(in asci32 src, ref char dst)
        {
            decode(src.Lo, ref dst);
            decode(src.Hi, ref seek(dst, 16));
        }

        [MethodImpl(Inline), Op]
        public static void decode(in asci64 src, ref char dst)
        {
            decode(src.Lo, ref dst);
            decode(src.Hi, ref seek(dst, 32));
        }

        readonly struct Seg512
        {
            readonly Vector256<ushort> Lo;

            readonly Vector256<ushort> Hi;

            [MethodImpl(Inline), Op]
            public Seg512(Vector256<ushort> lo, Vector256<ushort> hi)
            {
                this.Lo = lo;
                this.Hi = hi;
            }
        }

        readonly struct Seg1024
        {
            readonly Vector256<ushort> X0;

            readonly Vector256<ushort> X1;

            readonly Vector256<ushort> X2;

            readonly Vector256<ushort> X3;

            [MethodImpl(Inline), Op]
            public Seg1024(Vector256<ushort> x0, Vector256<ushort> x1,Vector256<ushort> x2,Vector256<ushort> x3)
            {
                X0 = x0;
                X1 = x1;
                X2 = x2;
                X3 = x3;
            }
        }
    }
}