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

    public interface ICmdSpec
    {
        CmdId Id {get;}
    }

    public interface ICmdSpec<T> : ICmdSpec
        where T : struct
    {
        CmdId ICmdSpec.Id =>
            CmdId.from<EmitAsmOpCodesCmd>();
    }

    public interface ICmdSpec<K,T> : ICmdSpec<CmdOptions<K,T>>
        where K : unmanaged

    {

    }

    public interface ICmdSpec<H,K,T> : ICmdSpec<K,T>
        where K : unmanaged
        where H : struct, ICmdSpec<H,K,T>
    {

    }
}