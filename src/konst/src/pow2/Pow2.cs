//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    
    using static Konst;
    using static Pow2Data;

    using K = Pow2x64;
    
    /// <summary>
    /// Defines power-of-2 literals raning from 2^0 - 2^63
    /// </summary>
    [ApiHost]
    public static class Pow2    
    {                
        /// <summary>
        /// Computes 2^i where i is an integer value in the interval [0,63]
        /// </summary>
        /// <param name="i">The exponent</param>
        [MethodImpl(Inline), Op]
        public static ulong pow(byte i)
            =>  1ul << i; 

        /// <summary>
        /// Computes 2^i where i is an integer value in the interval [0,63]
        /// </summary>
        /// <param name="i">The exponent</param>
        [MethodImpl(Inline), Op]
        public static ulong pow(int i)
            =>  1ul << i; 

        [MethodImpl(Inline), Op]
        public static bool test(ulong src)
        {
            var x = src & (src-1);
            var a = x != 0 ? true : false;
            var b = src != 0 ? true : false;
            return b && !a;            
        }

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

        public const ulong T00m1 = T00 - 1;

        public const ulong T01m1 = T01 - 1;

        public const ulong T02m1 = T02 - 1;

        public const ulong T03m1 = T03 - 1;

        public const ulong T04m1 = T04 - 1;

        public const ulong T05m1 = T05 - 1;

        public const ulong T06m1 = T06 - 1;

        public const ulong T07m1 = T07 - 1;

        public const ulong T08m1 = T08 - 1;

        public const ulong T09m1 = T09 - 1;

        public const ulong T10m1 = T10 - 1;
        
        public const ulong T11m1 = T11 - 1;
        
        public const ulong T12m1 = T12 - 1;

        public const ulong T13m1 = T13 - 1;

        public const ulong T14m1 = T14 - 1;
        
        public const ulong T15m1 = T15 - 1;

        public const ulong T16m1 = T16 - 1;
        
        public const ulong T17m1 = T17 - 1;

        public const ulong T18m1 = T18 - 1;

        public const ulong T19m1 = T19 - 1;

        public const ulong T20m1 = T20 - 1;
        
        public const ulong T21m1 = T21 - 1;

        public const ulong T22m1 = T22 - 1;

        public const ulong T23m1 = T23 - 1;
        
        public const ulong T24m1 = T24 - 1;

        public const ulong T25m1 = T25 - 1;
        
        public const ulong T26m1 = T26 - 1;
        
        public const ulong T27m1 = T27 - 1;
        
        public const ulong T28m1 = T28 - 1;
        
        public const ulong T29m1 = T29 - 1;
        
        public const ulong T30m1 = T30 - 1;
        
        public const ulong T31m1 = int.MaxValue;

        public const uint T32m1 = uint.MaxValue; 
                                                         
        public const ulong T33m1 = T33 - 1;
        
        public const ulong T34m1 = T34 - 1;
        
        public const ulong T35m1 = T35 - 1;
        
        public const ulong T36m1 = T36 - 1;
        
        public const ulong T37m1 = T37 - 1;
        
        public const ulong T38m1 = T38 - 1;
        
        public const ulong T39m1 = T39 - 1;
        
        public const ulong T40m1 = T40 - 1;
        
        public const ulong T41m1 = T41 - 1;
        
        public const ulong T42m1 = T42 - 1;
        
        public const ulong T43m1 = T43 - 1;
        
        public const ulong T44m1 = T44 - 1;
        
        public const ulong T45m1 = T45 - 1;
        
        public const ulong T46m1 = T46 - 1;

        public const ulong T47m1 = T47 - 1;
        
        public const ulong T48m1 = T48 - 1;
        
        public const ulong T49m1 = T49 - 1;

        public const ulong T50m1 = T50 - 1;

        public const ulong T51m1 = T51 - 1;
                
        public const ulong T52m1 = T52 - 1;

        public const ulong T53m1 = T53 - 1;

        public const ulong T54m1 = T54 - 1;

        public const ulong T55m1 = T55 - 1;

        public const ulong T56m1 = T56 - 1;

        public const ulong T57m1 = T57 - 1;

        public const ulong T58m1 = T58 - 1;

        public const ulong T59m1 = T59 - 1;
        
        public const ulong T60m1 = T60 - 1;

        public const ulong T61m1 = T61 - 1;

        public const ulong T62m1 = T62 - 1;

        public const ulong T63m1 = long.MaxValue;

        public const ulong T64m1 = ulong.MaxValue;
    }
}