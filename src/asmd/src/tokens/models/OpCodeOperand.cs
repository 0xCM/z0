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
    public readonly struct OpCodeOperand : IExpressional<OpCodeOperand,ushort>
    {
        readonly ushort Source;        
                
        [MethodImpl(Inline)]
        public OpCodeOperand(ushort data)
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

        public OpCodeOperand Zero
        {
            [MethodImpl(Inline)]
            get => Empty;
        }

        [MethodImpl(Inline)]
        public bool Equals(OpCodeOperand src)
            => Source == src.Source;

        public string Format()
            => Source.ToString();

        public override string ToString()
            => Format();

        public static OpCodeOperand Empty 
            => new OpCodeOperand(0);
    }
}