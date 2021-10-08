//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    public interface IProduction : ITerm
    {
        Label Name {get;}

    }

    public interface IProduction<T> : IProduction, ITerm<T>
    {
        Index<T> Expansion {get;}
    }
}