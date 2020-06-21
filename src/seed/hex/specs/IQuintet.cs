//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        

    public interface IQuintet: IBitSet
    {

    }
    
    public interface IQuintet<B> : IQuintet, IBitSet<B>
        where B : unmanaged, IQuintet<B>
    {
        new Quintet Kind {get;}

        Octet IBitSet.Kind => (Octet)Kind;

        string ITextual.Format() => Kind.ToString();
    }            
}