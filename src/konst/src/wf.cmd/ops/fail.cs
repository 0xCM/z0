//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial struct Cmd
    {
        public static CmdResult fail(ICmdSpec cmd)
            => new CmdResult(cmd.CmdId, false);

        public static CmdResult fail(ICmdSpec cmd, Exception e)
            => new CmdResult(cmd.CmdId, e);

        public static CmdResult<C> fail<C>(C cmd)
            where C : struct, ICmdSpec
                => new CmdResult<C>(cmd, false);

        public static CmdResult<C> fail<C>(C cmd, Exception e)
            where C : struct, ICmdSpec
                => new CmdResult<C>(cmd, e);

        public static CmdResult<C> fail<C>(C cmd, string message)
            where C : struct, ICmdSpec
                => new CmdResult<C>(cmd, false, message);
    }
}