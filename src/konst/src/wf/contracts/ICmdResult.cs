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

    public interface ICmdResult
    {
        CmdId Id {get;}

        bit Succeeded {get;}

    }

    public interface ICmdResult<P> : ICmdResult
        where P : struct
    {
        P Payload {get;}
    }

    public interface ICmdResult<C,P> : ICmdResult<P>
        where P : struct
        where C : struct, ICmdSpec<C>
    {
        CmdId ICmdResult.Id
            => default(C).Id;
    }
}