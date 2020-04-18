//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    using E = AsmEvents.ExtractReportSaved;

    partial class AsmEvents
    {
        public readonly struct ExtractReportSaved : IAppEvent<E, FilePath>
        {        
            public static E Empty => Define(ApiHostUri.Empty, typeof(void), 0, FilePath.Empty);
            
            [MethodImpl(Inline)]
            public static E Define(ApiHostUri host, Type type, int records, FilePath target)
                => new E(host,type,records,target);

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

            public FilePath Payload 
                => TargetPath;

            public E Zero => Empty;

            public AppMsgColor Flair => AppMsgColor.Cyan;
        }
    }
}