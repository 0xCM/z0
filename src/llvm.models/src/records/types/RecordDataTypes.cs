//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly partial struct RecordDataTypes
    {
        [MethodImpl(Inline), Op]
        public static bit bit_type()
            => default;

        [MethodImpl(Inline), Op]
        public static bits bits_type(uint n)
            => new bits(n);

        [MethodImpl(Inline), Op]
        public static Enum enum_type(string et)
            => new Enum(et);

        [MethodImpl(Inline), Op]
        public static @int int_type()
            => default;

        [MethodImpl(Inline), Op]
        public static dag dag_type()
            => default;

        [MethodImpl(Inline), Op]
        public static @string string_type()
            => default;

        [MethodImpl(Inline), Op]
        public static list list_type(string et)
            => new list(et);
    }
}