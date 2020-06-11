//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    public interface IQuintet: IBits
    {

    }
    
    public interface IQuintet<B> : IQuintet, IBits<B>
        where B : unmanaged, IQuintet<B>
    {
        new Quintet Kind {get;}

        Octet IBits.Kind => (Octet)Kind;

        string ITextual.Format() => Kind.ToString();
    }            
}