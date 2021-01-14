//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IAntecedant : ITerm, ITextual
    {

    }

    public interface IAntecedant<A> : IAntecedant, ITerm<A>
        where A : IEquatable<A>
    {
        Index<A> Terms {get;}
    }
}