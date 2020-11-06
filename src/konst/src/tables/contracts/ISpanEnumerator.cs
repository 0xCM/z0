//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ISpanEnumerator
    {
        bool MoveNext();

        bool HasNext {get;}
    }

    [Free]
    public interface ISpanEnumerator<T> : ISpanEnumerator
    {
        ref T Current {get;}
    }

    [Free]
    public interface ISpanEnumerator<F,T> : ISpanEnumerator<T>
        where F : struct, ISpanEnumerator<F,T>
    {

    }
}