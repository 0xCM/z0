//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;
    using System.Reflection;

    using static memory;

    public readonly struct MsilServices
    {
        [Op]
        public static RuntimeIndex index(Assembly src)
            => RuntimeIndex.create(src);
    }
}