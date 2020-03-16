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
        public static BinaryOp64 ToFixed(this BinaryOp<long> f)
            => (Fixed64 a, Fixed64 b) => f((long)a.Data, (long)b.Data);

        [MethodImpl(Inline)]
        public static BinaryOp64 ToFixed(this BinaryOp<ulong> f)
            => (Fixed64 a, Fixed64 b) => f(a.Data, b.Data);


    }
}