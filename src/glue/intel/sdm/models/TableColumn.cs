//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct IntelSdm
    {
        public readonly struct TableColumn
        {
            public string Label {get;}

            public ColumnKind Kind {get;}

            public ushort ColWidth {get;}

            [MethodImpl(Inline)]
            public TableColumn(string label, ColumnKind kind, ushort width)
            {
                Label = label;
                Kind = kind;
                ColWidth = width;
            }

            public string Format()
                => string.Format(RP.pad(-(int)ColWidth), Label);

            public override string ToString()
                => Format();
        }
    }
}