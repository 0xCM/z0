//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using M = XedSourceMarkers;

    public readonly struct XedInstructionDoc
    {
        public Index<TextRow> Content {get;}

        [MethodImpl(Inline)]
        public XedInstructionDoc(params TextRow[] rows)
            => Content = rows;

        public ref readonly TextRow this[int i]
        {
            [MethodImpl(Inline)]
            get => ref Content[i];
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Content.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }

        public int RowCount
            => Content.Length;

        public string AttributeText
            => XedParser.pattern(this, M.ATTRIBUTES);

        public string RealOpCode
            => XedParser.pattern(this, M.REAL_OPCODE);

        public string IForm
            => XedParser.pattern(this, M.IFORM);
    }
}