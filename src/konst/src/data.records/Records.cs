//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;

    [ApiHost]
    public readonly partial struct Records
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline)]
        public static FieldValue<S,T> value<S,T>(S src, FieldInfo field, T value)
            where S : struct, IRecord<S>
                => new FieldValue<S,T>(src, field, value);

    }
}