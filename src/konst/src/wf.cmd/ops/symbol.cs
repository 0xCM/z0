//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Cmd
    {
        [MethodImpl(Inline), Op]
        public static CmdVarSymbol symbol(string name)
            => new CmdVarSymbol(name);
    }
}