//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct IntelSdm
    {
        [MethodImpl(Inline), Op]
        public static TableColumn column(string name, string type)
            => new TableColumn(name.Trim(), type, (ushort)name.Length);

        [Op]
        public static TableColumn column(string name)
        {
            var kinds = Symbols.index<ColumnKind>();
            var result = kinds.Lookup(name.Trim(), out var sym);
            var type = result ? sym.Expr.Format() : string.Format("!{0}!", name);
            return column(name, type);
        }

        public static Index<TableColumn> columns(ReadOnlySpan<string> src)
        {
            var count = src.Length;
            var buffer = alloc<TableColumn>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
                seek(dst,i) = column(skip(src,i));
            return buffer;
        }
    }
}