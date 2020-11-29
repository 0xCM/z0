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

    public struct CmdResult<C,P> : ICmdResult<C,P>
        where P : struct
        where C : struct, ICmdSpec<C>
    {
        public C Cmd;

        public bool Succeeded {get;}

        public P Payload {get;}

        [MethodImpl(Inline)]
        public CmdResult(C cmd, bool succeeded, P payload)
        {
            Cmd = cmd;
            Payload = payload;
            Succeeded = succeeded;
        }

        [MethodImpl(Inline)]
        public static implicit operator CmdResult<C,P>((C cmd, P payload) src)
            => new CmdResult<C,P>(src.cmd, true, src.payload);

        public static CmdResult<C,P> Empty
            => default;
    }
}