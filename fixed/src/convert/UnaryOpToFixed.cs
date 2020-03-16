//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Security;
    using System.Reflection;

    using static Root;

    partial class FixedNumericOps
    {
        [MethodImpl(Inline)]
        public static UnaryOp64 ToFixed(this UnaryOp<long> f)
            => (Fixed64 a) => f((long)a.Data);

        [MethodImpl(Inline)]
        public static UnaryOp64 ToFixed(this UnaryOp<ulong> f)
            => (Fixed64 a) => f(a.Data);

    }
}