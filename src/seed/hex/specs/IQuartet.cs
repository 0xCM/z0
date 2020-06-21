//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        

    public interface IQuartet : IBitSet
    {

    }
    
    public interface IQuartet<B> : IQuartet, IBitSet<B>
        where B : unmanaged, IQuartet<B>
    {
        new Quartet Kind {get;}

        Octet IBitSet.Kind => (Octet)Kind;

        string ITextual.Format() => Kind.ToString();
    }        
}