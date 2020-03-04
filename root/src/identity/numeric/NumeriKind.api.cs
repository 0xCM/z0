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
        public static NumericType<byte> u8
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static NumericType<sbyte> i8
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static NumericType<ushort> u16
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static NumericType<short> i16
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static NumericType<uint> u32
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static NumericType<int> i32
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static NumericType<ulong> u64
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static NumericType<long> i64
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static NumericType<float> f32
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static NumericType<double> f64
        {
            [MethodImpl(Inline)]
            get => default;
        }
    }
}
