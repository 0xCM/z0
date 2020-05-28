//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Seed;
    using static Control;

    using HSL = HexSymbolLo;
    using HSU = HexSymbolUp;

    partial class Symbolic    
    {        
        [MethodImpl(Inline), Op]
        public static void digits(Base2 @base, byte src, Span<BinaryDigit> dst)
        {
            seek(dst,0) = (BinaryDigit)((0b00000001 & src) >> 0);
            seek(dst,1) = (BinaryDigit)((0b00000010 & src) >> 1);
            seek(dst,2) = (BinaryDigit)((0b00000100 & src) >> 2);
            seek(dst,3) = (BinaryDigit)((0b00001000 & src) >> 3);
            seek(dst,4) = (BinaryDigit)((0b00010000 & src) >> 4);
            seek(dst,5) = (BinaryDigit)((0b00100000 & src) >> 5);
            seek(dst,6) = (BinaryDigit)((0b01000000 & src) >> 6);
            seek(dst,7) = (BinaryDigit)((0b10000000 & src) >> 7);
        }

        [MethodImpl(Inline), Op]
        public static void digits(Base2 @base, ushort src, Span<BinaryDigit> dst)
        {
            digits(@base, (byte)src, dst);
            digits(@base, (byte)(src >> 8), dst.Slice(8));
        }

        [MethodImpl(Inline), Op]
        public static void digits(Base2 @base, uint src, Span<BinaryDigit> dst)
        {
            digits(@base, (ushort)src,dst);
            digits(@base, (ushort)(src >> 16),dst.Slice(16));
        }

        [MethodImpl(Inline), Op]
        public static void digits(Base2 @base, ulong src, Span<BinaryDigit> dst)
        {
            digits(@base, (uint)src,dst);
            digits(@base, (uint)(src >> 32), dst.Slice(32));
        }

        /// <summary>
        /// Computes the digigs corresponding to each 2-bit segment of the permutation spec
        /// </summary>
        /// <param name="src">The perm spec</param>
        [MethodImpl(Inline), Op]
        public static Span<byte> digits(Perm4L src, Span<byte> dst)
        {
            var scalar = (byte)src;
            seek(dst,0) = BitOps.extract(scalar, 0, 1);
            seek(dst,1) = BitOps.extract(scalar, 2, 3);
            seek(dst,2) = BitOps.extract(scalar, 4, 5);
            seek(dst,3) = BitOps.extract(scalar, 6, 7);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<byte> digits(Perm4L src)
            => Symbolic.digits(src, new byte[4]);

        [MethodImpl(Inline), Op]
        public static void digits(ReadOnlySpan<HSL> src, Span<HexDigit> dst)
        {
            var len = src.Length;
            for(var i = 0; i<len; i++)
                seek(dst,i) = digit(skip(src,i));            
        }

        [MethodImpl(Inline), Op]
        public static void digits(ReadOnlySpan<HSU> src, Span<HexDigit> dst)
        {
            var len = src.Length;
            for(var i = 0; i<len; i++)
                seek(dst,i) = digit(skip(src,i));            
        }

        [MethodImpl(Inline), Op]
        public static void digits(ReadOnlySpan<BinarySymbol> src, Span<BinaryDigit> dst)
        {
            var len = src.Length;
            for(var i = 0; i<len; i++)
                seek(dst,i) = digit(skip(src,i));            
        }

        /// <summary>
        /// Computes the digits corresponding to each 3-bit segment of the permutation spec
        /// </summary>
        /// <param name="src">The perm spec</param>
        [MethodImpl(Inline), Op]
        public static Span<OctalDigit> digits(Perm8L src, Span<OctalDigit> dst)
        {
            //[0 1 2 | 3 4 5 | 6 7 8 | ... | 21 22 23] -> 256x32
            var scalar = (uint)src;
            seek(dst,0) = (OctalDigit)BitOps.extract(scalar, 0, 2);
            seek(dst,1) = (OctalDigit)BitOps.extract(scalar, 3, 5);
            seek(dst,2) = (OctalDigit)BitOps.extract(scalar, 6, 8);
            seek(dst,3) = (OctalDigit)BitOps.extract(scalar, 9, 11);
            seek(dst,4) = (OctalDigit)BitOps.extract(scalar, 12, 14);
            seek(dst,5) = (OctalDigit)BitOps.extract(scalar, 15, 17);
            seek(dst,6) = (OctalDigit)BitOps.extract(scalar, 18, 20);
            seek(dst,7) = (OctalDigit)BitOps.extract(scalar, 21, 23);
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static Span<OctalDigit> digits(Perm8L src)
            => digits(src, new OctalDigit[8]);

        /// <summary>
        /// Computes the digits corresponding to each 4-bit segment of the permutation spec
        /// </summary>
        /// <param name="src">The perm spec</param>
        [MethodImpl(Inline), Op]
        public static Span<HexDigit> digits(Perm16L src, Span<HexDigit> dst)
        {
            var scalar = (ulong)src;
            seek(dst,0) = (HexDigit)BitOps.extract(scalar, 0, 3);
            seek(dst,1) = (HexDigit)BitOps.extract(scalar, 4, 7);
            seek(dst,2) = (HexDigit)BitOps.extract(scalar, 8, 11);
            seek(dst,3) = (HexDigit)BitOps.extract(scalar, 12, 15);
            seek(dst,4) = (HexDigit)BitOps.extract(scalar, 16, 19);
            seek(dst,5) = (HexDigit)BitOps.extract(scalar, 20, 23);
            seek(dst,6) = (HexDigit)BitOps.extract(scalar, 24, 27);
            seek(dst,7) = (HexDigit)BitOps.extract(scalar, 28, 31);
            seek(dst,8) = (HexDigit)BitOps.extract(scalar, 32, 35);
            seek(dst,9) = (HexDigit)BitOps.extract(scalar, 36, 39);
            seek(dst,10) = (HexDigit)BitOps.extract(scalar, 40, 43);
            seek(dst,11) = (HexDigit)BitOps.extract(scalar, 44, 47);
            seek(dst,12) = (HexDigit)BitOps.extract(scalar, 48, 53);
            seek(dst,13) = (HexDigit)BitOps.extract(scalar, 52, 55);
            seek(dst,14) = (HexDigit)BitOps.extract(scalar, 56, 59);
            seek(dst,15) = (HexDigit)BitOps.extract(scalar, 60, 63);
            return dst;
        }
        
        [MethodImpl(Inline)]
        public static Span<HexDigit> digits(Perm16L src)        
            => digits(src, new HexDigit[16]);
    }
}