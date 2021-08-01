//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsmSigTokens;
    using static core;

    [ApiHost]
    public readonly struct AsmSize
    {
        const byte N = 8;

        static ReadOnlySpan<byte> RexW => new byte[N]{0,0,0,0,1,1,1,1};

        static ReadOnlySpan<byte> OszPrefix => new byte[N]{0,0,1,1,0,0,1,1};

        static ReadOnlySpan<byte> AszPrefix => new byte[N]{0,1,0,1,0,1,0,1};

        static ReadOnlySpan<byte> EOsz => new byte[N]{32,32,16,16,64,64,64,64};

        static ReadOnlySpan<byte> EAsz => new byte[N]{64,32,64,32,64,32,64,32};
    }
}