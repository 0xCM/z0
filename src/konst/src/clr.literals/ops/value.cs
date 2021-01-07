//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct ClrLiterals
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static LiteralValue<T> value<T>(T value)
            where T : IEquatable<T>
                => new LiteralValue<T>(value, ClrLiteralKinds.kind<T>());
    }
}