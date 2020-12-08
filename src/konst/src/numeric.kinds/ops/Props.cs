//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    partial class NumericKinds
    {
        /// <summary>
        /// Specifies the int8 kind
        /// </summary>
        public static NK<sbyte> i8 => default;

        /// <summary>
        /// Specifies the uint8 kind
        /// </summary>
        public static NK<byte> u8 => default;

        /// <summary>
        /// Specifies the int16 kind
        /// </summary>
        public static NK<short> i16 => default;

        /// <summary>
        /// Specifies the uint16 kind
        /// </summary>
        public static NK<ushort> u16 => default;

        /// <summary>
        /// Specifies the int32 kind
        /// </summary>
        public static NK<int> i32 => default;

        /// <summary>
        /// Specifies the uint32 kind
        /// </summary>
        public static NK<uint> u32 => default;

        /// <summary>
        /// Specifies the int64 kind
        /// </summary>
        public static NK<long> i64 => default;

        /// <summary>
        /// Specifies the uint64 kind
        /// </summary>
        public static NK<ulong> u64 => default;

        /// <summary>
        /// Specifies the float32 kind
        /// </summary>
        public static NK<float> f32 => default;

        /// <summary>
        /// Specifies the float64 kind
        /// </summary>
        public static NK<double> f64 => default;

        /// <summary>
        /// Recognized integral types
        /// </summary>
        [Op]
        public static IEnumerable<Type> IntegralTypes()
            => SignedTypes().Union(UnsignedTypes());

        /// <summary>
        /// Recognized integral kinds
        /// </summary>
        [Op]
        public static IEnumerable<NumericKind> IntegralKindSeq()
            => UnsignedKinds().Union(SignedKinds());

        /// <summary>
        /// Recognized numeric types
        /// </summary>
        [Op]
        public static IEnumerable<Type> NumericTypes()
            => IntegralTypes().Union(FloatingTypes());
    }
}