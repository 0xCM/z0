//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Collections.Generic;

    using static Seed;

    public enum LogWriteMode
    {
        Create,
        
        Overwrite,
        
        Append
    }

    public interface IRecordLogger : IService
    {
        void Save<R>(R[] src, FilePath dst)
            where R : IRecord;                
    }

}