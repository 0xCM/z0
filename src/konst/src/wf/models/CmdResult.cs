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
        [MethodImpl(Inline)]
        public static CmdResult win(CmdId id, params byte[] data)
            => new CmdResult(id,true,data);

        [MethodImpl(Inline)]
        public static CmdResult fail(CmdId id, params byte[] data)
            => new CmdResult(id,false,data);

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

        [MethodImpl(Inline)]
        public string Format()
            => string.Format(Succeeded ?"{0} executed successfully" : "{0} execution failed", CmdId);

        public static CmdResult Empty
            => default;
    }
}