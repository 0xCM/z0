//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    public interface IBitSet : ITextual
    {
        Octet Kind {get;}        
    }

    public interface IBitSet<B> : IBitSet
        where B : unmanaged, IBitSet<B>
    {

    }    
}