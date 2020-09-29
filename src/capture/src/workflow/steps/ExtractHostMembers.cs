//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static z;
    using static Flow;

    [WfHost]
    public sealed class ExtractHostMembers : WfHost<ExtractHostMembers>
    {
        public static WfStepId StepId => step<ExtractHostMembers>();

        protected override void Execute(IWfShell shell)
            => throw missing();
    }
}