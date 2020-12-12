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
        public static CmdResult fail<T>(T spec)
            where T : ICmdSpec
                => new CmdResult(spec.CmdId, false);

        public static CmdResult fail<T>(T spec, Exception e)
            where T : ICmdSpec
                => fail<T>(spec, e.ToString());

        public static CmdResult fail<T>(T spec, string message)
            where T : ICmdSpec
                => new CmdResult(spec.CmdId, false, message);

        [Op]
        public static CmdResult fail(CmdId id, string message)
            => new CmdResult(id, false, message);

        [Op]
        public static CmdResult fail(CmdId cmd, Exception e)
            => new CmdResult(cmd, false, e.ToString());
    }
}