//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AsmTableSteps
    {
        public const string StepName = nameof(AsmTableSteps);

        public IWfCaptureState State {get;}

        readonly GlobalCodeIndex Encoded;

        [MethodImpl(Inline)]
        public static implicit operator WfActor(AsmTableSteps src)
            => Flow.actor(StepName);

        [MethodImpl(Inline)]
        public AsmTableSteps(IWfCaptureState state, in GlobalCodeIndex encoded)
        {
            State = state;
            Encoded = encoded;
        }

        public IWfShell Wf
            => State.Wf;

        public void Run()
        {

        }

        void Emit()
        {
            using var step = new EmitAsmTables(this, State, Encoded, Wf.Ct);
        }

        public void Dispose()
        {


        }
    }
}