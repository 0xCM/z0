//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    
    using static Konst;
    using static Pow2;

    public readonly struct Pow2Data
    {
        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> slice(int log2Idx)
            => Pow2Bytes.Slice(log2Idx*8,8);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> slice(int log2IdxFirst, int log2IdxLast)
            => Pow2Bytes.Slice(log2IdxFirst*8, (log2IdxLast - log2IdxFirst)*8);

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
    }
}