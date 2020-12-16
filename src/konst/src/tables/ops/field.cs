//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    partial struct Table
    {
        [MethodImpl(Inline)]
        public static TableField<F> field<F,T>(F id, TableField spec, ushort? width = null)
            where F : unmanaged
            where T : struct
                => new TableField<F>(id, spec, width ?? (new RenderWidth<ushort>(@as<F,ushort>(id))));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static TableField<byte> field<T>(byte id, TableField spec, ushort width)
            where T : struct
                => new TableField<byte>(id, spec, width);
    }
}