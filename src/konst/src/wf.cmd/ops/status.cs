//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Cmd
    {
        [MethodImpl(Inline), Op]
        public static CmdExecStatus status(CmdProcess runner)
            => runner.Status();

        [MethodImpl(Inline), Op]
        public static ref CmdExecStatus status(CmdProcess runner, ref CmdExecStatus dst)
            => ref runner.Status(ref dst);
    }
}