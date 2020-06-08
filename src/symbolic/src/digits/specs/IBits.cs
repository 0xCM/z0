//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface IBits : ITextual
    {
        Octet Kind {get;}        
    }

    public interface IBits<B> : IBits
        where B : unmanaged, IBits<B>
    {

    }
}