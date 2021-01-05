//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;
    using System.Reflection.PortableExecutable;
    using System.IO;

    using static Part;

    partial class PeTableReader
    {
        /// <summary>
        /// Allocates a <see cref='PeTableReader'/> for a specified file
        /// </summary>
        /// <param name="src">The source path</param>
        [MethodImpl(Inline)]
        public static PeTableReader open(FS.FilePath src)
        {
            var stream = File.OpenRead(src.Name);
            var reader = new PEReader(stream);
            return new PeTableReader(new ReaderState(stream, reader));
        }
    }
}