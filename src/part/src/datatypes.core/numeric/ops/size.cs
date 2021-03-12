//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Numeric
    {
        /// <summary>
        /// Determines the width of the represented kind in bytes
        /// </summary>
        /// <param name="k">The kind to examine</param>
        [MethodImpl(Inline), Op]
        public static ByteSize size(NumericKind k)
            => ((int)(ushort)k)/8;
    }
}