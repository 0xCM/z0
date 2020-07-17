//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    public interface IBinaryResourceIndex : IContentedIndex<BinaryResource>
    {        
        BinaryResource Find(string id)
            => Content.First(r => r.Identifier == id);

        Option<BinaryResource> TryFind(string id)
        {
            for(var i=0; i< Content.Length; i++)   
            {
                var res = Content[i];
                if(res.Identifier == id)
                    return res;
            }
            return Option.none<BinaryResource>();
        }
    }
}