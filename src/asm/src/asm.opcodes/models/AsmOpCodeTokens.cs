//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmOpCodeTokens
    {
        readonly Index<AsmOpCodeToken> Data;

        [MethodImpl(Inline)]
        public AsmOpCodeTokens(AsmOpCodeToken[] src)
            => Data = src;

        public ref readonly AsmOpCodeToken this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ref readonly AsmOpCodeToken this[AsmOpCodeTokenKind index]
        {
            [MethodImpl(Inline)]
            get => ref Data[(byte)index];
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }
    }
}