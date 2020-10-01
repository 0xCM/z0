//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    partial struct TableFields
    {
        [MethodImpl(Inline)]
        public static TableField<F> define<F,T>(F id, TableField spec, ushort? width = null)
            where F : unmanaged
            where T : struct
                => new TableField<F>(id, spec, width ?? (new RenderWidth<ushort>(@as<F,ushort>(id))));


        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static TableField<byte> define<T>(byte id, TableField spec, ushort width)
            where T : struct
                => new TableField<byte>(id, spec, width);
    }
}