//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;

    public sealed class WorkflowTest : AssemblyDesignator<WorkflowTest>
    {
        const AssemblyId Identity = AssemblyId.WorkflowTest;

        public override AssemblyId Id 
            => Identity;
   
        public override void Run(params string[] args)
            => App.Run(args);
    }
}