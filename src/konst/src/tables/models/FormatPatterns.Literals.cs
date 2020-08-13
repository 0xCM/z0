//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static AsciCharText;

    public readonly partial struct FormatPatterns
    {
        /// <summary>
        /// Defines the literal '{'
        /// </summary>
        public const string OpenSlot = LBrace;

        /// <summary>
        /// Defines the literal '}'
        /// </summary>
        public const string CloseSlot = RBrace;
        
        /// <summary>
        /// Defines the literal '"{'
        /// </summary>
        public const string OpenQSlot = DQuote + LBrace;

        /// <summary>
        /// Defines the literal '"}'
        /// </summary>
        public const string CloseQSlot = RBrace + DQuote;
        
        /// <summary>
        /// Defines the literal '"{0}"'
        /// </summary>
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
        public const string Pipe1 = Pipe + Space + Slot0;

        /// <summary>
        /// Defines the literal | {0} | {1}
        /// </summary>
        public const string Pipe2 = Pipe1 + SpacePipe + Space + Slot1;
        
        /// <summary>
        /// Defines the literal '| {0} | {1} | {2}'
        /// </summary>
        public const string Pipe3 = Pipe2 + SpacePipe + Space + Slot2;

        /// <summary>
        /// Defines the literal '| {0} | {1} | {2} | {3}'
        /// </summary>
        public const string Pipe4 = Pipe3 + SpacePipe + Space + Slot3;

        /// <summary>
        /// Defines the literal '| {0} | {1} | {2} | {3} | {4}'
        /// </summary>
        public const string Pipe5 = Pipe4 + SpacePipe + Space + Slot4;

        /// <summary>
        /// Defines the literal '| {0} | {1} | {2} | {3} | {4} | {5}'
        /// </summary>
        public const string Pipe6 = Pipe5 + SpacePipe + Space + Slot5;

        /// <summary>
        /// Defines the literal '"{0}": "{1}"'
        /// </summary>
        public const string JsonProp = QSlot0 + Colon + Space + QSlot1;        

        /// <summary>
        /// Defines a right-padded slot of width 4
        /// </summary>
        public const string PS0x4 = "{0,-4}";

        /// <summary>
        /// Defines a right-padded slot of width 8
        /// </summary>
        public const string PS0x8 = "{0,-8}";

        /// <summary>
        /// Defines a right-padded slot of width 12
        /// </summary>
        public const string PS0x12 = "{0,-12}";

        /// <summary>
        /// Defines a right-padded slot of width 16
        /// </summary>
        public const string PS0x16 = "{0,-16}";

        /// <summary>
        /// Defines a right-padded slot of width 32
        /// </summary>
        public const string PS0x32 = "{0,-32}";
    }
}