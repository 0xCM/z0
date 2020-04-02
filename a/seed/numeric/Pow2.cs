//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;
    
    using static Seed;
    
    /// <summary>
    /// Defines power-of-2 literals raning from 2^0 - 2^63
    /// </summary>
    public static class Pow2    
    {                
        /// <summary>
        /// Computes 2^i where i is an integer value in the interval [0,63]
        /// </summary>
        /// <param name="i">The exponent</param>
        [MethodImpl(Inline)]
        public static ulong pow(byte i)
            =>  1ul << i; 

        /// <summary>
        /// Computes 2^i where i is an integer value in the interval [0,63]
        /// </summary>
        /// <param name="i">The exponent</param>
        [MethodImpl(Inline)]
        public static ulong pow(int i)
            =>  1ul << i; 

        /// <summary>
        /// 2^0 = 1
        /// </summary>
        public const int T00 = 1;

        /// <summary>
        /// 2^1 = 2
        /// </summary>
        public const int T01 = 2*T00;

        /// <summary>
        /// 2^2 = 4
        /// </summary>
        public const int T02 = 2*T01;

        /// <summary>
        /// 2^3 = 8
        /// </summary>
        public const int T03 = 2*T02;

        /// <summary>
        /// 2^4 = 16
        /// </summary>
        public const int T04 = 2*T03;

        /// <summary>
        /// 2^5 = 32
        /// </summary>
        public const int T05 = 2*T04;

        /// <summary>
        /// 2^6 = 64
        /// </summary>
        public const int T06 = 2*T05;

        /// <summary>
        /// 2^7 = 128
        /// </summary>
        public const int T07 = 2*T06;

        /// <summary>
        /// 2^8 = 256 = UInt8.MaxValue + 1
        /// </summary>
        public const int T08 = 2*T07;

        /// <summary>
        /// 2^9 = 512
        /// </summary>
        public const int T09 = 2*T08;

        /// <summary>
        /// 2^10 = 1024
        /// </summary>
        public const int T10 = 2*T09;
        
        /// <summary>
        /// 2^11 = 2048
        /// </summary>
        public const int T11 = 2*T10;
        
        /// <summary>
        /// 2^12 = 4096
        /// </summary>
        public const int T12 = 2*T11;

        /// <summary>
        /// 2^13 = 8192
        /// </summary>
        public const int T13 = 2*T12;

        /// <summary>
        /// 2^14 = 16,384
        /// </summary>
        public const int T14 = 2*T13;
        
        /// <summary>
        /// 2^15 = 32,768
        /// </summary>
        public const int T15 = 2*T14;

        /// <summary>
        /// 2^16 = 65,536 = UInt16.MaxValue + 1
        /// </summary>
        public const int T16 = 2*T15;
        
        /// <summary>
        /// 2^17 = 131,072
        /// </summary>
        public const int T17 = 2*T16;

        /// <summary>
        /// 2^18 = 262,144
        /// </summary>
        public const int T18 = 2*T17;

        /// <summary>
        /// 2^19 = 524,288
        /// </summary>
        public const int T19 = 2*T18;

        /// <summary>
        /// 2^20 = 1,048,576
        /// </summary>
        public const int T20 = 2*T19;
        
        /// <summary>
        /// 2^21 = 2,097,152
        /// </summary>
        public const int T21 = 2*T20;

        /// <summary>
        /// 2^22 = 4,194,304
        /// </summary>
        public const int T22 = 2*T21;

        /// <summary>
        /// 2^23 = 8,388,608
        /// </summary>
        public const int T23 = 2*T22;
        
        /// <summary>
        /// 2^24 = 16,777,216
        /// </summary>
        public const int T24 = 2*T23;

        /// <summary>
        /// 2^25 = 33,554,432
        /// </summary>
        public const int T25 = 2*T24;
        
        /// <summary>
        /// 2^26 = 67,108,864 = 0x4000000
        /// </summary>
        public const int T26 = 2*T25;
        
        /// <summary>
        /// 2^27 = 134,217,728 = 0x8000000
        /// </summary>
        public const int T27 = 2*T26;
        
        /// <summary>
        /// 2^28 = 268,435,456 = 0x10000000
        /// </summary>
        public const int T28 = 2*T27;
        
        /// <summary>
        /// 2^29 = 536,870,912 = 0x20000000;
        /// </summary>
        public const int T29 = 2*T28;
        
        /// <summary>
        /// 2^30 = 1,073,741,824 = 0x40000000
        /// </summary>
        public const int T30 = 2*T29;

        /// <summary>
        /// 2^31 = 2,147,483,648 = 0x80000000
        /// </summary>
        public const uint T31 = 2*(uint)T30;

        /// <summary>
        /// 2^32 = 4,294,967,296 = 0x100000000
        /// </summary>
        public const long T32 = 2*(long)T31;
                                                         
        public const long T33 = 2*T32;
        
        public const long T34 = 2*T33;
        
        public const long T35 = 2*T34;
        
        public const long T36 = 2*T35;
        
        public const long T37 = 2*T36;
        
        public const long T38 = 2*T37;
        
        public const long T39 = 2*T38;
        
        public const long T40 = 2*T39;
        
        public const long T41 = 2*T40;
        
        public const long T42 = 2*T41;
        
        public const long T43 = 2*T42;
        
        public const long T44 = 2*T43;
        
        public const long T45 = 2*T44;
        
        public const long T46 = 2*T45;

        public const long T47 = 2*T46;
        
        public const long T48 = 2*T47;
        
        public const long T49 = 2*T48;

        public const long T50 = 2*T49;

        public const long T51 = 2*T50;
                
        public const long T52 = 2*T51;

        public const long T53 = 2*T52;

        public const long T54 = 2*T53;

        public const long T55 = 2*T54;

        public const long T56 = 2*T55;

        public const long T57 = 2*T56;

        public const long T58 = 2*T57;

        public const long T59 = 2*T58;
        
        public const long T60 = 2*T59;

        public const long T61 = 2*T60;

        public const long T62 = 2*T61;        

        /// <summary>
        /// T63 = 9223372036854775808 
        /// </summary>
        public const ulong T63 = 2*(ulong)T62;        

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


        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> slice(int log2Idx)
            => Pow2Bytes.Slice(log2Idx*8,8);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> slice(int log2IdxFirst, int log2IdxLast)
            => Pow2Bytes.Slice(log2IdxFirst*8, (log2IdxLast - log2IdxFirst)*8);

        static ReadOnlySpan<byte> Pow2Bytes => new byte[]
        {
            0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x04, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x08, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x10, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x20, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x40, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x80, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x04, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x08, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x10, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x20, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x40, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x80, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x04, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x08, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x10, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x20, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x40, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x80, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x02, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x04, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x08, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x10, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x20, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x40, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x80, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x02, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x04, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x08, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x10, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x20, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x40, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x80, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x02, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x04, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x08, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x10, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x20, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x40, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x80, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x02, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x04, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x08, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x10, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x20, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x40, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x80, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x02,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x04,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x08,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x10,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x20,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x40,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x80,            
        };

        // [MethodImpl(Inline)]
        // public static int i32M1(int index)
        //     => M1Bytes32i.Slice(index*4,4).TakeInt32();

        // [MethodImpl(Inline)]
        // public static int u32M1(int index)
        //     => M1Bytes32u.Slice(index*4,4).TakeInt32();

        // [MethodImpl(Inline)]
        // public static ulong u64M1(int index)
        //     => M1Bytes64u.Slice(index*8,8).TakeUInt64();

        // [MethodImpl(Inline)]
        // public static long i64M1(int index)
        //     => M1Bytes64u.Slice(index*8,8).TakeInt64();

        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> slice32iM1(int index)
            => M1Bytes32i.Slice(index*4,4);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> slice32uM1(int index)
            => M1Bytes32u.Slice(index*4,4);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> slice64iM1(int index)
            => M1Bytes64i.Slice(index*8,8);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> slice64uM1(int index)
            => M1Bytes64u.Slice(index*8,8);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> slice32iM1(int i0, int i1)
            => M1Bytes32i.Slice(i0*4, (i1 - i0)*4);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> slice32uM1(int i0, int i1)
            => M1Bytes32u.Slice(i0*4, (i1 - i0)*4);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> slice64iM1(int i0, int i1)
            => M1Bytes64i.Slice(i0*8, (i1 - i0)*8);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> slice64uM1(int i0, int i1)
            => M1Bytes64u.Slice(i0*8, (i1 - i0)*8);

        const string M1FieldFilter = "m1";

        public static IEnumerable<(int i, ulong vallue)> M1Values
            => typeof(Pow2).LiteralValueIndex<ulong>(M1FieldFilter);

        [MethodImpl(Inline)]
        public static IEnumerable<(int i, T value)> m1Values<T>()
            where T : unmanaged
                => values_m1_u<T>();

        [MethodImpl(Inline)]
        static IEnumerable<(int,T)> values_m1_u<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))                
                return typeof(Pow2).LiteralValueIndex<T>(M1FieldFilter, 8);
            else if(typeof(T) == typeof(ushort))                
                return typeof(Pow2).LiteralValueIndex<T>(M1FieldFilter, 16);
            else if(typeof(T) == typeof(uint))                
                return typeof(Pow2).LiteralValueIndex<T>(M1FieldFilter, 33);
            else if(typeof(T) == typeof(ulong))
                return typeof(Pow2).LiteralValueIndex<T>(M1FieldFilter, 64);
            else
                return values_m1_i<T>();
        }

        [MethodImpl(Inline)]
        static IEnumerable<(int,T)> values_m1_i<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))                
                return typeof(Pow2).LiteralValueIndex<T>(M1FieldFilter, 7);
            else if(typeof(T) == typeof(short))                
                return typeof(Pow2).LiteralValueIndex<T>(M1FieldFilter, 15);
            else if(typeof(T) == typeof(int))                
                return typeof(Pow2).LiteralValueIndex<T>(M1FieldFilter, 32);
            else if(typeof(T) == typeof(long))                
                return typeof(Pow2).LiteralValueIndex<T>(M1FieldFilter, 63);
            else
                throw new Exception("");
        }

        static ReadOnlySpan<byte> M1Bytes32i => new byte[]
        {
            0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00,
            0x03, 0x00, 0x00, 0x00, 0x07, 0x00, 0x00, 0x00,
            0x0f, 0x00, 0x00, 0x00, 0x1f, 0x00, 0x00, 0x00,
            0x3f, 0x00, 0x00, 0x00, 0x7f, 0x00, 0x00, 0x00,
            0xff, 0x00, 0x00, 0x00, 0xff, 0x01, 0x00, 0x00,
            0xff, 0x03, 0x00, 0x00, 0xff, 0x07, 0x00, 0x00,
            0xff, 0x0f, 0x00, 0x00, 0xff, 0x1f, 0x00, 0x00,
            0xff, 0x3f, 0x00, 0x00, 0xff, 0x7f, 0x00, 0x00,
            0xff, 0xff, 0x00, 0x00, 0xff, 0xff, 0x01, 0x00,
            0xff, 0xff, 0x03, 0x00, 0xff, 0xff, 0x07, 0x00,
            0xff, 0xff, 0x0f, 0x00, 0xff, 0xff, 0x1f, 0x00,
            0xff, 0xff, 0x3f, 0x00, 0xff, 0xff, 0x7f, 0x00,
            0xff, 0xff, 0xff, 0x00, 0xff, 0xff, 0xff, 0x01,
            0xff, 0xff, 0xff, 0x03, 0xff, 0xff, 0xff, 0x07,
            0xff, 0xff, 0xff, 0x0f, 0xff, 0xff, 0xff, 0x1f,
            0xff, 0xff, 0xff, 0x3f, 0xff, 0xff, 0xff, 0x7f,            
        };

        static ReadOnlySpan<byte> M1Bytes32u => new byte[]
        {
            0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00,
            0x03, 0x00, 0x00, 0x00, 0x07, 0x00, 0x00, 0x00,
            0x0f, 0x00, 0x00, 0x00, 0x1f, 0x00, 0x00, 0x00,
            0x3f, 0x00, 0x00, 0x00, 0x7f, 0x00, 0x00, 0x00,
            0xff, 0x00, 0x00, 0x00, 0xff, 0x01, 0x00, 0x00,
            0xff, 0x03, 0x00, 0x00, 0xff, 0x07, 0x00, 0x00,
            0xff, 0x0f, 0x00, 0x00, 0xff, 0x1f, 0x00, 0x00,
            0xff, 0x3f, 0x00, 0x00, 0xff, 0x7f, 0x00, 0x00,
            0xff, 0xff, 0x00, 0x00, 0xff, 0xff, 0x01, 0x00,
            0xff, 0xff, 0x03, 0x00, 0xff, 0xff, 0x07, 0x00,
            0xff, 0xff, 0x0f, 0x00, 0xff, 0xff, 0x1f, 0x00,
            0xff, 0xff, 0x3f, 0x00, 0xff, 0xff, 0x7f, 0x00,
            0xff, 0xff, 0xff, 0x00, 0xff, 0xff, 0xff, 0x01,
            0xff, 0xff, 0xff, 0x03, 0xff, 0xff, 0xff, 0x07,
            0xff, 0xff, 0xff, 0x0f, 0xff, 0xff, 0xff, 0x1f,
            0xff, 0xff, 0xff, 0x3f, 0xff, 0xff, 0xff, 0x7f,
            0xff, 0xff, 0xff, 0xff,
        };

        static ReadOnlySpan<byte> M1Bytes64i => new byte[]
        {
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x03, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x07, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x0f, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x1f, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x3f, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x7f, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0xff, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0xff, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0xff, 0x03, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0xff, 0x07, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0xff, 0x0f, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0xff, 0x1f, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0xff, 0x3f, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0xff, 0x7f, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0xff, 0xff, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0xff, 0xff, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00,
            0xff, 0xff, 0x03, 0x00, 0x00, 0x00, 0x00, 0x00,
            0xff, 0xff, 0x07, 0x00, 0x00, 0x00, 0x00, 0x00,
            0xff, 0xff, 0x0f, 0x00, 0x00, 0x00, 0x00, 0x00,
            0xff, 0xff, 0x1f, 0x00, 0x00, 0x00, 0x00, 0x00,
            0xff, 0xff, 0x3f, 0x00, 0x00, 0x00, 0x00, 0x00,
            0xff, 0xff, 0x7f, 0x00, 0x00, 0x00, 0x00, 0x00,
            0xff, 0xff, 0xff, 0x00, 0x00, 0x00, 0x00, 0x00,
            0xff, 0xff, 0xff, 0x01, 0x00, 0x00, 0x00, 0x00,
            0xff, 0xff, 0xff, 0x03, 0x00, 0x00, 0x00, 0x00,
            0xff, 0xff, 0xff, 0x07, 0x00, 0x00, 0x00, 0x00,
            0xff, 0xff, 0xff, 0x0f, 0x00, 0x00, 0x00, 0x00,
            0xff, 0xff, 0xff, 0x1f, 0x00, 0x00, 0x00, 0x00,
            0xff, 0xff, 0xff, 0x3f, 0x00, 0x00, 0x00, 0x00,
            0xff, 0xff, 0xff, 0x7f, 0x00, 0x00, 0x00, 0x00,
            0xff, 0xff, 0xff, 0xff, 0x00, 0x00, 0x00, 0x00,
            0xff, 0xff, 0xff, 0xff, 0x01, 0x00, 0x00, 0x00,
            0xff, 0xff, 0xff, 0xff, 0x03, 0x00, 0x00, 0x00,
            0xff, 0xff, 0xff, 0xff, 0x07, 0x00, 0x00, 0x00,
            0xff, 0xff, 0xff, 0xff, 0x0f, 0x00, 0x00, 0x00,
            0xff, 0xff, 0xff, 0xff, 0x1f, 0x00, 0x00, 0x00,
            0xff, 0xff, 0xff, 0xff, 0x3f, 0x00, 0x00, 0x00,
            0xff, 0xff, 0xff, 0xff, 0x7f, 0x00, 0x00, 0x00,
            0xff, 0xff, 0xff, 0xff, 0xff, 0x00, 0x00, 0x00,
            0xff, 0xff, 0xff, 0xff, 0xff, 0x01, 0x00, 0x00,
            0xff, 0xff, 0xff, 0xff, 0xff, 0x03, 0x00, 0x00,
            0xff, 0xff, 0xff, 0xff, 0xff, 0x07, 0x00, 0x00,
            0xff, 0xff, 0xff, 0xff, 0xff, 0x0f, 0x00, 0x00,
            0xff, 0xff, 0xff, 0xff, 0xff, 0x1f, 0x00, 0x00,
            0xff, 0xff, 0xff, 0xff, 0xff, 0x3f, 0x00, 0x00,
            0xff, 0xff, 0xff, 0xff, 0xff, 0x7f, 0x00, 0x00,
            0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x00, 0x00,
            0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x01, 0x00,
            0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x03, 0x00,
            0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x07, 0x00,
            0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x0f, 0x00,
            0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x1f, 0x00,
            0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x3f, 0x00,
            0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x7f, 0x00,
            0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x00,
            0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x01,
            0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x03,
            0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x07,
            0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x0f,
            0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x1f,
            0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x3f,
            
        };

        static ReadOnlySpan<byte> M1Bytes64u => new byte[]
        {
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x03, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x07, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x0f, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x1f, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x3f, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x7f, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0xff, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0xff, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0xff, 0x03, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0xff, 0x07, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0xff, 0x0f, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0xff, 0x1f, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0xff, 0x3f, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0xff, 0x7f, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0xff, 0xff, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0xff, 0xff, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00,
            0xff, 0xff, 0x03, 0x00, 0x00, 0x00, 0x00, 0x00,
            0xff, 0xff, 0x07, 0x00, 0x00, 0x00, 0x00, 0x00,
            0xff, 0xff, 0x0f, 0x00, 0x00, 0x00, 0x00, 0x00,
            0xff, 0xff, 0x1f, 0x00, 0x00, 0x00, 0x00, 0x00,
            0xff, 0xff, 0x3f, 0x00, 0x00, 0x00, 0x00, 0x00,
            0xff, 0xff, 0x7f, 0x00, 0x00, 0x00, 0x00, 0x00,
            0xff, 0xff, 0xff, 0x00, 0x00, 0x00, 0x00, 0x00,
            0xff, 0xff, 0xff, 0x01, 0x00, 0x00, 0x00, 0x00,
            0xff, 0xff, 0xff, 0x03, 0x00, 0x00, 0x00, 0x00,
            0xff, 0xff, 0xff, 0x07, 0x00, 0x00, 0x00, 0x00,
            0xff, 0xff, 0xff, 0x0f, 0x00, 0x00, 0x00, 0x00,
            0xff, 0xff, 0xff, 0x1f, 0x00, 0x00, 0x00, 0x00,
            0xff, 0xff, 0xff, 0x3f, 0x00, 0x00, 0x00, 0x00,
            0xff, 0xff, 0xff, 0x7f, 0x00, 0x00, 0x00, 0x00,
            0xff, 0xff, 0xff, 0xff, 0x00, 0x00, 0x00, 0x00,
            0xff, 0xff, 0xff, 0xff, 0x01, 0x00, 0x00, 0x00,
            0xff, 0xff, 0xff, 0xff, 0x03, 0x00, 0x00, 0x00,
            0xff, 0xff, 0xff, 0xff, 0x07, 0x00, 0x00, 0x00,
            0xff, 0xff, 0xff, 0xff, 0x0f, 0x00, 0x00, 0x00,
            0xff, 0xff, 0xff, 0xff, 0x1f, 0x00, 0x00, 0x00,
            0xff, 0xff, 0xff, 0xff, 0x3f, 0x00, 0x00, 0x00,
            0xff, 0xff, 0xff, 0xff, 0x7f, 0x00, 0x00, 0x00,
            0xff, 0xff, 0xff, 0xff, 0xff, 0x00, 0x00, 0x00,
            0xff, 0xff, 0xff, 0xff, 0xff, 0x01, 0x00, 0x00,
            0xff, 0xff, 0xff, 0xff, 0xff, 0x03, 0x00, 0x00,
            0xff, 0xff, 0xff, 0xff, 0xff, 0x07, 0x00, 0x00,
            0xff, 0xff, 0xff, 0xff, 0xff, 0x0f, 0x00, 0x00,
            0xff, 0xff, 0xff, 0xff, 0xff, 0x1f, 0x00, 0x00,
            0xff, 0xff, 0xff, 0xff, 0xff, 0x3f, 0x00, 0x00,
            0xff, 0xff, 0xff, 0xff, 0xff, 0x7f, 0x00, 0x00,
            0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x00, 0x00,
            0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x01, 0x00,
            0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x03, 0x00,
            0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x07, 0x00,
            0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x0f, 0x00,
            0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x1f, 0x00,
            0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x3f, 0x00,
            0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x7f, 0x00,
            0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x00,
            0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x01,
            0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x03,
            0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x07,
            0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x0f,
            0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x1f,
            0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x3f,
            0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x7f,
            0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,            
        };         
    }
}