//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.std
{
    public interface iterator<T>
    {
        bool next(out T dst);
    }

    public interface iterator<I,T> : iterator<T>
        where I : unmanaged
    {
    }
}