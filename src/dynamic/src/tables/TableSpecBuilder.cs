//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public readonly struct TableSpecBuilder
    {
        [MethodImpl(Inline), Op]
        public static TableFieldSpec field(string name, ushort position, Address16 offset, string type)
            => new TableFieldSpec(name, position, offset, type);

        [MethodImpl(Inline), Op]
        public static TableSpec table(string ns, string type, params TableFieldSpec[] Fields)
            => new TableSpec(ns, type, Fields);
    }
}