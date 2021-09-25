//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm.clang
{
    using System.Runtime.CompilerServices;

    using static Root;

    using K = AstNodeKind;

    public readonly struct ConstantExpr : IAstNode<ConstantExpr>
    {
        readonly ClangAst Ast;

        public uint Source {get;}

        public uint Target {get;}

        [MethodImpl(Inline)]
        internal ConstantExpr(ClangAst ast, uint src, uint dst)
        {
            Ast = ast;
            Source = src;
            Target = dst;
        }

        public K Kind => K.ConstantExpr;
    }
}