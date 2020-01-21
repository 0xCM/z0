//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{
    using System;

    public sealed class GMath : AssemblyDesignator<GMath>
    {
        public override AssemblyId Id 
            => AssemblyId.GMath;            

        public override IOperationCatalog Catalog 
            => new Catalog();
    }
}