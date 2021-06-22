//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct lang
    {
        [MethodImpl(Inline), Op]
        public static SwitchCase @case(uint group, string name, Value test)
            => new SwitchCase(group,name,test);
    }
}