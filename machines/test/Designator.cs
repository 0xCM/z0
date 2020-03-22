//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Parts
{        
    using System;

    public sealed class MachineTest : ApiPart<MachineTest>
    {
        const PartId Identity = PartId.MachinesTest;

        public override PartId Id 
            => Identity;

        public override void Run(params string[] args)
            => App.Run(args);
    }
}