//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Resolutions
{        
    using System;

    public sealed class LibM : AssemblyResolution<LibM>
    {
        const AssemblyId Identity = AssemblyId.LibM;

        public override AssemblyId Id 
            => Identity;

        public override IOperationCatalog Operations 
            => new Catalog(Identity);
    }
}