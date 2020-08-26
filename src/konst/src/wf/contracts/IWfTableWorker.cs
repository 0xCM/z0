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

    public interface IWfTableWorker : IWfWorker
    {

    }

    public interface IWfTableWorker<T> : IWfTableWorker
        where T : struct, ITable
    {

    }

    public interface IWfTableWorker<H,T> : IWfTableWorker<T>, IWfWorker<H>
        where T : struct, ITable
        where H : struct, IWfTableWorker<H,T>
    {

    }

}