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
        public static bool contains<K>(Symbols<K> src, SymExpr expr)
            where K : unmanaged
        {
            var count = src.Count;
            var view = src.View;
            for(var i=0; i<count; i++)
                if(skip(view,i).Expression == expr)
                    return true;
            return false;
        }
    }
}