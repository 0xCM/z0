//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface IOctet : IBitCode
    {

    }

    public interface IOctet<B> : IOctet, IBitCode<B>
        where B : unmanaged, IOctet<B>
    {        

        string ITextual.Format() => Kind.ToString();
    }            
}