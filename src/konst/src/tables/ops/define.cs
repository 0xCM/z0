//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial struct Table
    {
        [Op]
        public static TableDefinition define(Type t)
            => new TableDefinition(t, index(t));
    }
}