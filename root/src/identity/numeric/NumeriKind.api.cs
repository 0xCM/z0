//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Numeric-kinded types
    /// </summary>
    public static class NKT
    {
        public static NumericTypeKind<byte> u8
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static NumericTypeKind<sbyte> i8
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static NumericTypeKind<ushort> u16
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static NumericTypeKind<short> i16
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static NumericTypeKind<uint> u32
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static NumericTypeKind<int> i32
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static NumericTypeKind<ulong> u64
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static NumericTypeKind<long> i64
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static NumericTypeKind<float> f32
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static NumericTypeKind<double> f64
        {
            [MethodImpl(Inline)]
            get => default;
        }
    }
}
