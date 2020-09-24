//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ICellStreamProvider<F> : IStreamProvider<F>
        where F : unmanaged, IDataCell
    {
        new IEnumerable<F> Stream {get;}

        IEnumerable<F> IStreamProvider<F>.Stream
            => Stream;
    }

    public interface ICellStreamProvider<F,W,T> : ICellStreamProvider<F>
        where F : unmanaged, IDataCell
        where W : unmanaged, ITypeWidth
        where T : unmanaged
    {

    }
}