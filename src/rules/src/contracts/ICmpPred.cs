//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ICmpPred : IRule, ITextual
    {
        CmpKind Kind {get;}
    }

    public interface ICmpPred<T> : ICmpPred
    {
        T A {get;}

        T B {get;}
    }

    public interface ICmpPred<F,T> : ICmpPred<T>
        where F : ICmpPred<F,T>
    {

    }
}