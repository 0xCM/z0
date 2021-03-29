//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmEncodingTask : ITextual
    {
        public Identifier Id {get;}

        public AsmStatementExpr Statement {get;}

        [MethodImpl(Inline)]
        public AsmEncodingTask(Identifier id, AsmStatementExpr statement)
        {
            Id =id;
            Statement = statement;
        }

        public string Format()
            => string.Format("{0}:{1}", Id, Statement);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator AsmEncodingTask((string id, string expr) src)
            => new AsmEncodingTask(src.id, new AsmStatementExpr(src.expr));

        [MethodImpl(Inline)]
        public static implicit operator AsmEncodingTask((Identifier id, AsmStatementExpr expr) src)
            => new AsmEncodingTask(src.id, src.expr);
    }

}