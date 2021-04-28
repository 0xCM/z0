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
    public interface ICellStream<F> : IStreamProvider<F>
        where F : unmanaged, IDataCell
    {
        new IEnumerable<F> Stream {get;}

        IEnumerable<F> IStreamProvider<F>.Stream
            => Stream;
    }

    [Free]
    public interface ICellStream<F,W,T> : ICellStream<F>
        where F : unmanaged, IDataCell
        where W : unmanaged, ITypeWidth
        where T : unmanaged
    {

    }
}