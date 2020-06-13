//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        

    public interface IAsciResource<A> : INamedContent<A>, IDescribedContent<A>
        where A : IAsciSequence
    {
        
    }

}