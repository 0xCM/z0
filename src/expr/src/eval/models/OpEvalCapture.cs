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
    public readonly struct OpEvalCapture : IOpEvalCapture
    {
        public IOp Actor {get;}

        public dynamic Input {get;}

        public dynamic Output {get;}

        [MethodImpl(Inline)]
        public OpEvalCapture(IOp op, dynamic src, dynamic result)
        {
            Actor = op;
            Input = src;
            Output = result;
        }

        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();
    }
}