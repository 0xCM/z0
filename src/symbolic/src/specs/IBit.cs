//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface IBit : IBitCode
    {

    }

    public interface IBit<B> : IBit, IBitCode<B>
        where B : unmanaged, IBit<B>
    {
        new BitKind Kind {get;}

        Octet IBitCode.Kind => (Octet)Kind;

        string ITextual.Format() => Kind.ToString();

    }

}