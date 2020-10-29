//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class XApiIdentity
    {
        /// <summary>
        /// Produces a canonical text representation of the source kind
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline)]
        public static string Format(this CellWidth src)
            => $"{(int)src}";
    }
}