//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface IDuet : IBitCode
    {

    }
    
    public interface IDuet<B> : IDuet, IBitCode<B>
        where B : unmanaged, IDuet<B>
    {
        new Duet Kind {get;}

        Octet IBitCode.Kind => (Octet)Kind;

        string ITextual.Format() => Kind.ToString();
    }


}