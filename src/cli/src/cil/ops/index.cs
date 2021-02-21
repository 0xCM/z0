//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    public readonly partial struct Cil
    {
        [Op]
        public static RuntimeIndex index(Assembly src)
            => RuntimeIndex.create(src);
    }
}