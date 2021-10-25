//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Eval
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    [StructLayout(LayoutKind.Sequential)]
    public readonly struct OpEvalCapture<S> : IOpEvalCapture<S>
    {
        public IOp Actor {get;}

        public S Input {get;}

        public dynamic Output {get;}

        [MethodImpl(Inline)]
        public OpEvalCapture(IOp op, S src, dynamic result)
        {
            Actor = op;
            Input = src;
            Output = result;
        }

        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();        

        [MethodImpl(Inline)]
        public static implicit operator OpEvalCapture(OpEvalCapture<S> src)
            => new OpEvalCapture(src.Actor, src.Input, src.Output);
    }
}