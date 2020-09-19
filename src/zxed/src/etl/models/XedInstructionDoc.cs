//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
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
        public readonly TextRow[] Data {get;}

        [MethodImpl(Inline)]
        public XedInstructionDoc(params TextRow[] rows)
        {
            Data = rows;
        }

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
            => this.ExtractProp(M.ICLASS);

        public string Category
            => this.ExtractProp(M.CATEGORY);

        public string Extension
            => this.ExtractProp(M.EXTENSION);

        public string IsaSet
            => this.ExtractProp(M.ISA_SET);

        public string AttributeText
            => this.ExtractProp(M.ATTRIBUTES);

        public string RealOpCode
            => this.ExtractProp(M.REAL_OPCODE);

        public XedPattern[] Patterns
            => XedOps.patterns(this);

        [MethodImpl(Inline)]
        internal bool IsProp(int index, string Name)
            => this[index].Text.StartsWith(Name);

        [MethodImpl(Inline)]
        internal string ExtractProp(TextRow src)
            => src.Text.RightOf(M.PROP_DELIMITER).Trim();

        [MethodImpl(Inline)]
        internal string ExtractProp(int index)
            => ExtractProp(this[index]);
    }
}