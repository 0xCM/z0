//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    public readonly struct TestInstance<C,T>
        where C : struct
        where T : struct
    {
        public TestCase<C> Case {get;}

        public Index<T> Input {get;}
    }
}