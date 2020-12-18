//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IRenderTemplate<T> : IDataType<T>
    {

    }

    public interface IRenderTemplate<H,T> : IRenderTemplate<T>
        where H : struct, IRenderTemplate<H,T>
    {

    }

    public interface IRenderTemplate : IRenderTemplate<string>
    {
        bool IDataType.IsFixedWidth
            => false;

        BitSize ISized.StorageWidth
            => (2*8)*(Content?.Length ?? 0);
    }
}