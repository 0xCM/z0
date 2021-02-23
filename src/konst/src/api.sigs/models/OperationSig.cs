//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct ApiSigs
    {
        public readonly struct OperationSig : ITextual
        {
            public Name Name {get;}

            public OperandSig Return {get;}

            public Index<OperandSig> Operands {get;}

            [MethodImpl(Inline)]
            public OperationSig(Name name, OperandSig @return, Index<OperandSig> operands)
            {
                Name = name;
                Return = @return;
                Operands = operands;
            }

            public uint OperandCount
            {
                [MethodImpl(Inline)]
                get => Operands.Count;
            }

            public bool HasVoidReturn
            {
                [MethodImpl(Inline)]
                get => Return.IsVoid;
            }

            public bool IsEmpty
            {
                [MethodImpl(Inline)]
                get => Name.IsEmpty;
            }

            public bool IsNonEmpty
            {
                [MethodImpl(Inline)]
                get => Name.IsNonEmpty;
            }
            public string Format()
                => format(this);

            public override string ToString()
                => Format();

            public static OperationSig Empty
            {
                [MethodImpl(Inline)]
               get => new OperationSig(Name.Empty, OperandSig.Empty, Index<OperandSig>.Empty);
            }
        }
    }
}