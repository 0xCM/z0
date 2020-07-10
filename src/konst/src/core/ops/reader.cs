//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    using static Konst;

    partial struct z
    {
        /// <summary>
        /// Allocates a caller-disposed reader for the source
        /// </summary>
        /// <param name="src">The source stream</param>
        public static StreamReader reader(Stream src)
            => new StreamReader(src);
    }
}