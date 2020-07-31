//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;
        
    using static Konst;
    using static z;

    public readonly struct StepExecuted : IAppEvent<StepExecuted>
    {
        const string Pattern = "{0} step completed at {1}";

        public readonly StringRef Worker;

        public readonly ulong Correlation;        

        public readonly Timestamp Timestamp;      

        public readonly string Detail;

        public AppMsgColor Flair => AppMsgColor.Cyan;

        [MethodImpl(Inline)]
        public StepExecuted(string worker, ulong ct = 0)
        {
            Worker = worker;
            Correlation = ct;
            Timestamp = now();
            Detail = EmptyString;
        }

        [MethodImpl(Inline)]
        public StepExecuted(string worker, string detail, ulong ct = 0)
        {
            Worker = worker;
            Correlation = ct;
            Timestamp = now();
            Detail = detail;
        }


        public string Format()
            => text.concat(text.format(Pattern, Worker.Format(), Timestamp.Format()), text.empty(Detail) ? EmptyString : text.embrace(Detail));
        
        public string Description
        {
            get => Format();
        }

        public override string ToString()
            => Format();
    }
}