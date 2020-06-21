﻿//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dynamics.Operators
{
    using System;

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
