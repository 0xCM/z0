//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Expr
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct expr
    {
        public static LiteralSeq<E> literals<E>()
            where E : unmanaged, Enum
        {
            var src = Symbols.index<E>();
            var symbols = src.View;
            var count = symbols.Length;
            var dst = alloc<Literal<E>>(count);
            for(var i=0; i<count; i++)
            {
                ref readonly var s = ref skip(symbols, i);
                seek(dst,i) = literal<E>(s.Expr.Text, s.Kind);
            }
            return new LiteralSeq<E>(typeof(E).Name, dst);
        }
    }
}