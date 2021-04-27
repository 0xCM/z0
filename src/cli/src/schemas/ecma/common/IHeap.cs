//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    public interface IHeap
    {
        HeapKind Kind {get;}
    }

    public interface IHeap<T> : IHeap
        where T : struct, IHeap
    {

    }
}