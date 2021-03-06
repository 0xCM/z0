//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Rules
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Field field(uint index, Identifier name, DataType type)
            => new Field(index,name,type);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Fork<C> fork<C>(C criterion)
            => new Fork<C>(criterion);
    }
}