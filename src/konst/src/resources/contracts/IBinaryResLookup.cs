//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    public interface IBinaryResLookup : IContentIndex<BinaryRes>
    {
        BinaryRes Find(string id)
            => Content.First(r => r.Identifier == id);

        Option<BinaryRes> TryFind(string id)
        {
            for(var i=0; i< Content.Length; i++)
            {
                var res = Content[i];
                if(res.Identifier == id)
                    return res;
            }
            return Option.none<BinaryRes>();
        }
    }
}