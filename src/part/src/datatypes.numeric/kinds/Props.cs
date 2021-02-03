//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    partial class NumericKinds
    {
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