//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    using static zfunc;

    public static class LogX
    {
        static LogPaths Paths
            => LogPaths.The;

        /// <summary>
        /// Creates a fully-qualified log file path
        /// </summary>
        /// <param name="area">The area</param>
        /// <param name="file">The filename</param>
        public static FilePath TargetPath(this LogArea area, FileName file)
            => Paths.TargetPath(area,file);

        /// <summary>
        /// Creates a log writer that must be disposed by the caller
        /// </summary>
        /// <param name="area">The target area</param>
        /// <param name="file">The name of the log file</param>
        public static StreamWriter LogWriter(this LogArea area, FileName file)
            => new StreamWriter(Paths.TargetPath(area,file).ToString());

        /// <summary>
        /// Creates a log writer that must be disposed by the caller
        /// </summary>
        /// <param name="area">The target area</param>
        /// <param name="subfolder">The area subfolder</param>
        /// <param name="file">The name of the log file</param>
        public static StreamWriter LogWriter(this LogArea area, FolderName subfolder, FileName file)
            => new StreamWriter(Paths.TargetPath(area, subfolder, file).ToString());

        /// <summary>
        /// Logs records to a file
        /// </summary>
        /// <param name="dst">The data receiver</param>
        /// <param name="data">The records to emit</param>
        /// <param name="delimiter">The character used to demarcate record fields</param>
        /// <param name="header">Whether to emit a header row</param>
        /// <param name="append">Whether to append to an existing file</param>
        /// <typeparam name="R">The record type</typeparam>
        public static FilePath LogRecords<R>(this FilePath dst, IEnumerable<R> data, char delimiter = AsciSym.Pipe, bool? header = null, bool append = true)
            where R : IRecord
        {            
            var records = data.ToArray();
            if(records.Length == 0)
                return FilePath.Empty;
            
            if(!append)
                dst.DeleteIfExists();
            
            var emitHeader =  header ?? (append && !dst.Exists());
            
            if(emitHeader)
                dst.Append(string.Join(delimiter, records[0].GetHeaders()));
            
            iter(data, r => dst.Append(r.DelimitedText(delimiter)));
            
            return dst;
        }

    }
}
