//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IAsciBlock<T> : IStorageBlock<T>
        where T : unmanaged, IAsciBlock<T>
    {
        ref byte First {get;}
    }
}