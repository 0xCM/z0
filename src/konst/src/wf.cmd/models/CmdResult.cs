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

    public readonly struct CmdResult : ITextual
    {
        public CmdId CmdId {get;}

        public bit Succeeded {get;}

        public BinaryCode Payload {get;}

        [MethodImpl(Inline)]
        public CmdResult(CmdId id,  bit success, params byte[] content)
        {
            CmdId = id;
            Payload = content;
            Succeeded = success;
        }

        [MethodImpl(Inline)]
        public CmdResult(ICmdSpec cmd, bit success, params byte[] content)
        {
            CmdId = cmd.Id;
            Payload = content;
            Succeeded = success;
        }

        [MethodImpl(Inline)]
        public string Format()
            => string.Format(Succeeded ?"{0} executed successfully" : "{0} execution failed", CmdId);

        public static CmdResult Empty
            => default;
    }
}