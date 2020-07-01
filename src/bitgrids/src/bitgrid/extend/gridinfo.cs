//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class XTend
    {
        /// <summary>
        /// Calculates a grid layout from a specification
        /// </summary>
        /// <param name="spec">The grid specification that characterizes the layout</param>
        /// <typeparam name="T">The storage type</typeparam>
        public static GridMetrics Map(this GridSpec spec)
            => new GridMetrics(spec);

        public static GridStats Stats(this GridMetrics map)
            => GridStats.Define(map);
    }
}