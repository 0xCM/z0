//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using NK = NumericKind;

    [ApiHost]
    public partial class NumericKinds
    {
        /// <summary>
        /// Recognized unsigned integral types
        /// </summary>
        [Op]
        public static Type[] UnsignedTypes()
            => root.array(typeof(byte), typeof(ushort),  typeof(uint), typeof(ulong));

        /// <summary>
        /// Recognized unsigned integral kinds
        /// </summary>
        [Op]
        public static NumericKind[] UnsignedKinds()
            => root.array(NK.U8, NK.U16, NK.U32, NK.U64);

         /// <summary>
        /// Recognized signed integral kinds
        /// </summary>
        [Op]
        public static Type[] SignedTypes()
            => memory.array(typeof(sbyte), typeof(short), typeof(int), typeof(long));

        /// <summary>
        /// Recognized signed integral kinds
        /// </summary>
        [Op]
        public static NumericKind[] SignedKinds()
            => memory.array(NK.I8, NK.I16, NK.I32, NK.I64);

        /// <summary>
        /// recognized floating-point types
        /// </summary>
        [Op]
        public static Type[] FloatingTypes()
            => root.array(typeof(float), typeof(double));

        /// <summary>
        /// Recognized floating-point kinds
        /// </summary>
        [Op]
        public static NumericKind[] FloatingKinds()
           => root.array(NK.F32, NK.F64);

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
        public static NumericKind[] IntegralKindSeq()
            => UnsignedKinds().Union(SignedKinds()).Array();

        /// <summary>
        /// Recognized numeric types
        /// </summary>
        [Op]
        public static Type[] NumericTypes()
            => IntegralTypes().Union(FloatingTypes()).Array();
    }
}