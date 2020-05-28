//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;


    public interface IQuartet : IBits
    {

    }
    
    public interface IQuartet<B> : IQuartet, IBits<B>
        where B : unmanaged, IQuartet<B>
    {
        new Quartet Kind {get;}

        Octet IBits.Kind => (Octet)Kind;

        string ITextual.Format() => Kind.ToString();
    }        
}