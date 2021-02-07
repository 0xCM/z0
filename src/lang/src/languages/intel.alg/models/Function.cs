//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct IntelAlgorithms
    {
        public readonly struct Function
        {
            public Identifier Name {get;}

            [MethodImpl(Inline)]
            public Function(Identifier name)
            {
                Name = name;
            }

            [MethodImpl(Inline)]
            public static implicit operator Function(string name)
                => new Function(name);
        }
    }
}