//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Symbols
    {
        public static Index<SymIndex> indices(Type[] src)
            => SymIndexBuilder.create(src);
    }
}