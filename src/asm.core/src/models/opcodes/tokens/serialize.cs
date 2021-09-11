//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using static core;

    using K = AsmOcTokenKind;
    using P = Pow2x32;

    partial struct TokenMaps
    {
        [Op]
        public static uint serialize(BitMapper<K,P> src, Span<ushort> dst)
        {
            var points = src.Points;
            var count = points.Length;
            var j=0;
            for(var i=0; i<count; i++)
            {
                ref readonly var point = ref seek(points,i);
                ref var t0 = ref @as<byte>(seek(dst,i));
                ref var t1 = ref @as<Log2x32>(seek(t0,1));
                t0 = u8(point.Index);
                t1 = Pow2.log(point.Bits);
            }

            return 0;
        }

        public static Index<ushort> serialize(BitMapper<K,P> src)
        {
            var dst = alloc<ushort>(src.PointCount);
            serialize(src,dst);
            return dst;
        }

        [Op]
        public static BitMapper<K,P> ockinds()
        {
            const byte Capacity = 15;
            var dst = alloc<BitMap<K,P>>(Capacity);
            kseek(dst, K.None).Index = K.None;
            kseek(dst, K.None).Bits = P.P2ᐞ00;

            kseek(dst, K.Byte).Index = K.Byte;
            kseek(dst, K.Byte).Bits = P.P2ᐞ01;

            kseek(dst, K.Rex).Index = K.Rex;
            kseek(dst, K.Rex).Bits = P.P2ᐞ02;

            kseek(dst, K.Vex).Index = K.Vex;
            kseek(dst, K.Vex).Bits = P.P2ᐞ03;

            kseek(dst, K.Evex).Index = K.Evex;
            kseek(dst, K.Evex).Bits = P.P2ᐞ04;

            kseek(dst, K.Escape).Index = K.Escape;
            kseek(dst, K.Escape).Bits = P.P2ᐞ05;

            kseek(dst, K.RexBExtension).Index = K.RexBExtension;
            kseek(dst, K.RexBExtension).Bits = P.P2ᐞ06;

            kseek(dst, K.RegOpCodeMod).Index = K.RegOpCodeMod;
            kseek(dst, K.RegOpCodeMod).Bits = P.P2ᐞ07;

            kseek(dst, K.SegOverride).Index = K.SegOverride;
            kseek(dst, K.SegOverride).Bits = P.P2ᐞ08;

            kseek(dst, K.Disp).Index = K.Disp;
            kseek(dst, K.Disp).Bits = P.P2ᐞ09;

            kseek(dst, K.ImmSize).Index = K.ImmSize;
            kseek(dst, K.ImmSize).Bits = P.P2ᐞ10;

            kseek(dst, K.Exclusion).Index = K.Exclusion;
            kseek(dst, K.Exclusion).Bits = P.P2ᐞ11;

            kseek(dst, K.FpuDigit).Index = K.FpuDigit;
            kseek(dst, K.FpuDigit).Bits = P.P2ᐞ12;

            kseek(dst, K.Mask).Index = K.Mask;
            kseek(dst, K.Mask).Bits = P.P2ᐞ13;

            kseek(dst, K.Operator).Index = K.Operator;
            kseek(dst, K.Operator).Bits = P.P2ᐞ14;

            return new BitMapper<K,P>(dst);
        }
    }
}