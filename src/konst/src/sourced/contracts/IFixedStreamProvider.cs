//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

   public interface IFixedStreamProvider<F> : IStreamProvider<F>
        where F : unmanaged, IDataCell
    {
        new IEnumerable<F> Stream {get;}

        IEnumerable<F> IStreamProvider<F>.Stream
            => Stream;
    }

    public interface IFixedStreamProvider<F,W,T> : IFixedStreamProvider<F>
        where F : unmanaged, IDataCell
        where W : unmanaged, ITypeWidth
        where T : unmanaged
    {

    }
}