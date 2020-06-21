//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        

    public interface IOctet : IBitSet
    {

    }

    public interface IOctet<B> : IOctet, IBitSet<B>
        where B : unmanaged, IOctet<B>
    {        

        string ITextual.Format() 
            => Kind.ToString();
    }            
}