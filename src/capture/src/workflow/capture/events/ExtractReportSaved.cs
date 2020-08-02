//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
        
    public readonly struct ExtractReportSaved : IAppEvent<ExtractReportSaved>
    {        
        public readonly ApiHostUri Host;        

        public readonly Type ReportType;

        public readonly int RecordCount;

        public readonly FilePath TargetPath;
        
        [MethodImpl(Inline)]
        public ExtractReportSaved(ApiHostUri host, Type type, int records, FilePath target)
        {
            Host = host;
            ReportType = type;
            RecordCount = records;
            TargetPath = target;
        }

        public string Format()
            => $"{RecordCount} {ReportType.DisplayName()} records saved to {TargetPath}";

        public ExtractReportSaved Zero 
            => Empty;

        public AppMsgColor Flair 
            => AppMsgColor.Cyan;

        public static ExtractReportSaved Empty 
            => new ExtractReportSaved(ApiHostUri.Empty, typeof(void), 0, FilePath.Empty);
    }
}