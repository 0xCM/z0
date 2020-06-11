//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    public interface IDuet : IBits
    {

    }
    
    public interface IDuet<B> : IDuet, IBits<B>
        where B : unmanaged, IDuet<B>
    {
        new Duet Kind {get;}

        Octet IBits.Kind 
            => (Octet)Kind;
        
        string ITextual.Format() 
            => Kind.ToString();
    }
}