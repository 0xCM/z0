//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    public interface IBit : IBits
    {

    }

    public interface IBit<B> : IBit, IBits<B>
        where B : unmanaged, IBit<B>
    {
        new Singleton Kind {get;}

        Octet IBits.Kind 
            => (Octet)Kind;

        string ITextual.Format() => Kind.ToString();
    }
}