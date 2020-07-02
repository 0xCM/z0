//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ISpanEnumerator
    {
        bool MoveNext();

        bool HasNext {get;}        
    }

    public interface ISpanEnumerator<T> : ISpanEnumerator
    {
        ref T Current {get;}
    }

    public interface ISpanEnumerator<F,T> : ISpanEnumerator<T>
        where F : struct, ISpanEnumerator<F,T>
    {

    }
}