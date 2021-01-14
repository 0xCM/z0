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
        where A : IAntecedant
        where C : IConsequent
    {
        A Antecedant {get;}

        C Consequence {get;}
    }
}