//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Parts
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public sealed class AnalogsTest : ApiPart<AnalogsTest>
    {    
        const PartId Identity = PartId.AnalogsTest;

        public override PartId Id 
            => Identity;

        public override void Run(params string[] args)
            => App.Run(args);
    }
}