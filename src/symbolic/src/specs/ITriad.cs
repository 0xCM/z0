//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface ITriad: IBitCode
    {

    }

    public interface ITriad<B> : ITriad, IBitCode<B>
        where B : unmanaged, ITriad<B>
    {
        new Triad Kind {get;}

        Octet IBitCode.Kind => (Octet)Kind;

        string ITextual.Format() => Kind.ToString();
    }    
}