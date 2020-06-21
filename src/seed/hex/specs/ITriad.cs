//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    public interface ITriad: IBitSet
    {

    }

    public interface ITriad<B> : ITriad, IBitSet<B>
        where B : unmanaged, ITriad<B>
    {
        new Triad Kind {get;}

        Octet IBitSet.Kind => (Octet)Kind;

        string ITextual.Format() => Kind.ToString();
    }    
}