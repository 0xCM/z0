//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Tokens;
    
    using static Konst;    
    using static z;
    
    public readonly struct AsmOpCodeTokenIndex
    {
        readonly TableSpan<OpCodeToken> Data;        
        
        [MethodImpl(Inline)]
        public AsmOpCodeTokenIndex(OpCodeToken[] src)
        {
            Data = src;
        }

        public ref readonly OpCodeToken this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ref readonly OpCodeToken this[AsmOpCodeTokenKind index]
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