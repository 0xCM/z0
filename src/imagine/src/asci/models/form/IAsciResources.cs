//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    public interface IAsciResources<A> : INamedContent<AsciResource<A>[]>, IDescribedContent<AsciResource<A>[]>
        where A : IAsciSequence
    {

    }
    
}