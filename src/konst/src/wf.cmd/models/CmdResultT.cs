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

    public struct CmdResult<P> : ICmdResult<P>
        where P : struct
    {
        public CmdId Id {get;}

        public bit Succeeded {get;}

        public P Payload {get;}

        [MethodImpl(Inline)]
        public CmdResult(CmdId id, bool success, P payload = default)
        {
            Id = id;
            Payload = payload;
            Succeeded = success;
        }

        public static CmdResult<P> Empty
            => default;
    }
}