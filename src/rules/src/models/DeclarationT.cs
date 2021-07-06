//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Rules
    {
        public readonly struct Declaration<T>
        {
            public string Name {get;}

            public T Type {get;}

            [MethodImpl(Inline)]
            public Declaration(string name, T type)
            {
                Name = name;
                Type = type;
            }
        }
    }
}