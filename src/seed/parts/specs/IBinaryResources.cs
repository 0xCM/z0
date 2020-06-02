//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    public interface IBinaryResources : IEnumerableArray<BinaryResource>
    {        
        BinaryResource Find(string id)
            => Data.First(r => r.Id == id);

        Option<BinaryResource> TryFind(string id)
        {
            for(var i=0; i< Data.Length; i++)   
            {
                var res = Data[i];
                if(res.Id == id)
                    return res;
            }
            return Option.none<BinaryResource>();
        }
    }

    public interface IBinaryResourceHost<F> : IBinaryResources
        where F : IBinaryResourceHost<F>, new()
    {
    }
}