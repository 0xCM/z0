//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IAsmSyntaxNode
    {
        AsmNodeKind NodeKind {get;}
    }

    public interface IAsmSyntaxNode<T> : IAsmSyntaxNode
        where T : IAsmSyntaxNode<T>, new()
    {

    }

}