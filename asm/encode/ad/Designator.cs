//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Resolutions
{
    using System;

    public sealed class AsmEncode : AssemblyResolution<AsmEncode>
    {
        const AssemblyId Identity = AssemblyId.AsmEncode;        

        public override AssemblyId Id 
            => Identity;

        public override IOperationCatalog Operations 
            => new Catalog(Identity);
    }
}