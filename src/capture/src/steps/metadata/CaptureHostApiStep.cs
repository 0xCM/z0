//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public readonly struct CaptureHostApiStep
    {
        public const WfStepKind Kind = WfStepKind.CaptureHostMembers;
        
        public const string Name = nameof(CaptureHostMembers);
    }
}