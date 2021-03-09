//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct AsmExpr
    {
        public readonly struct Form
        {
            public OpCode OpCode {get;}

            public Signature Sig {get;}

            [MethodImpl(Inline)]
            internal Form(OpCode opcode, Signature sig)
            {
                OpCode = opcode;
                Sig = sig;
            }

            public string Expression
            {
                [MethodImpl(Inline)]
                get => string.Format("{0} -> {1}", Sig, OpCode);
            }

            public bool IsEmpty
            {
                [MethodImpl(Inline)]
                get => OpCode.IsEmpty || Sig.IsEmpty;
            }

            public bool IsNonEmpty
            {
                [MethodImpl(Inline)]
                get => !IsEmpty;
            }

            [MethodImpl(Inline)]
            public bool Equals(Form src)
                => OpCode == src.OpCode && Sig == src.Sig;

            public override bool Equals(object src)
                => src is Form x && Equals(x);

            public override int GetHashCode()
                => (int)alg.hash.combine(OpCode.GetHashCode(), Sig.GetHashCode());

            public string Format()
                => Expression;

            public override string ToString()
                => Format();

            public static Form Empty
                => new Form(OpCode.Empty, AsmExpr.Signature.Empty);
        }
    }
}