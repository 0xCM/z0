//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ClrCmdResult
    {
        public ClrCmdKey CmdId {get;}

        public bit Succeeded {get;}

        public BinaryCode Content {get;}

        [MethodImpl(Inline)]
        public ClrCmdResult(ClrCmdKey id, bit success, byte[] content)
        {
            CmdId = id;
            Content = content;
            Succeeded = success;
        }

        public static ClrCmdResult Empty
            => new ClrCmdResult(ClrCmdKey.None, false, BinaryCode.Empty);
    }
}