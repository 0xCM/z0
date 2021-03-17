//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmCallSummary
    {
        readonly Index<AsmCallInfo> _Calls;

        [MethodImpl(Inline)]
        public AsmCallSummary(Index<AsmCallInfo> calls)
        {
            _Calls = calls;
        }

        public ReadOnlySpan<AsmCallInfo> Calls
        {
            [MethodImpl(Inline)]
            get => _Calls.View;
        }
    }
}