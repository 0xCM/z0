//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Part;

    [ApiHost]
    public readonly partial struct Streams
    {
        /// Allocates a caller-disposed reader for the source
        /// </summary>
        /// <param name="src">The source stream</param>
        [Op]
        public static StreamReader reader(Stream src)
            => new StreamReader(src);
    }
}