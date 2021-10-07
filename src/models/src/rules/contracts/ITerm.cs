//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ITerm : ITextual
    {

    }

    public interface ITerm<T> : ITerm
    {

    }

    public interface IValue<T> : ITerm<T>
    {
        T Content {get;}
    }
}