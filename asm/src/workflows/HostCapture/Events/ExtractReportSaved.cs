//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;

    public readonly struct ExtractReportSaved : IAppEvent<ExtractReportSaved, FilePath>
    {        
        public static ExtractReportSaved Empty => Define(ApiHostUri.Empty, typeof(void), 0, FilePath.Empty);
        
        [MethodImpl(Inline)]
        public static ExtractReportSaved Define(ApiHostUri host, Type type, int records, FilePath target)
            => new ExtractReportSaved(host,type,records,target);

        [MethodImpl(Inline)]
        ExtractReportSaved(ApiHostUri host, Type type, int records, FilePath target)
        {
            this.Host = host;
            this.ReportType = type;
            this.RecordCount = records;
            this.TargetPath = target;
        }

        public readonly ApiHostUri Host;        

        public readonly Type ReportType;

        public readonly int RecordCount;

        public readonly FilePath TargetPath;

        public string Description 
            => $"{RecordCount} {ReportType.DisplayName()} records saved to {TargetPath}";

        public FilePath EventData 
            => TargetPath;

        public string Format() 
            => Description;

        public override string ToString() 
            => Format();    
    }
}