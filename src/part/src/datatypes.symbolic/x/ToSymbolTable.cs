//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;

    partial class XTend
    {
        public static SymbolTable<E> ToSymbolTable<E>(this Index<Token<E>> src)
            where E : unmanaged, Enum
                => SymbolTables.create(src);
    }
}