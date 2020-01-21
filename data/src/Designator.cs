//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{        
    using System;

    public sealed class Data : AssemblyDesignator<Data>
    {
        public override AssemblyId Id => AssemblyId.EmbeddedData;
    }

}