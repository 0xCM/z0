//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class BitSpans
    {
        /// <summary>
        /// Creates a bitspan from a parameter array
        /// </summary>
        /// <param name="src">The sorce bits</param>
        [MethodImpl(Inline), Op]
        public static BitSpan parts(params Bit32[] src)
            => new BitSpan(src);
    }
}