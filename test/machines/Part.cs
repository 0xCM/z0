//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.MachinesTest)]

namespace Z0.Parts
{        
    using System;

    public sealed class MachinesTest : ExecutablePart<MachinesTest>
    {
        public override void Execute(params string[] args) => App.Run(args);    
    }
}