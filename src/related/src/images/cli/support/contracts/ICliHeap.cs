//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ICliHeap
    {
        CliHeapKind Kind {get;}
    }

    public interface ICliHeap<T> : ICliHeap
        where T : struct, ICliHeap
    {

    }
}