//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static AsciCharText;

    partial struct RP
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

        /// <summary>
        /// Defines the literal '{'
        /// </summary>
        [StringLiteral("{")]
        public const string OpenSlot = LBrace;

        /// <summary>
        /// Defines the literal '}'
        /// </summary>
        [StringLiteral("}")]
        public const string CloseSlot = RBrace;

        /// <summary>
        /// Defines the literal '"{'
        /// </summary>
        [StringLiteral("\"{")]
        public const string OpenQSlot = DQuote + LBrace;

        /// <summary>
        /// Defines the literal '"}'
        /// </summary>
        [StringLiteral("\"}")]
        public const string CloseQSlot = RBrace + DQuote;

        /// <summary>
        /// Defines the literal '"{0}"'
        /// </summary>
        [StringLiteral("\"{\"}")]
        public const string QSlot0 = OpenQSlot + D0 + CloseQSlot;

        /// <summary>
        /// Defines the literal '{0}'
        /// </summary>
        [FormatPattern(1, "{0}")]
        public const string Slot0 = OpenSlot + D0 + CloseSlot;

        /// <summary>
        /// Defines the literal '{1}'
        /// </summary>
        [FormatPattern(1, "{1}")]
        public const string Slot1 = OpenSlot + D1 + CloseSlot;

        /// <summary>
        /// Defines the literal '{2}'
        /// </summary>
        [FormatPattern(1, "{2}")]
        public const string Slot2 = OpenSlot + D2 + CloseSlot;

        /// <summary>
        /// Defines the literal '{3}'
        /// </summary>
        [FormatPattern(1,"{3}")]
        public const string Slot3 = OpenSlot + D3 + CloseSlot;

        /// <summary>
        /// Defines the literal '{4}'
        /// </summary>
        [FormatPattern(1, "{4}")]
        public const string Slot4 = OpenSlot + D4 + CloseSlot;

        /// <summary>
        /// Defines the literal {5}'
        /// </summary>
        [FormatPattern(1, "{5}")]
        public const string Slot5 = OpenSlot + D5 + CloseSlot;

        /// <summary>
        /// Defines the literal "{6}"
        /// </summary>
        [FormatPattern(1, "{6}")]
        public const string Slot6 = OpenSlot + D6 + CloseSlot;

        /// <summary>
        /// Defines the literal "{7}"
        /// </summary>
        [FormatPattern(1, "{7}")]
        public const string Slot7 = OpenSlot + D7 + CloseSlot;

        /// <summary>
        /// Defines the literal "{0} "
        /// </summary>
        [FormatPattern(1, "{0} ")]
        public const string Slot0Space = Slot0 + Space;

        /// <summary>
        /// Defines the literal "{1} "
        /// </summary>
        [FormatPattern(1, "{1} ")]
        public const string Slot1Space = Slot1 + Space;

        /// <summary>
        /// Defines the literal "{2} "
        /// </summary>
        [FormatPattern(1, "{2} ")]
        public const string Slot2Space = Slot2 + Space;

        /// <summary>
        /// Defines the literal "{3} "
        /// </summary>
        [FormatPattern(1, "{3} ")]
        public const string Slot3Space = Slot3 + Space;

        /// <summary>
        /// Defines the literal "{4} "
        /// </summary>
        [FormatPattern(1, "{4} ")]
        public const string Slot4Space = Slot4 + Space;

        /// <summary>
        /// Defines the literal "{5} "
        /// </summary>
        [FormatPattern(1, "{5} ")]
        public const string Slot5Space = Slot5 + Space;

        /// <summary>
        /// Defines the literal '| {0}'
        /// </summary>
        [FormatPattern(1, "{0} | ")]
        public const string SlottedSpacePipe = Slot0 + SpacePipe + Space;

        /// <summary>
        /// Defines the literal '{0} | {1}'
        /// </summary>
        [FormatPattern(2, "{0} | {1}")]
        public const string PSx2 = Slot0 + SpacePipe + Space + Slot1;

        /// <summary>
        /// Defines the literal '{0} | {1} | {2}'
        /// </summary>
        [FormatPattern(3, "{0} | {1} | {2}")]
        public const string PSx3 = PSx2 + SpacePipe + Space + Slot2;

        /// <summary>
        /// Defines the literal '{0} | {1} | {2} | {3}'
        /// </summary>
        [FormatPattern(4, "{0} | {1} | {2} | {3}")]
        public const string PSx4 = PSx3 + SpacePipe + Space + Slot3;

        /// <summary>
        /// Defines the literal '{0} | {1} | {2} | {3} | {4}'
        /// </summary>
        [FormatPattern(5, "{0} | {1} | {2} | {3} | {4}")]
        public const string PSx5 = PSx4 + SpacePipe + Space + Slot4;

        /// <summary>
        /// Defines the literal '| {0} | {1} | {2} | {3} | {4} | {5}'
        /// </summary>
        [FormatPattern(6, "{0} | {1} | {2} | {3} | {4} | {5}")]
        public const string PSx6 = PSx5 + SpacePipe + Space + Slot5;

        /// <summary>
        /// Defines the literal '"{0}": "{1}"'
        /// </summary>
        [FormatPattern(2, JsonProp)]
        public const string JsonProp = QSlot0 + Colon + Space + QSlot1;

        /// <summary>
        /// Defines a right-padded slot of width 4
        /// </summary>
        [FormatPattern(1, JsonProp)]
        public const string SlotPad0x4 = "{0,-4}";

        /// <summary>
        /// Defines a right-padded slot of width 8
        /// </summary>
        [FormatPattern(1, JsonProp)]
        public const string SlotPad0x8 = "{0,-8}";

        /// <summary>
        /// Defines a right-padded slot of width 12
        /// </summary>
        [FormatPattern(1, JsonProp)]
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
        [FormatPattern(2, SSx2)]
        public const string SSx2 = "{0} {1}";

        /// <summary>
        /// Defines the literal '{0} {1} {2}'
        /// </summary>
        [FormatPattern(3, "{0} {1} {2}")]
        public const string SSx3 = "{0} {1} {2}";

        /// <summary>
        /// Defines the literal '{0} {1} {2} {3}'
        /// </summary>
        [FormatPattern(4)]
        public const string SSx4 = "{0} {1} {2} {3}";

        /// <summary>
        /// Defines the literal '{0} {1} {2} {3} {4}'
        /// </summary>
        [FormatPattern(5)]
        public const string SSx5 = "{0} {1} {2} {3} {4}";

        /// <summary>
        /// Defines the literal "{1} {2}"
        /// </summary>
        [FormatPattern(6, "{1} {2}")]
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
        [FormatPattern(5, "{0}.{1}.{2}.{3}.{4}")]
        public const string SlotDot5 = SlotDot4 + Dot + Slot4;

        [FormatPattern(1, Tuple1)]
        public const string Tuple1 = OpenTuple + Slot0 + CloseTuple;

        [FormatPattern(2, Tuple2)]
        public const string Tuple2 = "({0}, {1})";

        [FormatPattern(3, Tuple3)]
        public const string Tuple3 = "({0}, {1}, {2})";

        [FormatPattern(4, Tuple4)]
        public const string Tuple4 = "({0}, {1}, {2}, {3})";

        [FormatPattern(5, Tuple5)]
        public const string Tuple5 = "({0}, {1}, {2}, {3}, {4})";

        [FormatPattern(6, Tuple6)]
        public const string Tuple6 = "({0}, {1}, {2}, {3}, {4}, {5})";

        [FormatPattern(7, "({0}, {1}, {2}, {3}, {4}, {5}, {6})")]
        public const string Tuple7 = "({0}, {1}, {2}, {3}, {4}, {5}, {6})";

        [FormatPattern(1, "{0} ")]
        public const string RSpace = "{0} ";

        [FormatPattern(1, " {0}")]
        public const string LSpace = " {0}";
    }
}