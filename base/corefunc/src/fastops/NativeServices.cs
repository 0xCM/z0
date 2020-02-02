//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;        

    using static zfunc;

    public static class NativeServices
    {
        public const int DefaultBufferLen = 1024*8;
        
        public static INativeExecBuffer ExecBuffer(int? size = null)
            => NativeExecBuffer.Create(size);

        /// <summary>
        /// Allocates a caller-disposed native text writer
        /// </summary>
        /// <param name="dst">The target path</param>
        /// <param name="header">Whether to emit a header when creating a new file or overwriting an existing file</param>
        /// <param name="append">Whether to append to or overwrite an existing file</param>
        public static INativeWriter Writer(FilePath dst, bool header = true, bool append = false)
        {
            dst.FolderPath.CreateIfMissing();            
            var exists = dst.Exists();
            var writer = NativeWriter.Create(dst,append);
            
            if(!exists || !append && header)
                writer.WriteHeader();
            return writer;
        }

    }
}