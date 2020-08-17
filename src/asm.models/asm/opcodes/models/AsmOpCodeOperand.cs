//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines an operand in the context of an opcode expression
    /// </summary>
    public readonly struct AsmOpCodeOperand : IExpressional<AsmOpCodeOperand,ushort>
    {
        readonly ushort Source;        
                
        [MethodImpl(Inline)]
        public AsmOpCodeOperand(ushort data)
            => Source = data;

        public ushort Body
        {
            [MethodImpl(Inline)]
            get => Source;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Source == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Source != 0;
        }

        public AsmOpCodeOperand Zero
        {
            [MethodImpl(Inline)]
            get => Empty;
        }

        [MethodImpl(Inline)]
        public bool Equals(AsmOpCodeOperand src)
            => Source == src.Source;

        public string Format()
            => Source.ToString();

        public override string ToString()
            => Format();

        public static AsmOpCodeOperand Empty 
            => new AsmOpCodeOperand(0);
    }
}