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

    public readonly struct XedInstructionDoc : IXedRule<XedInstructionDoc>
    {
        public XedRuleKind RuleKind => XedRuleKind.Instruction;

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
            => Xed.pattern(this, M.ICLASS);

        public string Category
            => Xed.pattern(this, M.CATEGORY);

        public string Extension
            => Xed.pattern(this, M.EXTENSION);

        public string IsaSet
            => Xed.pattern(this, M.ISA_SET);

        public string AttributeText
            => Xed.pattern(this, M.ATTRIBUTES);

        public string RealOpCode
            => Xed.pattern(this, M.REAL_OPCODE);

        public XedPattern[] Patterns
            => Xed.patterns(this);

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