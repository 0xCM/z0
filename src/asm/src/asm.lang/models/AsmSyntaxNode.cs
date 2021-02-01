//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmSyntaxNode<T> : IAsmSyntaxNode<AsmSyntaxNode<T>>
        where T : IAsmSyntaxNode<T>, new()
    {
        public IAsmSyntaxNode Source {get;}

        public AsmNodeKind NodeKind => Source.NodeKind;

        [MethodImpl(Inline)]
        public AsmSyntaxNode(IAsmSyntaxNode src)
        {
            Source = src;
        }

        [MethodImpl(Inline)]
        public static implicit operator AsmSyntaxNode<T>(T src)
            => new AsmSyntaxNode<T>(src);
    }
}