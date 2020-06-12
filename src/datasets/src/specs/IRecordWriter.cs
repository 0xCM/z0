//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;


    public interface IRecordWriter
    {             
        R[] Save<F,R>(R[] src, FilePath dst, Func<R,string> formatter, char delimiter = Chars.Pipe)
                    where F : unmanaged, Enum
                    where R : IRecord;        

        R[] Save<F,R>(R[] src, FilePath dst, Func<R,string> formatRecord, Func<int,F,string> formatLabel,  char delimiter = Chars.Pipe)
                    where F : unmanaged, Enum
                    where R : IRecord;

        Option<FilePath> Save<F,R>(R[] src, FilePath dst, FileWriteMode mode = FileWriteMode.Overwrite)
                    where R : IRecord
                    where F : unmanaged, Enum;

        Option<FilePath> Save<F,R>(R[] data, TabularFormat format, FilePath dst, FileWriteMode mode = FileWriteMode.Overwrite)
                    where R : IRecord
                    where F : unmanaged, Enum;                    
    }
}