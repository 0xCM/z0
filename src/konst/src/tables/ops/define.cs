//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;
    using static z;

    partial struct Table
    {
        [Op]
        public static TableDefinition define(Type t)
            => new TableDefinition(t, index(t));
    }
}