//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    public interface IDuet : IBitSet
    {

    }
    
    public interface IDuet<B> : IDuet, IBitSet<B>
        where B : unmanaged, IDuet<B>
    {
        new Duet Kind {get;}

        Octet IBitSet.Kind 
            => (Octet)Kind;
        
        string ITextual.Format() 
            => Kind.ToString();
    }
}