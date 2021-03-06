//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Rules
    {
        public readonly struct Alt : IRule<Alt>
        {
            public One Left {get;}

            public One Right {get;}

            [MethodImpl(Inline)]
            public Alt(One left, One right)
            {
                Left = left;
                Right = right;
            }
        }
    }
}