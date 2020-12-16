//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using M = XedSourceMarkers;

    /// <summary>
    /// Defines a container over the data found in an instruction resource file for a single instruction
    /// </summary>
    public readonly struct XedInstructionDoc
    {
        public TextRow[] Data {get;}

        [MethodImpl(Inline)]
        public XedInstructionDoc(params TextRow[] rows)
            => Data = rows;

        public ref readonly TextRow this[int i]
        {
            [MethodImpl(Inline)]
            get => ref Data[i];
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => (Data?.Length ?? 0) == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }

        public int RowCount
            => Data.Length;

        public string Class
            => XedWfOps.pattern(this, M.ICLASS);

        public string Category
            => XedWfOps.pattern(this, M.CATEGORY);

        public string Extension
            => XedWfOps.pattern(this, M.EXTENSION);

        public string IsaSet
            => XedWfOps.pattern(this, M.ISA_SET);

        public string AttributeText
            => XedWfOps.pattern(this, M.ATTRIBUTES);

        public string RealOpCode
            => XedWfOps.pattern(this, M.REAL_OPCODE);

        public XedPattern[] Patterns
            => XedWfOps.patterns(this);

        [MethodImpl(Inline)]
        internal bool IsProp(int index, string Name)
            => this[index].Text.StartsWith(Name);

        [MethodImpl(Inline)]
        internal string ExtractProp(TextRow src)
            => src.Text.RightOfFirst(M.PROP_DELIMITER).Trim();

        [MethodImpl(Inline)]
        internal string ExtractProp(int index)
            => ExtractProp(this[index]);
    }
}