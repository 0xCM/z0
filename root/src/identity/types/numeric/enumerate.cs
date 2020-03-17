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

    using static Root;

    using NK = NumericKind;

    partial class Numeric
    {
        /// <summary>
        /// Recognized unsigned integral types
        /// </summary>
        public static IEnumerable<Type> UnsignedIntegralTypes
            => items(typeof(byte), typeof(ushort),  typeof(uint), typeof(ulong));

        /// <summary>
        /// Recognized unsigned integral kinds
        /// </summary>
        public static IEnumerable<NumericKind> UnsignedIntegralKinds
            => items(NK.U8, NK.U16, NK.U32, NK.U64);

        /// <summary>
        /// Recognized signed integral kinds
        /// </summary>
        public static IEnumerable<Type> SignedIntegralTypes
            => items(typeof(sbyte), typeof(short), typeof(int), typeof(long));
        
        /// <summary>
        /// Recognized signed integral kinds
        /// </summary>
        public static IEnumerable<NumericKind> SignedIntegralKinds
            => items(NK.I8, NK.I16, NK.I32, NK.I64);

        /// <summary>
        /// Recognized integral types
        /// </summary>
        public static IEnumerable<Type> IntegralTypes
            => SignedIntegralTypes.Union(UnsignedIntegralTypes);

        /// <summary>
        /// Recognized integral kinds
        /// </summary>
        public static IEnumerable<NumericKind> IntegralKinds
            => UnsignedIntegralKinds.Union(SignedIntegralKinds);

        /// <summary>
        /// recognized floating-point types
        /// </summary>
        public static IEnumerable<Type> FloatTypes
            => items(typeof(float), typeof(double));

        /// <summary>
        /// Recognized floating-point kinds
        /// </summary>
        public static IEnumerable<NumericKind> FloatKinds
            => items(NK.F32, NK.F64);

        /// <summary>
        /// Recognized numeric types
        /// </summary>
        public static IEnumerable<Type> Types
            => IntegralTypes.Union(FloatTypes);

        /// <summary>
        /// Recognized numeric kinds
        /// </summary>
        public static IEnumerable<NumericKind> Kinds
            => IntegralKinds.Union(FloatKinds);
    }
}