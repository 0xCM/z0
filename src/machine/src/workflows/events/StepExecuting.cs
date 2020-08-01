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

    public readonly struct StepExecuting : IAppEvent<StepExecuting>
    {        
        const string Pattern = "{0}: {1} executing";

        public readonly StringRef Worker;

        public readonly ulong Correlation;        

        public readonly Timestamp Timestamp;            

        public readonly string Detail;

        public AppMsgColor Flair => AppMsgColor.Magenta;

        [MethodImpl(Inline)]
        public StepExecuting(string worker, ulong ct = 0)
        {
            Worker = worker;
            Correlation = ct;
            Timestamp = now();
            Detail = EmptyString;
        }

        [MethodImpl(Inline)]
        public StepExecuting(string worker, string detail, ulong ct = 0)
        {
            Worker = worker;
            Correlation = ct;
            Timestamp = now();
            Detail = detail;
        }

        public string Format()
            => text.concat(text.format(Pattern, Timestamp.Format(), Worker.Format()), text.empty(Detail) ? EmptyString : text.embrace(Detail));

        public string Description
        {
            get => Format();
        }

        public override string ToString()
            => Format();
    }
}