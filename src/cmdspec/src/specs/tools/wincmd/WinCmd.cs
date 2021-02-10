//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    public readonly partial struct WinCmd
    {
        [MethodImpl(Inline), Op]
        public static Echo echo(bit on)
        {
            var cmd = new Echo();
            cmd.On = on;
            cmd.Mode = EchoMode.Enable;
            return cmd;
        }

        [MethodImpl(Inline), Op]
        public static Echo echo(utf8 message)
        {
            var cmd = new Echo();
            cmd.Message = message;
            cmd.Mode = EchoMode.Emit;
            return cmd;
        }
    }
}