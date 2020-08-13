//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;
    using static ProcessFx;

    using api = Flow;

    public readonly struct AsmTableSteps
    {
        public const string ActorName = nameof(AsmTableSteps);
        
        public IWfState State {get;}        
                
        readonly EncodedParts Encoded;

        public static implicit operator WfActor(AsmTableSteps src)
            => api.actor(ActorName);

        public AsmTableSteps(IWfState state, in EncodedParts encoded)
        {
            State = state;
            Encoded = encoded;
        }

        public IWfContext Wf 
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