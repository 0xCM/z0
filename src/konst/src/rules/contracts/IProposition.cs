//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IProposition : ITerm
    {

    }

    public interface IProposition<A,C> : IProposition
        where A : IEquatable<A>
        where C : IEquatable<C>
    {
        Antecedant<A> Antecedant {get;}

        Consequent<C> Consequence {get;}
    }
}