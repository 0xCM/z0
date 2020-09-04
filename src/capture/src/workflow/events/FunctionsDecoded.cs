//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static RenderPatterns;

    public readonly struct FunctionsDecoded : IWfEvent<FunctionsDecoded>
    {
        public WfEventId EventId  => WfEventId.define("Placeholder");

        public readonly ApiHostUri Host;

        public readonly AsmRoutine[] Functions;

        [MethodImpl(Inline)]
        public FunctionsDecoded(ApiHostUri host, AsmRoutine[] functions)
        {
            Host = host;
            Functions = functions;
        }

        public string Format()
            => $"{Functions.Length} {Host} functions decoded";

        public FunctionsDecoded Zero
            => Empty;

        public FlairKind Flair
            => FlairKind.Running;

        public static FunctionsDecoded Empty
            => default;
    }
}