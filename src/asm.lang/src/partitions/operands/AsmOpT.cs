//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines an asm operand
    /// </summary>
    public readonly struct AsmOp<T> : IAsmOp<T>
        where T : struct, IAsmOpContent
    {
        public T Content {get;}

        public AsmOpKind OpKind {get;}

        [MethodImpl(Inline)]
        public AsmOp(AsmOpKind kind, T value)
        {
            OpKind = kind;
            Content = value;
        }
    }
}