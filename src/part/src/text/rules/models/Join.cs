//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct TextRules
    {
        public readonly struct Join<T>
        {
            public string Delimiter {get;}

            public Index<T> Terms {get;}

            [MethodImpl(Inline)]
            public Join(string delimiter, Index<T> terms)
            {
                Delimiter = delimiter;
                Terms = terms;
            }
        }
    }
}