//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface IBitCode : ITextual
    {
        Octet Kind {get;}        
    }

    public interface IBitCode<B> : IBitCode
        where B : unmanaged, IBitCode<B>
    {

    }
}