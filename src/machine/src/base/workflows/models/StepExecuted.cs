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

        [MethodImpl(Inline)]
        public StepExecuted(string worker, ulong ct = 0)
        {
            Worker = worker;
            Correlation = ct;
            Timestamp = now();
        }

        public string Format()
        {
            return text.format(Pattern, Worker.Format(), Timestamp.Format());
        }
        
        public string Description
        {
            get => Format();
        }

        public override string ToString()
            => Format();


    }
}