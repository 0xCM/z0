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
        public class TableHeader
        {
            readonly string[] _Labels;

            public TableKind TableKind {get;}

            public Index<ColumnKind> Columns {get;}

            [MethodImpl(Inline), Op]
            public TableHeader(TableKind kind, ColumnKind[] cols, string[] labels)
            {
                TableKind = kind;
                Columns = cols;
                _Labels = labels;
            }


            public ReadOnlySpan<string> Labels
            {
                [MethodImpl(Inline), Op]
                get => _Labels;
            }

            public string Format()
                => text.join(" | ", _Labels.Select(x => x.ToString()));

            public override string ToString()
                => Format();

            public static TableHeader Empty
                => new TableHeader(0,array<ColumnKind>(), array<string>());
        }
    }
}