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
        public static TableColumn column(string label, string type)
            => new TableColumn(label.Trim(), type, (ushort)label.Length);

        [Op]
        public static TableColumn column(string label)
        {
            var kinds = Symbols.index<ColumnKind>();
            var result = kinds.Lookup(label.Trim(), out var sym);
            var type = result ? sym.Expr.Format() : string.Format("!{0}!", label);
            return column(label, type);
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