//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static AsciCharText;

    partial struct RenderPatterns
    {
        public const string Currency = "c";

        public const string Decimal = "d";

        public const string Exp = "e";

        public const string Fixed = "f";

        public const string General = "g";

        public const string Number = "n";

        public const string Percent = "p";

        public const string RoundTrip = "r";

        public const string SmallHex = "x";

        /// <summary>
        /// Defines the literal '{0}'
        /// </summary>
        [FormatPattern("{0}")]
        public const string Slot0 = OpenSlot + D0 + CloseSlot;

        /// <summary>
        /// Defines the literal '{1}'
        /// </summary>
        [FormatPattern("{1}")]
        public const string Slot1 = OpenSlot + D1 + CloseSlot;

        /// <summary>
        /// Defines the literal '{2}'
        /// </summary>
        [FormatPattern("{2}")]
        public const string Slot2 = OpenSlot + D2 + CloseSlot;

        /// <summary>
        /// Defines the literal '{3}'
        /// </summary>
        [FormatPattern("{3}")]
        public const string Slot3 = OpenSlot + D3 + CloseSlot;

        /// <summary>
        /// Defines the literal '{4}'
        /// </summary>
        [FormatPattern("{4}")]
        public const string Slot4 = OpenSlot + D4 + CloseSlot;

        /// <summary>
        /// Defines the literal {5}'
        /// </summary>
        [FormatPattern("{5}")]
        public const string Slot5 = OpenSlot + D5 + CloseSlot;

        /// <summary>
        /// Defines the literal "{6}"
        /// </summary>
        [FormatPattern("{6}")]
        public const string Slot6 = OpenSlot + D6 + CloseSlot;

        /// <summary>
        /// Defines the literal "{7}"
        /// </summary>
        [FormatPattern("{7}")]
        public const string Slot7 = OpenSlot + D7 + CloseSlot;

        /// <summary>
        /// Defines the literal "{0} "
        /// </summary>
        [FormatPattern("{0} ")]
        public const string Slot0Space = Slot0 + Space;

        /// <summary>
        /// Defines the literal "{1} "
        /// </summary>
        [FormatPattern("{1} ")]
        public const string Slot1Space = Slot1 + Space;

        /// <summary>
        /// Defines the literal "{2} "
        /// </summary>
        [FormatPattern("{2} ")]
        public const string Slot2Space = Slot2 + Space;

        /// <summary>
        /// Defines the literal "{3} "
        /// </summary>
        [FormatPattern("{3} ")]
        public const string Slot3Space = Slot3 + Space;

        /// <summary>
        /// Defines the literal "{4} "
        /// </summary>
        [FormatPattern("{4} ")]
        public const string Slot4Space = Slot4 + Space;

        /// <summary>
        /// Defines the literal "{5} "
        /// </summary>
        [FormatPattern("{5} ")]
        public const string Slot5Space = Slot5 + Space;
    }
}