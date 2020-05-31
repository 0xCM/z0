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

    using NK = NumericKind;

    using static Seed;

    partial class NumericKinds
    {            
        /// <summary>
        /// Recognized unsigned integral types
        /// </summary>
        public static IEnumerable<Type> UnsignedTypes
            => seq(typeof(byte), typeof(ushort),  typeof(uint), typeof(ulong));

        /// <summary>
        /// Recognized unsigned integral kinds
        /// </summary>
        public static IEnumerable<NumericKind> UnsignedKindSeq
            => seq(NK.U8, NK.U16, NK.U32, NK.U64);

        /// <summary>
        /// Recognized signed integral kinds
        /// </summary>
        public static IEnumerable<Type> SignedTypes
            => seq(typeof(sbyte), typeof(short), typeof(int), typeof(long));
        
        /// <summary>
        /// Recognized signed integral kinds
        /// </summary>
        public static IEnumerable<NumericKind> SignedKindSeq
            => seq(NK.I8, NK.I16, NK.I32, NK.I64);

        /// <summary>
        /// Recognized integral types
        /// </summary>
        public static IEnumerable<Type> IntegralTypes
            => SignedTypes.Union(UnsignedTypes);

        /// <summary>
        /// Recognized integral kinds
        /// </summary>
        public static IEnumerable<NumericKind> IntegralKindSeq
            => UnsignedKindSeq.Union(SignedKindSeq);

        /// <summary>
        /// recognized floating-point types
        /// </summary>
        public static IEnumerable<Type> FloatingTypes
            => seq(typeof(float), typeof(double));

        /// <summary>
        /// Recognized floating-point kinds
        /// </summary>
        public static IEnumerable<NumericKind> FloatingKindSeq
            => seq(NK.F32, NK.F64);

        /// <summary>
        /// Recognized numeric types
        /// </summary>
        public static IEnumerable<Type> NumericTypes
            => IntegralTypes.Union(FloatingTypes);
    }
}