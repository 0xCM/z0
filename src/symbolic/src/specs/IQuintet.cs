//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface IQuintet: IBitCode
    {

    }
    
    public interface IQuintet<B> : IQuintet, IBitCode<B>
        where B : unmanaged, IQuintet<B>
    {
        new Quintet Kind {get;}

        Octet IBitCode.Kind => (Octet)Kind;

        string ITextual.Format() => Kind.ToString();
    }            
}