//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Flow;

    [Step(Kind, true)]
    public readonly struct EmitImageContentStep
    {
        public const WfStepKind Kind = WfStepKind.EmitImageContent;
        
        public const string Name = nameof(EmitImageContent);

        public static WfStepId Id => step(Kind,Name);
    }       
}