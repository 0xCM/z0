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
        {
            var width =  (int)(k & NumericClass.Widths);
            return width == 8  || width == 16 | width == 32 | width == 64 ? width : (int?)null;
        }

        /// <summary>
        /// Returns true if the classifier is equivalent to an identity
        /// </summary>
        /// <param name="k">The class to query</param>
        /// <param name="id">The identity to match</param>
        [MethodImpl(Inline), Op]
        public static bool Identifies(this NumericClass k, NumericTypeId id)
            => ((uint)k & (uint)id) == (uint)id;
    }
}