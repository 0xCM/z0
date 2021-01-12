//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static PrimalBits;

    partial struct ClrPrimitives
    {
        [MethodImpl(Inline), Op]
        internal static unsafe MemoryAddress address(ClrTypeName src)
            => memory.address(memory.pchar2(src.Source.Name));

        [MethodImpl(Inline), Op]
        public static TypeCode code(ClrPrimalKind f)
            => (TypeCode)select(f, Field.KindId);

        [MethodImpl(Inline), Op]
        public static uint hash(ClrTypeName src)
            => (uint)address(src) | ((uint)(ushort)src.Source.MetadataToken) << 16;
    }
}