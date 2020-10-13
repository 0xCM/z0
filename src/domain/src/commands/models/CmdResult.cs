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

    public readonly struct CmdResult
    {
        public CmdId CmdId {get;}

        public bit Succeeded {get;}

        public BinaryCode Content {get;}

        [MethodImpl(Inline)]
        public CmdResult(CmdId id, bit success, byte[] content)
        {
            CmdId = id;
            Content = content;
            Succeeded = success;
        }

        public static CmdResult Empty
            => default;
    }
}