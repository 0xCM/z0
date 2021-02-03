//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct lang
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SyntaxSymbol<K> symbol<K>(uint order, K kind, string name, string desc = EmptyString)
            where K : unmanaged
                => new SyntaxSymbol<K>(order, kind, name, desc);
    }
}