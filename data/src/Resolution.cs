//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Resolutions
{        
    using System;

    public sealed class Data : AssemblyResolution<Data, Data.C>
    {
        public Data() : base(AssemblyId.Data) {}

        public class C : OpCatalog<C>
        {
            public C() : base(AssemblyId.Data, DataResourceIndex.Create(Z0.Data.Resources)) {}            
        }
    }
}