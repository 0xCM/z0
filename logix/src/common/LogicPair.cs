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

    public readonly struct LogicPair
    {
        public readonly bit A;

        public readonly bit B;


        [MethodImpl(Inline)]
        public static LogicPair Define(bit a, bit b)
            => new LogicPair(a,b);
        

        [MethodImpl(Inline)]
        public static implicit operator (bit a, bit b)(LogicPair src)
            => (src.A, src.B);

        [MethodImpl(Inline)]
        public static implicit operator LogicPair((bit a, bit b) src)
            => new LogicPair(src.a, src.b);

        [MethodImpl(Inline)]
        public LogicPair(bit a, bit b)
        {
            this.A = a;
            this.B = b;
        }

    }
    


}