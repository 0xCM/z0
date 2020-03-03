//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public static class GridInfoX
    {
        /// <summary>
        /// Calculates a grid layout from a specification
        /// </summary>
        /// <param name="spec">The grid specification that characterizes the layout</param>
        /// <typeparam name="T">The storage type</typeparam>
        public static GridMap Map(this GridSpec spec)
            => GridMap.Define(spec);

        public static GridStats Stats(this GridMap map)
            => GridStats.Define(map);

        public static string Format(this GridStats stats, int? colpad = null, char? delimiter = null)
            => GridStats.Format(stats, colpad, delimiter);
    }
}