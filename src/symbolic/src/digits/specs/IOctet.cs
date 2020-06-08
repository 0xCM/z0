//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface IOctet : IBits
    {

    }

    public interface IOctet<B> : IOctet, IBits<B>
        where B : unmanaged, IOctet<B>
    {        

        string ITextual.Format() => Kind.ToString();
    }            
}