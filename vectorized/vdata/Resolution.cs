//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.VData)]

namespace Z0.Parts
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Collections.Generic;

    public sealed class VData : ApiPart<VData, VData.C>
    {        
        public override IBinaryResourceProvider ResourceProvider => default(ProvidedResources);   

        public class C : ApiCatalog<C> { public C() : base(PartId.VData, BinaryResources.Create(Z0.Data.Resources)) {} }            
    }


    readonly struct ProvidedResources : IBinaryResourceProvider
    {
        public IEnumerable<BinaryResource> Resources => Data.Resources;
    }

}