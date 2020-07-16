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
        /// Forms the bitspan z := [head,tail] via concatentation
        /// </summary>
        /// <param name="head">The leading bits</param>
        /// <param name="tail">The trailing bits</param>
        [Op]
        public static BitSpan concat(in BitSpan head, in BitSpan tail)
        {
            Span<bit> dst = new bit[head.Length + tail.Length];
            head.Data.CopyTo(dst);
            tail.Data.CopyTo(dst, head.Length);
            return BitSpans.load(dst);
        }
    }
}