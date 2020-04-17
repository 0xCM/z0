//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Collections.Generic;
    using System.Linq;

    using static Seed;

    public struct RecordLogger : IRecordLogger
    {
        public static IRecordLogger Create(char sep = Chars.Pipe, bool header = true, LogWriteMode mode = LogWriteMode.Overwrite)
            => new RecordLogger(sep, header, mode);

        public char FieldSep {get;}

        public bool EmitHeader {get;}
                
        public LogWriteMode Mode {get;}                
        
        RecordLogger(char sep, bool header, LogWriteMode mode)
        {
            FieldSep = sep;
            EmitHeader = header;
            Mode = mode;
        }

        public void Save<R>(R[] records, FilePath dst)
            where R : IRecord
        {                
            if(records.Length == 0)
                return;

            var exists = dst.Exists();
            var header = exists ? false : EmitHeader;
            using var writer = dst.Writer(Mode == LogWriteMode.Append);
            
            if(header)
                dst.AppendLine(string.Join(FieldSep, records[0].HeaderNames));
            
            for(var i=0; i<records.Length; i++)
                writer.WriteLine(records[i].DelimitedText(FieldSep));            
        }
    }
}