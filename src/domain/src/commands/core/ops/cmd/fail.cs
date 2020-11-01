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
        public static CmdResult fail(CmdId id, params byte[] data)
            => new CmdResult(id, false,data);

        [MethodImpl(Inline), Op]
        public static CmdResult fail(CmdId id, string message)
            => new CmdResult(id, false, TextEncoders.utf8().GetBytes(message));

        [MethodImpl(Inline), Op]
        public static CmdResult fail(CmdId cmd, Exception e)
            => new CmdResult(cmd, false, TextEncoders.utf8().GetBytes(e?.ToString() ?? EmptyString));
    }
}