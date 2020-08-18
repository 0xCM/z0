//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using static AsciCharText;
    using A = AsciChar;
    using T = AsciCharText;

    [LiteralProvider]
    public readonly partial struct RenderPatterns
    {
        /// <summary>
        /// Pluralizes something
        /// </summary>
        [StringLiteral("s")]
        public const string Plural = "s";

        /// <summary>
        /// Suffix used to pluralize a possessive
        /// </summary>
        [StringLiteral("'s")]
        public const string PluralPosses = "'s";

        /// <summary>
        /// Defines the default field delimiter
        /// </summary>
        [StringLiteral(" | ")]
        public const string FieldSep = " | ";

        /// <summary>
        /// Defines the literal '->'
        /// </summary>
        [StringLiteral("|")]
        public const string Pipe = "|";

        /// <summary>
        /// Defines the literal '->'
        /// </summary>
        [StringLiteral("->")]
        public const string Arrow = "->";

        /// <summary>
        /// Defines the literal '.'
        /// </summary>
        [StringLiteral(".")]
        public const string Dot = ".";

        /// <summary>
        /// Defines the default extension delimiter
        /// </summary>
        [StringLiteral(".")]
        public const string ExtSep = Dot;
        
        /// <summary>
        /// Defines the literal '('
        /// </summary>
        public const string OpenTuple = "(";

        /// <summary>
        /// Defines the literal ')'
        /// </summary>
        public const string CloseTuple = ")";

        /// <summary>
        /// Defines the default extension for structured data
        /// </summary>
        public const string DataExt = "csv";

        /// <summary>
        /// Defines the default extension for structured data
        /// </summary>
        public const string Dash40 = "----------------------------------------";

        /// <summary>
        /// Defines the default extension for structured data
        /// </summary>
        [StringLiteral("--------------------------------------------------------------------------------")]
        public const string Dash80 = Dash40 + Dash40;

        /// <summary>
        /// Defines the default extension for structured data
        /// </summary>
        [StringLiteral("------------------------------------------------------------------------------------------------------------------------")]
        public const string Dash120 = Dash80 + Dash40;

        /// <summary>
        /// Defines the default extension for structured data
        /// </summary>
        [StringLiteral("----------------------------------------------------------------------------------------------------------------------------------------------------------------")]
        public const string Dash160 = Dash80 + Dash80;

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
        /// Defines the literal '{0}'
        /// </summary>
        public const string Slot0 = OpenSlot + D0 + CloseSlot;
        
        /// <summary>
        /// Defines the literal '{1}'
        /// </summary>
        public const string Slot1 = OpenSlot + D1 + CloseSlot;

        /// <summary>
        /// Defines the literal '{2}'
        /// </summary>
        public const string Slot2 = OpenSlot + D2 + CloseSlot;

        /// <summary>
        /// Defines the literal '{3}'
        /// </summary>
        public const string Slot3 = OpenSlot + D3 + CloseSlot;

        /// <summary>
        /// Defines the literal "{4}"
        /// </summary>
        public const string Slot4 = OpenSlot + D4 + CloseSlot;

        /// <summary>
        /// Defines the literal "{5}"
        /// </summary>
        public const string Slot5 = OpenSlot + D5 + CloseSlot;

        /// <summary>
        /// Defines the literal "{6}"
        /// </summary>
        public const string Slot6 = OpenSlot + D6 + CloseSlot;

        /// <summary>
        /// Defines the literal "{7}"
        /// </summary>
        public const string Slot7 = OpenSlot + D7 + CloseSlot;

        /// <summary>
        /// Defines the literal " |"
        /// </summary>
        public const string SpacePipe = Space + Pipe;

        /// <summary>
        /// Defines the literal '| {0}'
        /// </summary>
        public const string PSx1 = Pipe + Space + Slot0;

        /// <summary>
        /// Defines the literal | {0} | {1}
        /// </summary>
        public const string PSx2 = PSx1 + SpacePipe + Space + Slot1;
        
        /// <summary>
        /// Defines the literal '| {0} | {1} | {2}'
        /// </summary>
        public const string PSx3 = PSx2 + SpacePipe + Space + Slot2;

        /// <summary>
        /// Defines the literal '| {0} | {1} | {2} | {3}'
        /// </summary>
        public const string PSx4 = PSx3 + SpacePipe + Space + Slot3;

        /// <summary>
        /// Defines the literal '| {0} | {1} | {2} | {3} | {4}'
        /// </summary>
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
        /// Defines the literal " {4}"
        /// </summary>
        public const string SS4 = Space + Slot4;

        /// <summary>
        /// Defines the literal " {5}"
        /// </summary>
        public const string SS5 = Space + Slot5;

        /// <summary>
        /// Defines the literal "{0} {1}"
        /// </summary>
        public const string SSx2 = Slot0 + SS1;        

        /// <summary>
        /// Defines the literal "{0} {1} {2}"
        /// </summary>
        public const string SSx3 = Slot0 + SS1 + SS2;        

        /// <summary>
        /// Defines the literal "{1} {2}"
        /// </summary>
        public const string SS1x2 = Slot1 + SS2;

        /// <summary>
        /// Defines the literal '{1} {2} {3}'
        /// </summary>
        public const string SS1x3 = Slot0 + SS1 + SS2 + SS3;        
        
        /// <summary>
        /// Defines the literal '{0}.{1}'
        /// </summary>
        public const string SlotDot2 = Slot0 + Dot + Slot1;

        /// <summary>
        /// Defines the literal '{0}.{1}.{2}'
        /// </summary>
        public const string SlotDot3 = SlotDot2 + Dot + Slot2;
       
        public const string SlotTuple1 = OpenTuple + Slot0 + CloseTuple;

        public const string SlotTuple2 = "({0}, {1})";

        public const string SlotTuple3 = "({0}, {1}, {2})";

        public const string SlotTuple4 = "({0}, {1}, {2}, {3})";

        public const string SlotTuple5 = "({0}, {1}, {2}, {3}, {4})";

        public const string SlotTuple6 = "({0}, {1}, {2}, {3}, {4}, {5})";

        public const string SlotTuple7 = "({0}, {1}, {2}, {3}, {4}, {5}, {6})";  

        public const string SlotArrow2 = "{0} -> {1}";      

        public const string SlotArrow3 = "{0} -> {1} -> {3}";      

        public const string SlotArrow4 = "{0} -> {1} -> {3} -> {4}";      

    }
}