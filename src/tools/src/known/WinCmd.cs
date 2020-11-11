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

    [ApiHost]
    public readonly partial struct WinCmd
    {
        public struct Echo : IToolCmd<Echo>
        {
            public bit On;

            public utf8 Message;
        }

        public static Echo echo(bit on)
        {
            var cmd = new Echo();
            cmd.On = on;
            cmd.Message = utf8.Empty;
            return cmd;
        }

        public static utf8 format(Echo cmd)
        {
            return default;
        }
    }
}