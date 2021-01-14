//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IRule : ITerm
    {

    }

    public interface IRule<P> : IRule
        where P : IProposition, IEquatable<P>
    {
        Index<P> Terms {get;}
    }
}