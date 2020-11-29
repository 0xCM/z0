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
        public static CmdExecStatus status(CmdProcess process)
            => process.Status();

        [MethodImpl(Inline), Op]
        public static ref CmdExecStatus status(CmdProcess process, ref CmdExecStatus dst)
            => ref process.Status(ref dst);
    }
}