//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct Symbols
    {
        /// <summary>
        /// Extracts the symbol expressions from a source buffer and deposits them in a caller-supplied target
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        /// <typeparam name="T"></typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static uint expressions<T>(ReadOnlySpan<Sym<T>> src, Span<SymExpr> dst)
            where T : unmanaged
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var symbol = ref skip(src,i);
                seek(dst,i) = symbol.Expr;
            }
            return (uint)count;
        }
    }
}