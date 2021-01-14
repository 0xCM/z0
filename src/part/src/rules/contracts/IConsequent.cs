//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IConsequent : ITerm
    {

    }

    public interface IConsequent<C> : IConsequent, ITerm<C>
        where C : IEquatable<C>
    {
        C Term {get;}
    }
}