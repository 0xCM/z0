//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public readonly struct TestInstance<C,T>
        where C : struct
        where T : struct
    {
        public TestCase<C> Case {get;}

        public Index<T> Input {get;}
    }
}