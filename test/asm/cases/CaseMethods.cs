//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using Host = CaseMethods;

    public readonly struct CaseMethods
    {
        public static CaseMethods Methods => default;

        public static uint K17()
            => 17;

        public static uint Square(uint x)
            => x*x;

        public static uint BinaryAdd(uint x, uint y)
            => x + y;

        public static uint TernaryAdd(uint x, uint y, uint z)
            => x + y + z;

        public static MethodInfo K17_Method
            => typeof(Host).Method(nameof(K17));

        public static MethodInfo Square_Method
            => typeof(Host).Method(nameof(Square));

        public static MethodInfo BinaryAdd_Method
            => typeof(Host).Method(nameof(BinaryAdd));

        public static MethodInfo TernaryAdd_Method
            => typeof(Host).Method(nameof(TernaryAdd));
    }
}