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
            return width != 0 ? width : default;
        }
    }
}