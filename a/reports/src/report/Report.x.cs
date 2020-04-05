//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;

    using static Seed;

    public static class XReport
    {
        /// <summary>
        /// Appends a space to the source content
        /// </summary>
        /// <param name="content">The source content</param>
        static string rspace(object content)
            => $"{content} ";

        /// <summary>
        /// Saves an array of records to a filee
        /// </summary>
        /// <param name="records">The records to emit</param>
        /// <param name="dst">The target path</param>
        /// <param name="delimiter">The character used to demarcate record fields</param>
        /// <param name="header">Whether to emit a header row</param>
        /// <param name="overwrite">Whether to overwrite or altnernalely append to an existing file</param>
        /// <typeparam name="R">The source record type</typeparam>
        public static Option<FilePath> Save<R>(this R[] records, FilePath dst, char delimiter = Chars.Pipe, 
            bool header = true, FileWriteMode mode = FileWriteMode.Overwrite)
                where R : IRecord
                    => Reports.save(records, dst, delimiter, header, mode);
    }
}