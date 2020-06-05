//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;
    using static Memories;

    public readonly struct AsmStatement
    {        
        public ushort Offset {get;}

        public string Expression {get;}
        
        [MethodImpl(Inline)]
        public AsmStatement(ushort offset, string expression)
        {
            Offset = offset;
            Expression = expression;
        }
        
        public string Format()
            => $"{Offset.FormatSmallHex(true)} {Expression}";

        public override string ToString()
            => Format();
    }
}