//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;


    public static class LogX
    {
    
        /// <summary>
        /// Creates a fully-qualified log file path
        /// </summary>
        /// <param name="area">The area</param>
        /// <param name="file">The filename</param>
        public static FilePath TargetPath(this LogArea area, FileName file)
            => LogPaths.The.TargetPath(area,file);

        /// <summary>
        /// Creates a log writer that must be disposed by the caller
        /// </summary>
        /// <param name="area">The target area</param>
        /// <param name="file">The name of the log file</param>
        public static StreamWriter LogWriter(this LogArea area, FileName file)
            => new StreamWriter(LogPaths.The.TargetPath(area,file).ToString());

        /// <summary>
        /// Creates a log writer that must be disposed by the caller
        /// </summary>
        /// <param name="area">The target area</param>
        /// <param name="subfolder">The area subfolder</param>
        /// <param name="file">The name of the log file</param>
        public static StreamWriter LogWriter(this LogArea area, FolderName subfolder, FileName file)
            => new StreamWriter(LogPaths.The.TargetPath(area, subfolder, file).ToString());
    }
}
