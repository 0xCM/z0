//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    public interface IHeapIndex
    {
        HeapIndexKind Classifier {get;}

        uint Value {get;}
    }

    public interface IHeapIndex<T> : IHeapIndex
        where T : unmanaged, IHeapIndexKind
    {

        HeapIndexKind IHeapIndex.Classifier
            => default(T).Classifier;
    }

    public interface IHeapIndex<K,T> : IHeapIndex<K>
        where K : unmanaged, IHeapIndexKind
        where T : unmanaged, IHeapIndex
    {

    }

}