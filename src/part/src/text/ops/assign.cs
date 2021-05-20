//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class text
    {
        [Op]
        public static string assign(object lhs, object rhs)
            => concat(lhs, Space, Assignment, Space, rhs);
    }
}