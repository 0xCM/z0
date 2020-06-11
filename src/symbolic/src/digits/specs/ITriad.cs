//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    public interface ITriad: IBits
    {

    }

    public interface ITriad<B> : ITriad, IBits<B>
        where B : unmanaged, ITriad<B>
    {
        new Triad Kind {get;}

        Octet IBits.Kind => (Octet)Kind;

        string ITextual.Format() => Kind.ToString();
    }    
}