//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ClrCmdSpec
    {
        public ClrCmdKey CmdId {get;}

        public BinaryCode Content {get;}

        [MethodImpl(Inline)]
        public ClrCmdSpec(ClrCmdKey id, BinaryCode content)
        {
            CmdId = id;
            Content = content;
        }

        public static ClrCmdSpec Empty
            => new ClrCmdSpec(ClrCmdKey.None, BinaryCode.Empty);
    }
}