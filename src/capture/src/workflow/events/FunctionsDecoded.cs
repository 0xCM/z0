//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct FunctionsDecoded : IWfEvent<FunctionsDecoded>
    {
        public const string EventName = nameof(FunctionsDecoded);

        public WfEventId EventId {get;}

        public readonly ApiHostUri Host;

        public readonly AsmRoutine[] Functions;

        public readonly Count32 FunctionCount
            => Functions.Length;
        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public FunctionsDecoded(WfStepId step, ApiHostUri host, AsmRoutine[] functions, CorrelationToken ct, FlairKind flair = FlairKind.Ran)
        {
            EventId = (EventName, step, ct);
            Host = host;
            Functions = functions;
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Render.format(EventId, Host, FunctionCount);
    }
}