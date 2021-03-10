//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Numerics;

    using static Root;
    using static Pow2Data;

    using K = Pow2x64;

    /// <summary>
    /// Defines power-of-2 literals raning from 2^0 - 2^63
    /// </summary>
    [ApiHost]
    public struct Pow2 : IEquatable<Pow2>, IComparable<Pow2>
    {
        uint Index;

        [MethodImpl(Inline)]
        public Pow2(byte index)
            => Index = index;

        [MethodImpl(Inline)]
        public bool Equals(Pow2 src)
            => Index == src.Index;

        public override bool Equals(object src)
            => src is Pow2 p && Equals(p);

        public override int GetHashCode()
            => (int)Index;

        [MethodImpl(Inline)]
        public int CompareTo(Pow2 src)
            => Index.CompareTo(src.Index);

        [MethodImpl(Inline)]
        public string Format()
            => FormatHex();

        public string FormatHex()
            => Value.ToString("x") + "h";

        string FormatExponent()
            => string.Format("{0,-4}",$"{Index}^2");
        public string FormatSymbolic()
            => string.Format("{0} = {1}", FormatExponent(), FormatHex());

        public override string ToString()
            => Format();

        public ulong Value
        {
            [MethodImpl(Inline), Op]
            get => pow((byte)Index);
        }

        byte Val8u
        {
            [MethodImpl(Inline), Op]
            get => (byte)pow((byte)Index);
        }

        ushort Val16u
        {
            [MethodImpl(Inline), Op]
            get => (ushort)pow((byte)Index);
        }

        uint Val32u
        {
            [MethodImpl(Inline), Op]
            get => (uint)pow((byte)Index);
        }

        ulong Val64u
        {
            [MethodImpl(Inline), Op]
            get => pow((byte)Index);
        }

        [MethodImpl(Inline)]
        Pow2 Increment()
        {
            if(Index < 63)
                ++Index;
            else
                Index = 0;
            return this;
        }

        [MethodImpl(Inline)]
        Pow2 Decrement()
        {
            if(Index > 0)
                --Index;
            else
                Index = 63;
            return this;
        }

        [MethodImpl(Inline)]
        public static Pow2 operator ++(Pow2 src)
            => src.Increment();

        [MethodImpl(Inline)]
        public static Pow2 operator --(Pow2 src)
            => src.Decrement();

        [MethodImpl(Inline)]
        public static implicit operator Pow2(byte index)
            => new Pow2(index);

        [MethodImpl(Inline)]
        public static implicit operator Pow2(int index)
            => new Pow2((byte)index);

        [MethodImpl(Inline)]
        public static implicit operator Pow2(Pow2x1 index)
            => new Pow2((byte)index);

        [MethodImpl(Inline)]
        public static implicit operator Pow2(Pow2x2 index)
            => new Pow2((byte)index);

        [MethodImpl(Inline)]
        public static implicit operator Pow2(Pow2x3 index)
            => new Pow2((byte)index);

        [MethodImpl(Inline)]
        public static implicit operator Pow2(Pow2x4 index)
            => new Pow2((byte)index);

        [MethodImpl(Inline)]
        public static implicit operator Pow2(Pow2x8 index)
            => new Pow2((byte)index);

        [MethodImpl(Inline)]
        public static implicit operator Pow2(Pow2x16 index)
            => new Pow2((byte)index);

        [MethodImpl(Inline)]
        public static implicit operator Pow2(Pow2x32 index)
            => new Pow2((byte)index);

        [MethodImpl(Inline)]
        public static implicit operator Pow2(Pow2x64 index)
            => new Pow2((byte)index);

        [MethodImpl(Inline)]
        public static explicit operator Pow2x1(Pow2 src)
            => (Pow2x1)src.Value;

        [MethodImpl(Inline)]
        public static explicit operator Pow2x2(Pow2 src)
            => (Pow2x2)src.Value;

        [MethodImpl(Inline)]
        public static explicit operator Pow2x3(Pow2 src)
            => (Pow2x3)src.Value;

        [MethodImpl(Inline)]
        public static explicit operator Pow2x4(Pow2 src)
            => (Pow2x4)src.Value;

        [MethodImpl(Inline)]
        public static explicit operator Pow2x8(Pow2 src)
            => (Pow2x8)src.Value;

        [MethodImpl(Inline)]
        public static explicit operator Pow2x16(Pow2 src)
            => (Pow2x16)src.Value;

        [MethodImpl(Inline)]
        public static explicit operator Pow2x32(Pow2 src)
            => (Pow2x32)src.Value;

        [MethodImpl(Inline)]
        public static explicit operator Pow2x64(Pow2 src)
            => (Pow2x64)src.Value;

        [MethodImpl(Inline)]
        public static explicit operator byte(Pow2 src)
            => src.Val8u;

        [MethodImpl(Inline)]
        public static explicit operator ushort(Pow2 src)
            => src.Val16u;

        [MethodImpl(Inline)]
        public static explicit operator uint(Pow2 src)
            => src.Val32u;

        [MethodImpl(Inline)]
        public static explicit operator ulong(Pow2 src)
            => src.Val64u;

        [MethodImpl(Inline)]
        public static explicit operator sbyte(Pow2 src)
            => (sbyte)src.Val8u;

        [MethodImpl(Inline)]
        public static explicit operator short(Pow2 src)
            => (short)src.Val16u;

        [MethodImpl(Inline)]
        public static explicit operator int(Pow2 src)
            => (int)src.Val32u;

        [MethodImpl(Inline)]
        public static explicit operator long(Pow2 src)
            => (long)src.Val64u;

        /// <summary>
        /// Computes 2^i where i is an integer value in the interval [0,63]
        /// </summary>
        /// <param name="i">The exponent</param>
        [MethodImpl(Inline), Op]
        public static ulong pow(byte i)
            => 1ul << i;

        /// <summary>
        /// Computes 2^i where i is an integer value in the interval [0,63]
        /// </summary>
        /// <param name="i">The exponent</param>
        [MethodImpl(Inline), Op]
        public static ulong pow(int i)
            => pow((byte)i);

        [MethodImpl(Inline), Op]
        public static byte pow8u(byte i)
            => (byte)pow(i);

        [MethodImpl(Inline), Op]
        public static ushort pow16u(byte i)
            => (ushort)pow(i);

        [MethodImpl(Inline), Op]
        public static uint pow32u(byte i)
            => (uint)pow(i);

        [MethodImpl(Inline), Op]
        public static ulong pow64u(byte i)
            => pow(i);

        [MethodImpl(Inline), Op]
        public static bool test(ulong src)
        {
            var x = src & (src-1);
            var a = x != 0 ? true : false;
            var b = src != 0 ? true : false;
            return b && !a;
        }

        [MethodImpl(Inline), Op]
        public static byte log2(Pow2x1 src)
            => (byte)BitOperations.Log2((uint)src);

        [MethodImpl(Inline), Op]
        public static byte log2(Pow2x2 src)
            => (byte)BitOperations.Log2((uint)src);

        [MethodImpl(Inline), Op]
        public static byte log2(Pow2x3 src)
            => (byte)BitOperations.Log2((uint)src);

        [MethodImpl(Inline), Op]
        public static byte log2(Pow2x4 src)
            => (byte)BitOperations.Log2((uint)src);

        [MethodImpl(Inline), Op]
        public static byte log2(Pow2x8 src)
            => (byte)BitOperations.Log2((uint)src);

        [MethodImpl(Inline), Op]
        public static byte log2(Pow2x16 src)
            => (byte)BitOperations.Log2((uint)src);

        [MethodImpl(Inline), Op]
        public static byte log2(Pow2x32 src)
            => (byte)BitOperations.Log2((uint)src);

        [MethodImpl(Inline), Op]
        public static byte log2(Pow2x64 src)
            => (byte)BitOperations.Log2((uint)src);

        /// <summary>
        /// Computes floor(log(src,2))
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static byte log2(byte src)
            => (byte)BitOperations.Log2((uint)src);

        /// <summary>
        /// Computes floor(log(src,2))
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static ushort log2(ushort src)
            => (ushort)BitOperations.Log2((uint)src);

        /// <summary>
        /// Computes floor(log(src,2))
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static uint log2(uint src)
            => (uint)BitOperations.Log2(src);

        /// <summary>
        /// Computes floor(log(src,2))
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static ulong log2(ulong src)
            => (ulong)BitOperations.Log2(src);

        [MethodImpl(Inline), Op]
        public static ulong lookup(byte i)
        {
            ref readonly var first = ref MemoryMarshal.GetReference(Pow2Bytes);
            ref var start =  ref Unsafe.Add(ref Unsafe.AsRef(first), i*8);
            return Unsafe.As<byte,ulong>(ref start);
        }

        [MethodImpl(Inline), Op]
        public static ulong m1(byte i)
        {
            ref readonly var first = ref MemoryMarshal.GetReference(M1Bytes64u);
            ref var start =  ref Unsafe.Add(ref Unsafe.AsRef(first), i*8);
            return Unsafe.As<byte,ulong>(ref start);
        }

        [MethodImpl(Inline)]
        static ReadOnlySpan<byte> slice32iM1(int index)
            => M1Bytes32i.Slice(index*4,4);

        [MethodImpl(Inline)]
        static ReadOnlySpan<byte> slice32uM1(int index)
            => M1Bytes32u.Slice(index*4,4);

        [MethodImpl(Inline)]
        static ReadOnlySpan<byte> slice64iM1(int index)
            => M1Bytes64i.Slice(index*8,8);

        [MethodImpl(Inline)]
        static ReadOnlySpan<byte> slice64uM1(int index)
            => M1Bytes64u.Slice(index*8,8);

        [MethodImpl(Inline)]
        static ReadOnlySpan<byte> slice(int log2IdxFirst, int log2IdxLast)
            => Pow2Bytes.Slice(log2IdxFirst*8, (log2IdxLast - log2IdxFirst)*8);

        [MethodImpl(Inline)]
        static ReadOnlySpan<byte> slice32iM1(int i0, int i1)
            => M1Bytes32i.Slice(i0*4, (i1 - i0)*4);

        [MethodImpl(Inline)]
        static ReadOnlySpan<byte> slice32uM1(int i0, int i1)
            => M1Bytes32u.Slice(i0*4, (i1 - i0)*4);

        [MethodImpl(Inline)]
        static ReadOnlySpan<byte> slice64iM1(int i0, int i1)
            => M1Bytes64i.Slice(i0*8, (i1 - i0)*8);

        [MethodImpl(Inline)]
        static ReadOnlySpan<byte> slice64uM1(int i0, int i1)
            => M1Bytes64u.Slice(i0*8, (i1 - i0)*8);

        /// <summary>
        /// 2^0 = 1
        /// </summary>
        public const byte T00 = 1;

        /// <summary>
        /// 2^1 = 2
        /// </summary>
        public const byte T01 = 2;

        /// <summary>
        /// 2^2 = 4
        /// </summary>
        public const byte T02 = 4;

        /// <summary>
        /// 2^3 = 8
        /// </summary>
        public const byte T03 = 8;

        /// <summary>
        /// 2^4 = 16
        /// </summary>
        public const byte T04 = 16;

        /// <summary>
        /// 2^5 = 32
        /// </summary>
        public const byte T05 = 32;

        /// <summary>
        /// 2^6 = 64
        /// </summary>
        public const byte T06 = 64;

        /// <summary>
        /// 2^7 = 128
        /// </summary>
        public const byte T07 =  128;

        /// <summary>
        /// 2^8 = 256 = UInt8.MaxValue + 1
        /// </summary>
        public const ushort T08 = 256;

        /// <summary>
        /// 2^9 = 512
        /// </summary>
        public const ushort T09 = 512;

        /// <summary>
        /// 2^10 = 1024
        /// </summary>
        public const ushort T10 = 1024;

        /// <summary>
        /// 2^11 = 2048
        /// </summary>
        public const ushort T11 = 2048;

        /// <summary>
        /// 2^12 = 4096
        /// </summary>
        public const ushort T12 =  4096;

        /// <summary>
        /// 2^13 = 8192
        /// </summary>
        public const ushort T13 = 8192;

        /// <summary>
        /// 2^14 = 16,384
        /// </summary>
        public const ushort T14 =  16_384;

        /// <summary>
        /// 2^15 = 32,768
        /// </summary>
        public const ushort T15 = 32_768;

        /// <summary>
        /// 2^16 = 65,536
        /// </summary>
        public const uint T16 = 65_536;

        /// <summary>
        /// 2^17 = 131,072
        /// </summary>
        public const uint T17 = 131_072;

        /// <summary>
        /// 2^18 = 262,144
        /// </summary>
        public const uint T18 = 262_144;

        /// <summary>
        /// 2^19 = 524,288
        /// </summary>
        public const uint T19 = 524_288;

        /// <summary>
        /// 2^20 = 1,048,576
        /// </summary>
        public const uint T20 = 1_048_576;

        /// <summary>
        /// 2^21 = 2_097_152
        /// </summary>
        public const uint T21 = 2_097_152;

        /// <summary>
        /// 2^22 = 4_194_304
        /// </summary>
        public const uint T22 = 4_194_304;

        /// <summary>
        /// 2^23 = 8,388,608
        /// </summary>
        public const uint T23 = 8_388_608;

        /// <summary>
        /// 2^24 = 16,777,216
        /// </summary>
        public const uint T24 = 16_777_216;

        /// <summary>
        /// 2^25 = 33,554,432
        /// </summary>
        public const uint T25 = 33_554_432;

        /// <summary>
        /// 2^26 = 67,108,864 = 0x4000000
        /// </summary>
        public const uint T26 = 0x4000000;

        /// <summary>
        /// 2^27 = 134,217,728 = 0x8000000
        /// </summary>
        public const uint T27 = 0x8000000;

        /// <summary>
        /// 2^28 = 268,435,456 = 0x10000000
        /// </summary>
        public const uint T28 = 0x10000000;

        /// <summary>
        /// 2^29 = 536_870_912 = 0x20000000;
        /// </summary>
        public const uint T29 = 0x20000000;

        /// <summary>
        /// 2^30 = 1,073,741,824 = 0x40000000
        /// </summary>
        public const uint T30 = 0x40000000;

        /// <summary>
        /// 2^31 = 2,147,483,648 = 0x80000000
        /// </summary>
        public const uint T31 = 0x80000000;

        /// <summary>
        /// 2^32 = 4,294,967,296 = 0x100000000
        /// </summary>
        public const ulong T32 = 0x100000000;

        public const ulong T33 = (ulong)K.P2ᐞ33;

        public const ulong T34 = (ulong)K.P2ᐞ34;

        public const ulong T35 = (long)K.P2ᐞ35;

        public const ulong T36 = (long)K.P2ᐞ36;

        public const ulong T37 = (long)K.P2ᐞ37;

        public const ulong T38 = (long)K.P2ᐞ38;

        public const ulong T39 = (long)K.P2ᐞ39;

        public const ulong T40 = (long)K.P2ᐞ40;

        public const ulong T41 = (long)K.P2ᐞ41;

        public const ulong T42 = (long)K.P2ᐞ42;

        public const ulong T43 = (long)K.P2ᐞ43;

        public const ulong T44 = (long)K.P2ᐞ44;

        public const long T45 = (long)K.P2ᐞ45;

        public const long T46 = (long)K.P2ᐞ46;

        public const long T47 = (long)K.P2ᐞ47;

        public const long T48 = (long)K.P2ᐞ48;

        public const long T49 = (long)K.P2ᐞ49;

        public const long T50 = (long)K.P2ᐞ50;

        public const long T51 = (long)K.P2ᐞ51;

        public const long T52 = (long)K.P2ᐞ52;

        public const long T53 = 2*T52;

        public const long T54 = 2*T53;

        public const long T55 = 2*T54;

        public const long T56 = 2*T55;

        public const long T57 = 2*T56;

        public const long T58 = 2*T57;

        public const long T59 = (long)K.P2ᐞ59;

        public const long T60 = (long)K.P2ᐞ60;

        public const long T61 = (long)K.P2ᐞ61;

        public const long T62 = (long)K.P2ᐞ62;

        /// <summary>
        /// T63 = 9223372036854775808
        /// </summary>
        public const ulong T63 = (ulong)K.P2ᐞ63;
    }
}