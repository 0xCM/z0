//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    using static Seed;
    
    public readonly struct AppMsgLog : IAppMsgLog
    {            
        public FilePath Path {get;}
        
        public AppMsgLog(FilePath dst)
        {
            this.Path = dst;
        }

        public void Write(AppMsg src)
        {
            Path.AppendLine(src.ToString());
        }

        public void Write(IEnumerable<AppMsg> src)
        {
            using var writer = Path.Writer();
            Control.iter(Formattable.items(src), item => writer.WriteLine(item));                
        }

        public void Write<R>(IReadOnlyList<R> records, char delimiter, bool header)
            where R : IRecord
        {                
            if(records.Count == 0)
                return;

            using var writer = Path.Writer();

            if(header)
                writer.WriteLine(string.Join(delimiter, records[0].HeaderNames));
            
            Control.iter(records, r => writer.WriteLine(r.DelimitedText(delimiter)));
        }

        public void Notify(AppMsg msg)
            => Write(msg);
    }
}