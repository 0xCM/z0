//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;
    using System.Text;

    using static Konst;

    partial struct FS
    {
        /// <summary>
        /// Opens a <see cref='FileStream'/>
        /// </summary>
        /// <param name="path">The file path</param>
        /// <param name="mode">The stream mode</param>
        /// <param name="access">The stream access spec</param>
        /// <param name="share">Sharing options</param>
        [MethodImpl(Inline), Op]
        public static FileStream stream(FS.FilePath path, FileMode mode = FileMode.OpenOrCreate, FileAccess access = FileAccess.Write, FileShare share = FileShare.Read)
            => new FileStream(path.CreateParentIfMissing().Name, mode, access, share);

        /// <summary>
        /// Writes text data to the target
        /// </summary>
        /// <param name="src">The source content</param>
        /// <param name="dst">The target stream</param>
        /// <param name="encoding">The encoding to use, which defaults to <see cref='Encoding.UTF8'/> if unspecified</param>
        [Op]
        public static uint write(string src, FileStream dst, Encoding encoding = null)
        {
            encoding = encoding ?? Encoding.UTF8;
            var data = encoding.GetBytes(src);
            dst.Seek(0, SeekOrigin.End);
            dst.Write(data, 0, data.Length);
            dst.Flush();
            return (uint)data.Length;
        }
    }
}