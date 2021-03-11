//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmExprSet : ITextual
    {
        public AsmOpCodeExpr OpCode {get;}

        public AsmSig Sig {get;}

        public AsmStatementExpr Statement {get;}

        [MethodImpl(Inline)]
        public AsmExprSet(AsmOpCodeExpr oc, AsmSig sig, AsmStatementExpr statement)
        {
            Sig = sig;
            OpCode = oc;
            Statement = statement;
        }

        public void Render(ITextBuffer dst)
            => dst.AppendFormat("{0} ({1}) | {2}", OpCode.Format(), Sig.Format(), Statement.Format());

        public string Format()
        {
            var dst = text.buffer();
            Render(dst);
            return dst.Emit();
        }

        public override string ToString()
            => Format();
    }
}