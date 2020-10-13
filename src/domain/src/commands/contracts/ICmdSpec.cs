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

    public interface ICmdSpec<K,T> : ICmdSpec
        where K : unmanaged

    {
        CmdOption<K,T>[] Options {get;}
    }

    public interface ICmdSpec<H,K,T> : ICmdSpec<K,T>
        where K : unmanaged
        where H : struct, ICmdSpec<H,K,T>
    {

    }
}