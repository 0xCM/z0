//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;

    using static Seed;
 
    public interface IAppDataLog : IReportSink
    {}

    class AppDataLog : IAppDataLog
    {
        public static IAppDataLog Create(FilePath dst, char delimiter = Chars.Pipe, bool header = true)
            => new AppDataLog(dst, delimiter, header);

        readonly FilePath Target;

        readonly char Delimiter;

        readonly bool Header;

        AppDataLog(FilePath dst, char delimiter, bool header)
        {
            this.Target = dst;
            this.Delimiter = delimiter;
            this.Header = header;
        }

        void Write(ITabular src, StreamWriter dst)
            => dst.WriteLine(src.DelimitedText(Delimiter));

        public void Deposit<R>(IReport<R> src)
            where R : ITabular<R>
        {                
            if(src.RecordCount == 0)
                return;

            using var writer = Target.Writer();

            if(Header)
                writer.WriteLine(string.Join(Delimiter, src.HeaderLabels));
            
            Control.iter(src.Records, r => Write(r,writer));
        }
        
        public void Deposit(IReport src)
        {
            if(src.RecordCount == 0)
                return;

            using var writer = Target.Writer();

            if(Header)
                writer.WriteLine(string.Join(Delimiter, src.HeaderLabels));
            
            Control.iter(src.Records, r => Write(r,writer));
        }
    }
}