//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    using static Pow2;

    public static class Pow2M1    
    {                
        [MethodImpl(Inline)]
        public static int Lookup32i(int index)
            => Bytes32i.Slice(index*4,4).TakeInt32();

        [MethodImpl(Inline)]
        public static int Lookup32u(int index)
            => Bytes32u.Slice(index*4,4).TakeInt32();

        [MethodImpl(Inline)]
        public static ulong Lookup64u(int index)
            => Bytes64u.Slice(index*8,8).TakeUInt64();

        [MethodImpl(Inline)]
        public static long Lookup64i(int index)
            => Bytes64u.Slice(index*8,8).TakeInt64();

        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> Data32i(int index)
            => Bytes32i.Slice(index*4,4);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> Data32u(int index)
            => Bytes32u.Slice(index*4,4);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> Data64i(int index)
            => Bytes64i.Slice(index*8,8);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> Data64u(int index)
            => Bytes64u.Slice(index*8,8);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> Data32i(int i0, int i1)
            => Bytes32i.Slice(i0*4, (i1 - i0)*4);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> Data32u(int i0, int i1)
            => Bytes32u.Slice(i0*4, (i1 - i0)*4);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> Data64i(int i0, int i1)
            => Bytes64i.Slice(i0*8, (i1 - i0)*8);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> Data64u(int i0, int i1)
            => Bytes64u.Slice(i0*8, (i1 - i0)*8);

        public static IEnumerable<(int i, ulong vallue)> All
            => typeof(Pow2M1).LiteralValues<ulong>();

        [MethodImpl(Inline)]
        public static IEnumerable<(int i, T value)> Values<T>()
            where T : unmanaged
                => values_u<T>();

        [MethodImpl(Inline)]
        static IEnumerable<(int,T)> values_u<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))                
                return typeof(Pow2M1).LiteralValues<T>(8);
            else if(typeof(T) == typeof(ushort))                
                return typeof(Pow2M1).LiteralValues<T>(16);
            else if(typeof(T) == typeof(uint))                
                return typeof(Pow2M1).LiteralValues<T>(33);
            else if(typeof(T) == typeof(ulong))
                return typeof(Pow2M1).LiteralValues<T>(64);
            else
                return values_i<T>();
        }

        [MethodImpl(Inline)]
        static IEnumerable<(int,T)> values_i<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))                
                return typeof(Pow2M1).LiteralValues<T>(7);
            else if(typeof(T) == typeof(short))                
                return typeof(Pow2M1).LiteralValues<T>(15);
            else if(typeof(T) == typeof(int))                
                return typeof(Pow2M1).LiteralValues<T>(32);
            else if(typeof(T) == typeof(long))                
                return typeof(Pow2M1).LiteralValues<T>(63);
            else
                throw unsupported<T>();
        }

        public const ulong P2M1_00 = T00 - 1;

        public const ulong P2M1_01 = T01 - 1;

        public const ulong P2M1_02 = T02 - 1;

        public const ulong P2M1_03 = T03 - 1;

        public const ulong P2M1_04 = T04 - 1;

        public const ulong P2M1_05 = T05 - 1;

        public const ulong P2M1_06 = T06 - 1;

        public const ulong P2M1_07 = T07 - 1;

        public const ulong P2M1_08 = T08 - 1;

        public const ulong P2M1_09 = T09 - 1;

        public const ulong P2M1_10 = T10 - 1;
        
        public const ulong P2M1_11 = T11 - 1;
        
        public const ulong P2M1_12 = T12 - 1;

        public const ulong P2M1_13 = T13 - 1;

        public const ulong P2M1_14 = T14 - 1;
        
        public const ulong P2M1_15 = T15 - 1;

        public const ulong P2M1_16 = T16 - 1;
        
        public const ulong P2M1_17 = T17 - 1;

        public const ulong P2M1_18 = T18 - 1;

        public const ulong P2M1_19 = T19 - 1;

        public const ulong P2M1_20 = T20 - 1;
        
        public const ulong P2M1_21 = T21 - 1;

        public const ulong P2M1_22 = T22 - 1;

        public const ulong P2M1_23 = T23 - 1;
        
        public const ulong P2M1_24 = T24 - 1;

        public const ulong P2M1_25 = T25 - 1;
        
        public const ulong P2M1_26 = T26 - 1;
        
        public const ulong P2M1_27 = T27 - 1;
        
        public const ulong P2M1_28 = T28 - 1;
        
        public const ulong P2M1_29 = T29 - 1;
        
        public const ulong P2M1_30 = T30 - 1;
        
        public const ulong P2M1_31 = int.MaxValue;

        public const uint P2M1_32 = uint.MaxValue; 
                                                         
        public const ulong P2M1_33 = T33 - 1;
        
        public const ulong P2M1_34 = T34 - 1;
        
        public const ulong P2M1_35 = T35 - 1;
        
        public const ulong P2M1_36 = T36 - 1;
        
        public const ulong P2M1_37 = T37 - 1;
        
        public const ulong P2M1_38 = T38 - 1;
        
        public const ulong P2M1_39 = T39 - 1;
        
        public const ulong P2M1_40 = T40 - 1;
        
        public const ulong P2M1_41 = T41 - 1;
        
        public const ulong P2M1_42 = T42 - 1;
        
        public const ulong P2M1_43 = T43 - 1;
        
        public const ulong P2M1_44 = T44 - 1;
        
        public const ulong P2M1_45 = T45 - 1;
        
        public const ulong P2M1_46 = T46 - 1;

        public const ulong P2M1_47 = T47 - 1;
        
        public const ulong P2M1_48 = T48 - 1;
        
        public const ulong P2M1_49 = T49 - 1;

        public const ulong P2M1_50 = T50 - 1;

        public const ulong P2M1_51 = T51 - 1;
                
        public const ulong P2M1_52 = T52 - 1;

        public const ulong P2M1_53 = T53 - 1;

        public const ulong P2M1_54 = T54 - 1;

        public const ulong P2M1_55 = T55 - 1;

        public const ulong P2M1_56 = T56 - 1;

        public const ulong P2M1_57 = T57 - 1;

        public const ulong P2M1_58 = T58 - 1;

        public const ulong P2M1_59 = T59 - 1;
        
        public const ulong P2M1_60 = T60 - 1;

        public const ulong P2M1_61 = T61 - 1;

        public const ulong P2M1_62 = T62 - 1;

        public const ulong P2M1_63 = long.MaxValue;

        public const ulong P2M1_64 = ulong.MaxValue;



        static ReadOnlySpan<byte> Bytes32i => new byte[]
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

        static ReadOnlySpan<byte> Bytes32u => new byte[]
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

        static ReadOnlySpan<byte> Bytes64i => new byte[]
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

        static ReadOnlySpan<byte> Bytes64u => new byte[]
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