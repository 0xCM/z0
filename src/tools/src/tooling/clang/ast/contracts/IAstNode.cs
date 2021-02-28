//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    partial struct ClangAst
    {
        public interface IAstNode<T> : ISyntaxNode<T,ClangAst.AstNodeKind>
            where T : IAstNode<T>, new()
        {

        }

        public interface IDeclNode<T> : IAstNode<T>
            where T : IDeclNode<T>, new()
        {
            GridPoint Location {get;}

            Identifier Name {get;}
        }
    }
}