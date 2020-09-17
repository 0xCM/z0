//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface IUtf
    {

    }

    public interface IUtf<T> : IUtf
        where T : unmanaged
    {

    }

    public interface IUtf<W,T> : IUtf<T>
        where T : unmanaged
        where W : unmanaged, IDataWidth<W>
    {


    }
}
