//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Asm;

    using static Konst;

    public readonly struct WfCaptureControl : IWfStep<WfCaptureControl>
    {
        public const string ActorName = nameof(CaptureControl);

        [MethodImpl(Inline)]
        public static CaptureControl create(WfCaptureState state)
            => new CaptureControl(state);

        public static WfStepId StepId => AB.step<WfCaptureControl>();

    }
}