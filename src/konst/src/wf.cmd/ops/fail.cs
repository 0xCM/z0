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
        [MethodImpl(Inline)]
        public static CmdResult fail<T>(T spec)
            where T : ICmdSpec
                => new CmdResult(spec.Id, false);

        public static CmdResult fail<T>(T spec, Exception e)
            where T : ICmdSpec
                => fail<T>(spec, e.ToString());

        public static CmdResult fail<T>(T spec, string message)
            where T : ICmdSpec
                => new CmdResult(spec.Id, false, TextCoders.utf8().GetBytes(message));

        [Op]
        public static CmdResult fail(CmdId id, string message)
            => new CmdResult(id, false, TextCoders.utf8().GetBytes(message));

        [Op]
        public static CmdResult fail(CmdId cmd, Exception e)
            => new CmdResult(cmd, false, TextCoders.utf8().GetBytes(e?.ToString() ?? EmptyString));

        [MethodImpl(Inline), Op]
        public static CmdResult fail(CmdId id, params byte[] data)
            => new CmdResult(id, false,data);
    }
}