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
        [Op, Closures(UnsignedInts)]
        public static bool match<K>(Symbols<K> src, SymExpr expr, out Sym<K> dst)
            where K : unmanaged
        {
            var count = src.Count;
            var view = src.View;
            for(var i=0; i<count; i++)
            {
                ref readonly var sym = ref skip(view,i);
                if(sym.Expression == expr)
                {
                    dst = sym;
                    return true;
                }

            }
            dst = Sym<K>.Empty;
            return false;
        }
    }
}