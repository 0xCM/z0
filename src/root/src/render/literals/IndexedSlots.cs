//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct RP
    {
        const string D0 = "0";

        const string D1 = "1";

        const string D2 = "2";

        const string D3 = "3";

        const string D4 = "4";

        const string D5 = "5";

        const string D6 = "6";

        const string D7 = "7";

        const string D8 = "8";

        const string D9 = "9";

        const string Space = " ";

        /// <summary>
        /// Defines the literal '}'
        /// </summary>
        [RenderLiteral(RBrace)]
        const string RBrace = "}";

        /// <summary>
        /// Defines the literal '"'
        /// </summary>
        [RenderLiteral(DQuote)]
        const string DQuote = "\"";

        /// <summary>
        /// Defines the literal '"'
        /// </summary>
        [RenderLiteral(Colon)]
        const string Colon = ":";

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
        [RenderLiteral("{")]
        public const string OpenSlot ="{";

        /// <summary>
        /// Defines the literal '}'
        /// </summary>
        [RenderLiteral("}")]
        public const string CloseSlot = "}";

        /// <summary>
        /// Defines the literal '"{'
        /// </summary>
        [RenderLiteral("\"{")]
        public const string OpenQSlot = DQuote + OpenSlot;

        /// <summary>
        /// Defines the literal '"}'
        /// </summary>
        [RenderLiteral("\"}")]
        public const string CloseQSlot = RBrace + DQuote;

        /// <summary>
        /// Defines the literal '"{0}"'
        /// </summary>
        [RenderLiteral("\"{\"}")]
        public const string QSlot0 = OpenQSlot + D0 + CloseQSlot;

        /// <summary>
        /// Defines the literal '{0}'
        /// </summary>
        [RenderPattern(1, "{0}")]
        public const string Slot0 = OpenSlot + D0 + CloseSlot;

        /// <summary>
        /// Defines the literal '{1}'
        /// </summary>
        [RenderPattern(1, "{1}")]
        public const string Slot1 = OpenSlot + D1 + CloseSlot;

        /// <summary>
        /// Defines the literal '{2}'
        /// </summary>
        [RenderPattern(1, "{2}")]
        public const string Slot2 = OpenSlot + D2 + CloseSlot;

        /// <summary>
        /// Defines the literal '{3}'
        /// </summary>
        [RenderPattern(1,"{3}")]
        public const string Slot3 = OpenSlot + D3 + CloseSlot;

        /// <summary>
        /// Defines the literal '{4}'
        /// </summary>
        [RenderPattern(1, "{4}")]
        public const string Slot4 = OpenSlot + D4 + CloseSlot;

        /// <summary>
        /// Defines the literal {5}'
        /// </summary>
        [RenderPattern(1, "{5}")]
        public const string Slot5 = OpenSlot + D5 + CloseSlot;

        /// <summary>
        /// Defines the literal "{6}"
        /// </summary>
        [RenderPattern(1, "{6}")]
        public const string Slot6 = OpenSlot + D6 + CloseSlot;

        /// <summary>
        /// Defines the literal "{7}"
        /// </summary>
        [RenderPattern(1, "{7}")]
        public const string Slot7 = OpenSlot + D7 + CloseSlot;

        /// <summary>
        /// Defines the literal "{8}"
        /// </summary>
        [RenderPattern(1, "{8}")]
        public const string Slot8 = OpenSlot + D8 + CloseSlot;

        /// <summary>
        /// Defines the literal "{0} "
        /// </summary>
        [RenderPattern(1, "{0} ")]
        public const string Slot0Space = Slot0 + Space;

        /// <summary>
        /// Defines the literal "{1} "
        /// </summary>
        [RenderPattern(1, "{1} ")]
        public const string Slot1Space = Slot1 + Space;

        /// <summary>
        /// Defines the literal "{2} "
        /// </summary>
        [RenderPattern(1, "{2} ")]
        public const string Slot2Space = Slot2 + Space;

        /// <summary>
        /// Defines the literal "{3} "
        /// </summary>
        [RenderPattern(1, "{3} ")]
        public const string Slot3Space = Slot3 + Space;

        /// <summary>
        /// Defines the literal "{4} "
        /// </summary>
        [RenderPattern(1, "{4} ")]
        public const string Slot4Space = Slot4 + Space;

        /// <summary>
        /// Defines the literal "{5} "
        /// </summary>
        [RenderPattern(1, "{5} ")]
        public const string Slot5Space = Slot5 + Space;

        /// <summary>
        /// Defines the literal '| {0}'
        /// </summary>
        [RenderPattern(1, "{0} | ")]
        public const string SlottedSpacePipe = Slot0 + SpacePipe + Space;

        /// <summary>
        /// Defines the literal '{0} | {1}'
        /// </summary>
        [RenderPattern(2, "{0} | {1}")]
        public const string PSx2 = Slot0 + SpacePipe + Space + Slot1;

        /// <summary>
        /// Defines the literal '{0} | {1} | {2}'
        /// </summary>
        [RenderPattern(3, "{0} | {1} | {2}")]
        public const string PSx3 = PSx2 + SpacePipe + Space + Slot2;

        /// <summary>
        /// Defines the literal '{0} | {1} | {2} | {3}'
        /// </summary>
        [RenderPattern(4, "{0} | {1} | {2} | {3}")]
        public const string PSx4 = PSx3 + SpacePipe + Space + Slot3;

        /// <summary>
        /// Defines the literal '{0} | {1} | {2} | {3} | {4}'
        /// </summary>
        [RenderPattern(5, "{0} | {1} | {2} | {3} | {4}")]
        public const string PSx5 = PSx4 + SpacePipe + Space + Slot4;

        /// <summary>
        /// Defines the literal '| {0} | {1} | {2} | {3} | {4} | {5}'
        /// </summary>
        [RenderPattern(6, "{0} | {1} | {2} | {3} | {4} | {5}")]
        public const string PSx6 = PSx5 + SpacePipe + Space + Slot5;

        /// <summary>
        /// Defines the literal '| {0} | {1} | {2} | {3} | {4} | {5} | {6}'
        /// </summary>
        [RenderPattern(7, "{0} | {1} | {2} | {3} | {4} | {5} | {6}")]
        public const string PSx7 = PSx6 + SpacePipe + Space + Slot6;

        /// <summary>
        /// Defines the literal '"{0}": "{1}"'
        /// </summary>
        [RenderPattern(2, JsonProp)]
        public const string JsonProp = QSlot0 + Colon + Space + QSlot1;

        /// <summary>
        /// Defines a right-padded slot of width 4
        /// </summary>
        [RenderPattern(1, JsonProp)]
        public const string SlotPad0x4 = "{0,-4}";

        /// <summary>
        /// Defines a right-padded slot of width 8
        /// </summary>
        [RenderPattern(1, JsonProp)]
        public const string SlotPad0x8 = "{0,-8}";

        /// <summary>
        /// Defines a right-padded slot of width 12
        /// </summary>
        [RenderPattern(1, JsonProp)]
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
        [RenderPattern(2, SSx2)]
        public const string SSx2 = "{0} {1}";

        /// <summary>
        /// Defines the literal '{0} {1} {2}'
        /// </summary>
        [RenderPattern(3, "{0} {1} {2}")]
        public const string SSx3 = "{0} {1} {2}";

        /// <summary>
        /// Defines the literal '{0} {1} {2} {3}'
        /// </summary>
        [RenderPattern(4)]
        public const string SSx4 = "{0} {1} {2} {3}";

        /// <summary>
        /// Defines the literal '{0} {1} {2} {3} {4}'
        /// </summary>
        [RenderPattern(5)]
        public const string SSx5 = "{0} {1} {2} {3} {4}";

        /// <summary>
        /// Defines the literal "{1} {2}"
        /// </summary>
        [RenderPattern(6, "{1} {2}")]
        public const string SS1x2 = Slot1 + SS2;

        /// <summary>
        /// Defines the literal '{0}.{1}'
        /// </summary>
        [RenderPattern("{0}.{1}")]
        public const string SlotDot2 = Slot0 + Dot + Slot1;

        /// <summary>
        /// Defines the literal '{0}.{1}.{2}'
        /// </summary>
        [RenderPattern("{0}.{1}.{2}")]
        public const string SlotDot3 = SlotDot2 + Dot + Slot2;

        /// <summary>
        /// Defines the literal '{0}.{1}.{2}.{3}'
        /// </summary>
        [RenderPattern("{0}.{1}.{2}.{3}")]
        public const string SlotDot4 = SlotDot3 + Dot + Slot3;

        /// <summary>
        /// Defines the literal '{0}.{1}.{2}.{3}.{4}'
        /// </summary>
        [RenderPattern(5, "{0}.{1}.{2}.{3}.{4}")]
        public const string SlotDot5 = SlotDot4 + Dot + Slot4;

        [RenderPattern(1, "{0} ")]
        public const string RSpace = "{0} ";

        [RenderPattern(1, " {0}")]
        public const string LSpace = " {0}";
    }
}