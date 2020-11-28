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
        public static BitSpan32 concat(in BitSpan32 head, in BitSpan32 tail)
        {
            Span<Bit32> dst = new Bit32[head.Length + tail.Length];
            head.Data.CopyTo(dst);
            tail.Data.CopyTo(dst, head.Length);
            return BitSpans.load32(dst);
        }

        /// <summary>
        /// Forms the bitspan z := [head,tail] via concatentation
        /// </summary>
        /// <param name="head">The leading bits</param>
        /// <param name="tail">The trailing bits</param>
        [Op]
        public static BitSpan concat(in BitSpan head, in BitSpan tail)
        {
            Span<bit> dst = new bit[head.Length + tail.Length];
            head.Storage.CopyTo(dst);
            tail.Storage.CopyTo(dst, head.Length);
            return BitSpans.load(dst);
        }
    }
}