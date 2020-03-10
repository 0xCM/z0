//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    
    using static Root;

    using F = AsmExecField;
    using R = AsmExecResult;
        
    public enum AsmExecField : ulong
    {
        Sequence = 0 | (10ul << 32),

        Uri =  1 | (70ul << 32),

        Status =  2 | (10 << 32),

        Duration = 3  | (14ul << 32),
        
        Timestamp =  4 | (26ul << 32)
    }

    public enum AsmExecStatus : byte
    {
        Failed = 0,

        Passed = 1
    }

    /// <summary>
    /// Describes the outcome of a test case
    /// </summary>
    public class AsmExecResult : IRecord<F,R>
    {        
        public static AsmExecResult Define(int seq, OpUri uri, bool succeeded, Duration duration)
            => new AsmExecResult(seq,uri, succeeded, duration);
        
        AsmExecResult(int seq, OpUri uri, bool succeeded, Duration duration)
        {
            this.Sequence = seq;
            this.Uri = uri;
            this.Status = succeeded ? AsmExecStatus.Passed : AsmExecStatus.Failed;
            this.Duration = duration;
            this.Timestamp = DateTime.Now;
        }

        [ReportField(F.Sequence)]
        public int Sequence {get;}

        [ReportField(F.Uri)]
        public OpUri Uri {get;}

        [ReportField(F.Status)]
        public AsmExecStatus Status {get;}

        [ReportField(F.Duration)]
        public readonly Duration Duration;

        [ReportField(F.Timestamp)]
        public DateTime Timestamp {get;}

        public string DelimitedText(char delimiter)
        {
            var dst = Model.Formatter.Reset();
            dst.AppendField(F.Sequence, Sequence);
            dst.DelimitField(F.Uri, Uri, delimiter);
            dst.DelimitField(F.Status, Status, delimiter);
            dst.DelimitField(F.Duration, Duration, delimiter);            
            dst.DelimitField(F.Timestamp, Timestamp, delimiter);
            return dst.ToString();
        }

        static readonly Report<F,R> Model = Report<F,R>.Empty;
    }
}