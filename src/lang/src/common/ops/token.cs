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
        public static SyntaxToken<K> token<K>(string symbol, K kind, string desc = EmptyString)
            where K : unmanaged
                => new SyntaxToken<K>(symbol, kind, desc);
    }
}