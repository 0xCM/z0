//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Variable
    {
        public Identifier Name {get;}

        [MethodImpl(Inline)]
        public Variable(Identifier name)
        {
            Name = name;
        }
    }

    public readonly struct Variable<T>
    {
        public Identifier Name {get;}

        [MethodImpl(Inline)]
        public Variable(Identifier name)
        {
            Name = name;
        }
    }
}