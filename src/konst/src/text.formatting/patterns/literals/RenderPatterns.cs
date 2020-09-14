//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static AsciCharText;

    [LiteralProvider]
    public readonly partial struct RenderPatterns
    {
        /// <summary>
        /// Defines the literal '"{1}"'
        /// </summary>
        public const string QSlot1 = OpenQSlot + D1 + CloseQSlot;

        /// <summary>
        /// Defines the literal '"{2}"'
        /// </summary>
        public const string QSlot2 = OpenQSlot + D2 + CloseQSlot;

        /// <summary>
        /// Defines the literal '"{3}"'
        /// </summary>
        public const string QSlot3 = OpenQSlot + D3 + CloseQSlot;

        /// <summary>
        /// Defines the literal '"{4}"'
        /// </summary>
        public const string QSlot4 = OpenQSlot + D4 + CloseQSlot;

        [FormatPattern("{0} ")]
        public const string RSpace = "{0} ";

        [FormatPattern(" {0}")]
        public const string LSpace = " {0}";

        /// <summary>
        /// Defines the literal " |"
        /// </summary>
        [StringLiteral(" |")]
        public const string SpacePipe = Space + Pipe;

        /// <summary>
        /// Defines the literal '| {0}'
        /// </summary>
        [FormatPattern("{0} | ")]
        public const string SlottedSpacePipe = Slot0 + SpacePipe + Space;

        /// <summary>
        /// Defines the literal '{0} | {1}'
        /// </summary>
        [FormatPattern("{0} | {1}")]
        public const string PSx2 = Slot0 + SpacePipe + Space + Slot1;

        /// <summary>
        /// Defines the literal '{0} | {1} | {2}'
        /// </summary>
        [FormatPattern("{0} | {1} | {2}")]
        public const string PSx3 = PSx2 + SpacePipe + Space + Slot2;

        /// <summary>
        /// Defines the literal '{0} | {1} | {2} | {3}'
        /// </summary>
        [FormatPattern("{0} | {1} | {2} | {3}")]
        public const string PSx4 = PSx3 + SpacePipe + Space + Slot3;

        /// <summary>
        /// Defines the literal '{0} | {1} | {2} | {3} | {4}'
        /// </summary>
        [FormatPattern("{0} | {1} | {2} | {3} | {4}")]
        public const string PSx5 = PSx4 + SpacePipe + Space + Slot4;

        /// <summary>
        /// Defines the literal '| {0} | {1} | {2} | {3} | {4} | {5}'
        /// </summary>
        public const string PSx6 = PSx5 + SpacePipe + Space + Slot5;

        /// <summary>
        /// Defines the literal '"{0}": "{1}"'
        /// </summary>
        public const string JsonProp = QSlot0 + Colon + Space + QSlot1;

        /// <summary>
        /// Defines a right-padded slot of width 4
        /// </summary>
        public const string SlotPad0x4 = "{0,-4}";

        /// <summary>
        /// Defines a right-padded slot of width 8
        /// </summary>
        public const string SlotPad0x8 = "{0,-8}";

        /// <summary>
        /// Defines a right-padded slot of width 12
        /// </summary>
        public const string SlotPad0x12 = "{0,-12}";

        /// <summary>
        /// Defines a right-padded slot of width 16
        /// </summary>
        public const string SlotPad0x16 = "{0,-16}";

        /// <summary>
        /// Defines a right-padded slot of width 32
        /// </summary>
        public const string SlotPad0x32 = "{0,-32}";

        /// <summary>
        /// Defines the literal " {0}"
        /// </summary>
        public const string SS0 = Space + Slot0;

        /// <summary>
        /// Defines the literal " {1}"
        /// </summary>
        public const string SS1 = Space + Slot1;

        /// <summary>
        /// Defines the literal " {2}"
        /// </summary>
        public const string SS2 = Space + Slot2;

        /// <summary>
        /// Defines the literal " {3}"
        /// </summary>
        public const string SS3 = Space + Slot3;

        /// <summary>
        /// Defines the literal ' {4}'
        /// </summary>
        public const string SS4 = Space + Slot4;

        /// <summary>
        /// Defines the literal ' {5}'
        /// </summary>
        public const string SS5 = Space + Slot5;

        /// <summary>
        /// Defines the literal '{0} {1}'
        /// </summary>
        [FormatPattern]
        public const string SSx2 = "{0} {1}";

        /// <summary>
        /// Defines the literal '{0} {1} {2}'
        /// </summary>
        [FormatPattern]
        public const string SSx3 = "{0} {1} {2}";

        /// <summary>
        /// Defines the literal '{0} {1} {2} {3}'
        /// </summary>
        [FormatPattern]
        public const string SSx4 = "{0} {1} {2} {3}";

        /// <summary>
        /// Defines the literal '{0} {1} {2} {3} {4}'
        /// </summary>
        [FormatPattern]
        public const string SSx5 = "{0} {1} {2} {3} {4}";

        /// <summary>
        /// Defines the literal "{1} {2}"
        /// </summary>
        [FormatPattern("{1} {2}")]
        public const string SS1x2 = Slot1 + SS2;

        /// <summary>
        /// Defines the literal '{0}.{1}'
        /// </summary>
        [FormatPattern("{0}.{1}")]
        public const string SlotDot2 = Slot0 + Dot + Slot1;

        /// <summary>
        /// Defines the literal '{0}.{1}.{2}'
        /// </summary>
        [FormatPattern("{0}.{1}.{2}")]
        public const string SlotDot3 = SlotDot2 + Dot + Slot2;

        /// <summary>
        /// Defines the literal '{0}.{1}.{2}.{3}'
        /// </summary>
        [FormatPattern("{0}.{1}.{2}.{3}")]
        public const string SlotDot4 = SlotDot3 + Dot + Slot3;

        /// <summary>
        /// Defines the literal '{0}.{1}.{2}.{3}.{4}'
        /// </summary>
        [FormatPattern("{0}.{1}.{2}.{3}.{4}")]
        public const string SlotDot5 = SlotDot4 + Dot + Slot4;

        public const string SlotTuple1 = OpenTuple + Slot0 + CloseTuple;

        [FormatPattern(SlotTuple2)]
        public const string SlotTuple2 = "({0}, {1})";

        [FormatPattern(SlotTuple3)]
        public const string SlotTuple3 = "({0}, {1}, {2})";

        [FormatPattern(SlotTuple4)]
        public const string SlotTuple4 = "({0}, {1}, {2}, {3})";

        [FormatPattern(SlotTuple5)]
        public const string SlotTuple5 = "({0}, {1}, {2}, {3}, {4})";

        [FormatPattern(SlotTuple6)]
        public const string SlotTuple6 = "({0}, {1}, {2}, {3}, {4}, {5})";

        [FormatPattern("({0}, {1}, {2}, {3}, {4}, {5}, {6})")]
        public const string SlotTuple7 = "({0}, {1}, {2}, {3}, {4}, {5}, {6})";

        /// <summary>
        /// Defines the literal '{0} -> {1}'
        /// </summary>
        [FormatPattern("{0} -> {1}")]
        public const string ArrowAxB = "{0} -> {1}";

        const string PageBreak10 = "----------";

        public const string PageBreak20 = PageBreak10 + PageBreak10;

        public const string PageBreak40 = PageBreak20 + PageBreak20;

        public const string PageBreak80 = PageBreak40 + PageBreak40;

        public const string PageBreak120 = PageBreak80 + PageBreak40;

        public const string PageBreak160 = PageBreak80 + PageBreak80;
    }
}