//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly partial struct WinCmd
    {
        public enum EchoMode
        {
            Enable,

            Emit
        }

        public struct Echo : IToolCmd<Echo>
        {
            public bit On;

            public utf8 Message;

            public EchoMode Mode;
        }

        [MethodImpl(Inline)]
        public static Echo echo(bit on)
        {
            var cmd = new Echo();
            cmd.On = on;
            cmd.Mode = EchoMode.Enable;
            return cmd;
        }

        [MethodImpl(Inline)]
        public static Echo echo(utf8 message)
        {
            var cmd = new Echo();
            cmd.Message = message;
            cmd.Mode = EchoMode.Emit;
            return cmd;
        }
    }
}