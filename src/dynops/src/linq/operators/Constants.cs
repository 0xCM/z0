//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dynamics.Operators
{
    using System;

    using Z0;
    using static Z0.Seed;
    using static Z0.Memories;
    using static Z0.XPress;
    using static Z0.XFunc;

    public static class Zero<T>
    {
        public static T Value { get; }
            = default;
    }

    public static class One<T>
    {
        public static T Value { get; }
            = Increment<T>.Apply(Zero<T>.Value);
    }
}
