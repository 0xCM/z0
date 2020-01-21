//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{        
    using System;

    public sealed class LibM : AssemblyDesignator<LibM>
    {
        public override AssemblyId Id 
            => AssemblyId.LibM;

        public override IOperationCatalog Catalog 
            => new Catalog();
    }

}