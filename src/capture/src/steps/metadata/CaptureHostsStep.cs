//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public readonly struct CaptureHostsStep
    {
        public const WfStepKind Kind = WfStepKind.CaptureHosts;
        
        public const string Name = nameof(CaptureHosts);
    }
}