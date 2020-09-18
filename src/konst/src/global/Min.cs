//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct Konst
    {
        /// <summary>
        /// The smallest representable uint8 value
        /// </summary>
        public const byte Min8u = (byte)Limits.Min8u;

        /// <summary>
        /// The smallest representable int8 value
        /// </summary>
        public const sbyte Min8i = (sbyte)Limits.Min8i;

        /// <summary>
        /// The smallest representable uint16 value
        /// </summary>
        public const ushort Min16u = (ushort)Limits.Min16u;

        /// <summary>
        /// The smallest representable int16 value
        /// </summary>
        public const short Min16i = (short)Limits.Min16i;

        /// <summary>
        /// The smallest representable uint16 value
        /// </summary>
        public const uint Min32u = (uint)Limits.Min32u;

        /// <summary>
        /// The minimum representable <see cref='int'/> value
        /// </summary>
        public const int Min32i = int.MinValue;

        /// <summary>
        /// The minimum representable <see cref='long'/> value
        /// </summary>
        public const long Min64i = long.MinValue;

        /// <summary>
        /// The minimum representable <see cref='ulong'/> value
        /// </summary>
        public const ulong Min64u = ulong.MinValue;

        /// <summary>
        /// The minimum representable <see cref='float'/> value
        /// </summary>
        public const float Min32f = float.MinValue;

        /// <summary>
        /// The minimum representable <see cref='double'/> value
        /// </summary>
        public const double Min64f = double.MinValue;

        /// <summary>
        /// The minimum representable <see cref='decimal'/> value
        /// </summary>
        public const decimal Min128f = decimal.MinValue;
    }
}