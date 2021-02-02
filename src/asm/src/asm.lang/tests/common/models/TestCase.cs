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

    public readonly struct TestCase<T> : ITestCase<T>
        where T : struct, ITestCase<T>
    {
        public T Case {get;}

        [MethodImpl(Inline)]
        public TestCase(T src)
        {
            Case = src;
        }

        [MethodImpl(Inline)]
        public static implicit operator TestCase<T>(T src)
            => new TestCase<T>(src);
    }
}