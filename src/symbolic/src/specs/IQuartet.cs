//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;


    public interface IQuartet : IBitCode
    {

    }
    
    public interface IQuartet<B> : IQuartet, IBitCode<B>
        where B : unmanaged, IQuartet<B>
    {
        new Quartet Kind {get;}

        Octet IBitCode.Kind => (Octet)Kind;

        string ITextual.Format() => Kind.ToString();
    }        
}