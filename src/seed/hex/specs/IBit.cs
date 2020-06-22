//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    public interface IBit : IBitSet
    {
        
    }
    
    public interface IBit<B> : IBit, IBitSet<B>
        where B : unmanaged, IBit<B>
    {
        new Singleton Kind {get;}

        Octet IBitSet.Kind 
            => (Octet)Kind;

        string ITextual.Format() 
            => Kind.ToString();
    }
}