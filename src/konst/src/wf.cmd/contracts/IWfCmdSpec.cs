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

    public interface IWfCmdSpec
    {
        WfCmdId Id {get;}
    }

    public interface IWfCmdSpec<K,T> : IWfCmdSpec
        where K : unmanaged

    {
        WfCmdOption<K,T>[] Options {get;}
    }


    public interface IWfCmdSpec<H,K,T> : IWfCmdSpec<K,T>
        where K : unmanaged
        where H : struct, IWfCmdSpec<H,K,T>
    {

    }

}