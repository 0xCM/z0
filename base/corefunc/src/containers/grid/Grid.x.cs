//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;

    partial class xfunc
    {        

        public static string Format(this GridMap map, int? colpad = null, char? delimiter = null)
            => GridLayout.format(map, colpad, delimiter);

        public static string Format(this GridStats stats, int? colpad = null, char? delimiter = null)
            => GridLayout.format(stats, colpad, delimiter);

        /// <summary>
        /// Calculates a grid layout from a specification
        /// </summary>
        /// <param name="spec">The grid specification that characterizes the layout</param>
        /// <typeparam name="T">The storage type</typeparam>
        public static GridMap Map(this GridSpec spec)
            => GridLayout.map(spec);

        public static GridStats Stats(this GridMap map)
            => GridLayout.stats(map);

        public static GridStats Stats(this GridSpec spec)
            => GridLayout.stats(GridLayout.map(spec));

    }

}