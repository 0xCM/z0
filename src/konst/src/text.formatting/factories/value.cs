//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial struct Formatters
    {
        [Op]
        public static ValueFormatter value()
            => default(ValueFormatter);
    }
}