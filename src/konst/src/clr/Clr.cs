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

    [ApiHost(ApiNames.Clr, true)]
    public readonly partial struct Clr
    {
        const NumericKind Closure = UnsignedInts;

        const BindingFlags BF = ReflectionFlags.BF_All;

        [MethodImpl(Inline), Op]
        public static Index<Type> interfaces(Type src)
            => src.GetInterfaces();

        [MethodImpl(Inline), Op]
        public static ClrTypeLookup lookup(Type[] src)
            => new ClrTypeLookup(src);

        [MethodImpl(Inline), Op]
        public static ClrStruct @struct(Type src)
            => new ClrStruct(src);
    }
}