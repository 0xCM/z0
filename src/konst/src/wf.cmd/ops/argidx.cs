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
        public static CmdArgs args<T>(T src)
            where T : struct, ICmdSpec<T>
                => typeof(T).DeclaredInstanceFields().Select(f => new CmdArg(f.Name, f.GetValue(src)?.ToString() ?? EmptyString));
    }
}