//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public interface IAsmSyntaxNode
    {
        AsmNodeKind NodeKind {get;}
    }

    public interface IAsmSyntaxNode<T> : IAsmSyntaxNode
        where T : IAsmSyntaxNode<T>, new()
    {

    }

}