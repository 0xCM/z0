//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.IO;

    using static Konst;

    partial class XTend
    {
        /// <summary>
        /// Creates a reader initialized with the source file; caller-disposal required
        /// </summary>
        /// <param name="src">The file path</param>
        public static StreamReader Reader(this FilePath src)
            => new StreamReader(src.Name);

        public static StreamWriter Writer(this FilePath dst, FileWriteMode mode)
            => new StreamWriter(dst.CreateParentIfMissing().Name, mode == FileWriteMode.Append);

        /// <summary>
        /// Creates an overwriting and caller-disposed stream writer that targets a specified path
        /// </summary>
        /// <param name="dst">The file path</param>
        public static StreamWriter Writer(this FilePath dst)
            => new StreamWriter(dst.CreateParentIfMissing().Name, false);

        public static PartFileWriter<T> Writer<T>(this FilePath dst)
            where T : ITextual
                => new PartFileWriter<T>(dst);

        public static BinaryWriter BinaryWriter(this FilePath dst)
            => new BinaryWriter(File.Open(dst.CreateParentIfMissing().Name, FileMode.Create));
    }
}