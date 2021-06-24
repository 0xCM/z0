//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Root;

    partial struct Cmd
    {
        [Op]
        public static CmdDispatcher dispatcher(object host)
            => new CmdDispatcher(host, lookup(host));
    }
}