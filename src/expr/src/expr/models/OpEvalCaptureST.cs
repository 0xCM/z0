//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Expr
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    [StructLayout(LayoutKind.Sequential)]
    public readonly struct OpEvalCapture<S,T> : IOpEvalCapture<S,T>
    {
        public IOp Actor {get;}

        public S Input {get;}

        public T Output {get;}

        [MethodImpl(Inline)]
        public OpEvalCapture(IOp actor, S src, T result)
        {
            Actor = actor;
            Input = src;
            Output = result;
        }

        public string Format()
            => expr.format(this);

        public override string ToString()
            => Format();
    }
}