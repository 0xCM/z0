//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct core
    {
        [MethodImpl(Inline), Op]
        public static Label label(string src)
        {
            if(empty(src))
                return Label.Empty;
            StringAddress a = src;
            return new Label(a.Address, (byte)a.Length);
        }
    }
}