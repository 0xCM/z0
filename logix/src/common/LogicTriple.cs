//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public readonly struct LogicTriple
    {
        public readonly bit A;

        public readonly bit B;

        public readonly bit C;

        [MethodImpl(Inline)]
        public static LogicTriple Define(bit a, bit b, Bit c)
            => new LogicTriple(a,b,c);

        public static implicit operator (bit a, bit b, bit c)(LogicTriple src)
            => (src.A, src.B, src.C);

        public static implicit operator LogicTriple((bit a, bit b, bit c) src)
            => new LogicTriple(src.a, src.b, src.c);

        public LogicTriple(bit a, bit b, bit c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }        
    }
}