//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    partial struct Konst
    {
        /// <summary>
        /// The smallest representable int8 value
        /// </summary>
        public const sbyte Min8i = (sbyte)Limits.Min8i;

        /// <summary>
        /// The smallest representable int16 value
        /// </summary>
        public const short Min16i = (short)Limits.Min16i;

        /// <summary>
        /// The minimum representable <see cref='int'/> value
        /// </summary>
        public const int Min32i = int.MinValue;

        /// <summary>
        /// The minimum representable <see cref='long'/> value
        /// </summary>
        public const long Min64i = long.MinValue;

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