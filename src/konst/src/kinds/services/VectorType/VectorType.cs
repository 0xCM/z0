//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    [ApiHost]
    public partial class VectorType
    {

    }

    partial class VectorType
    {
        /// <summary>
        /// Closed vector types of width 128
        /// </summary>
        public static IEnumerable<Type> Types128
            => types(z.w128);

        /// <summary>
        /// Closed vector types of width 256
        /// </summary>
        public static IEnumerable<Type> Types256
            => types(z.w256);

        /// <summary>
        /// Closed vector types of width 512
        /// </summary>
        public static IEnumerable<Type> Types512
            => types(z.w512);
    }
}