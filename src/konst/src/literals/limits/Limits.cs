//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Defines literals that specify numeric type limits
    /// </summary>
    public readonly struct Limits
    {
        /// <summary>
        /// The minimum representable <see cref='sbyte'/> value
        /// </summary>
        public const Limits8i Min8i = Limits8i.Min;

        /// <summary>
        /// The maximum representable <see cref='sbyte'/> value
        /// </summary>
        public const Limits8i Max8i = Limits8i.Max;

        /// <summary>
        /// The minimum representable <see cref='byte'/> value
        /// </summary>
        public const Limits8u Min8u = Limits8u.Min;

        /// <summary>
        /// The maximum representable <see cref='byte'/> value
        /// </summary>
        public const Limits8u Max8u = Limits8u.Max;

        /// <summary>
        /// The minimum representable <see cref='short'/> value
        /// </summary>
        public const Limits16i Min16i = Limits16i.Min;

        /// <summary>
        /// The maximum representable <see cref='short'/> value
        /// </summary>
        public const Limits16i Max16i = Limits16i.Max;

        /// <summary>
        /// The minimum representable <see cref='ushort'/> value
        /// </summary>
        public const Limits16u Min16u = Limits16u.Min;

        /// <summary>
        /// The maximum representable <see cref='ushort'/> value
        /// </summary>
        public const Limits16u Max16u = Limits16u.Max;

        /// <summary>
        /// The minimum representable uint24 value
        /// </summary>
        public const Limits24u Min24u = Limits24u.Min;

        /// <summary>
        /// The maximum representable <see cref='ushort'/> value
        /// </summary>
        public const Limits24u Max24u = Limits24u.Max;

        /// <summary>
        /// The minimum representable <see cref='int'/> value
        /// </summary>
        public const Limits32i Min32i = Limits32i.Min;

        /// <summary>
        /// The maximum representable <see cref='int'/> value
        /// </summary>
        public const Limits32i Max32i = Limits32i.Max;
        
        /// <summary>
        /// The minimum representable <see cref='uint'/> value
        /// </summary>
        public const Limits32u Min32u = Limits32u.Min;

        /// <summary>
        /// The maximum representable <see cref='uint'/> value
        /// </summary>
        public const Limits32u Max32u = Limits32u.Max;

        /// <summary>
        /// The minimum representable <see cref='long'/> value
        /// </summary>
        public const Limits64i Min64i = Limits64i.Min;

        /// <summary>
        /// The maximum representable <see cref='long'/> value
        /// </summary>
        public const Limits64i Max64i = Limits64i.Max;

        /// <summary>
        /// The minimum representable <see cref='ulong'/> value
        /// </summary>
        public const Limits64u Min64u = Limits64u.Min;

        /// <summary>
        /// The maximum representable <see cref='ulong'/> value
        /// </summary>
        public const Limits64u Max64u = Limits64u.Max;

        /// <summary>
        /// The minimum representable <see cref='float'/> value
        /// </summary>
        public const float Min32f = float.MinValue;
        
        /// <summary>
        /// The maximum representable <see cref='float'/> value
        /// </summary>
        public const float Max32f = float.MaxValue;

        /// <summary>
        /// The minimum representable <see cref='double'/> value
        /// </summary>
        public const double Min64f = double.MinValue;
        
        /// <summary>
        /// The maximum representable <see cref='double'/> value
        /// </summary>
        public const double Max64f = double.MaxValue;

        /// <summary>
        /// The minimum representable <see cref='decimal'/> value
        /// </summary>
        public const decimal Min128f = decimal.MinValue;
        
        /// <summary>
        /// The maximum representable <see cref='decimal'/> value
        /// </summary>
        public const decimal Max128f = decimal.MaxValue;

        /// <summary>
        /// The minimum representable <see cref='char'/> value
        /// </summary>
        public const char Min16c = char.MinValue;

        /// <summary>
        /// The maximum representable <see cref='char'/> value
        /// </summary>
        public const char Max16c = char.MaxValue;
    }
}