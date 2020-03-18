//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class RootNumericOps
    {
        /// <summary>
        /// Determines the width of the represented kind in bits
        /// </summary>
        /// <param name="k">The kind to examine</param>
        [MethodImpl(Inline), Op]
        public static int? Width(this NumericClass k)
            => NumericClasses.width(k);

        /// <summary>
        /// Returns true if the classifier is equivalent to an identity
        /// </summary>
        /// <param name="k">The class to query</param>
        /// <param name="id">The identity to match</param>
        [MethodImpl(Inline), Op]
        public static bool Identifies(this NumericClass k, NumericClassId id)
            => NumericClasses.identifies(id,k);

        /// <summary>
        /// Determines the width of the represented kind in bits
        /// </summary>
        /// <param name="k">The kind to examine</param>
        [MethodImpl(Inline), Op]
        public static Type ClassfiedType(this NumericClass k)
            => NumericClasses.classified(k);

        /// <summary>
        /// Returns true if the classifier is equivalent to an identity
        /// </summary>
        /// <param name="k">The class to query</param>
        /// <param name="id">The identity to match</param>
        [MethodImpl(Inline), Op]
        public static NumericIndicator Indicator(this NumericClass k)
            => NumericClasses.indicator(k);

        public static NumericKind ToNumericKind(this NumericClass k)            
            =>  NumericClasses.classified(k).NumericKind();

    }
}