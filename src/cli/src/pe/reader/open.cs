//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.PortableExecutable;
    using System.IO;

    using static Root;

    partial class PeTableReader
    {
        [MethodImpl(Inline), Op]
        internal static PeTableReader cover(PeStream src)
            => new PeTableReader(src);

        /// <summary>
        /// Allocates a <see cref='PeTableReader'/> for a specified file
        /// </summary>
        /// <param name="src">The source path</param>
        [Op]
        public static PeTableReader open(FS.FilePath src)
        {
            var stream = File.OpenRead(src.Name);
            var reader = new PEReader(stream);
            return new PeTableReader(new PeStream(stream, reader));
        }
    }
}