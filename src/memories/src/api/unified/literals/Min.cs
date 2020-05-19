//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial class Memories
    {
        /// <summary>
        /// The smallest representable value v where v:int8
        /// </summary>
        public const sbyte Min8i = sbyte.MinValue;

        /// <summary>
        /// The smallest representable value v where v:int16
        /// </summary>
        public const short Min16i = short.MinValue;

        /// <summary>
        /// The smallest representable value v where v:int32
        /// </summary>
        public const int Min32i = int.MinValue;

        /// <summary>
        /// The smallest representable value v where v:int64
        /// </summary>
        public const long Min64i = long.MinValue;

        /// <summary>
        /// The smallest representable value v where v:float32
        /// </summary>
        public const float Min32f = float.MinValue;

        /// <summary>
        /// The smallest representable value v where v:float64
        /// </summary>
        public const double Min64f = double.MinValue;
    }
}