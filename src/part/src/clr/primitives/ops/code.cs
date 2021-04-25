//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct ClrPrimitives
    {
        [MethodImpl(Inline), Op]
        public static uint hash(ClrTypeName src)
            => (uint)address(src) | ((uint)(ushort)src.Source.MetadataToken) << 16;

        [MethodImpl(Inline), Op]
        static unsafe MemoryAddress address(ClrTypeName src)
            => memory.address(memory.pchar(src.Source.Name));
    }
}