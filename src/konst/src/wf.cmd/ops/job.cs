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
        [MethodImpl(Inline)]
        public static CmdJob<T> job<T>(string name, T spec)
            where T : struct, ITextual
                => new CmdJob<T>(name, spec);
    }
}