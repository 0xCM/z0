//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    using static zfunc;

    public enum LogArea
    {
        Test,

        Bench,

        App,

    }

    public interface ILogTarget
    {
        LogArea Area {get;}

        string Name {get;}
    }
    
    /// <summary>
    /// Defines minimal contract for a log message sink
    /// </summary>
    public interface ILogger
    {
        void Log(IEnumerable<AppMsg> src);
        
        void Log(AppMsg src);

        void Log<R>(IEnumerable<R> records, LogTarget target, char delimiter, bool header = true, bool create = true, FileExtension ext = null)
                where R : IRecord;

        void Log<R>(IEnumerable<R> records, string topic, char delimiter, bool header = true, bool create = true, FileExtension ext = null)
            where R : IRecord;            
                
    }


}