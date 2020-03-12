//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Validation
{
    using System;
    using System.Collections.Generic;
    
    using static Root;

    using F = AsmExecField;
    using R = AsmExecResult;
        
    public enum AsmExecField : ulong
    {
        Sequence = 0 | (10ul << 32),

        CaseName =  1 | (70ul << 32),

        Status =  2 | (10 << 32),

        Duration = 3  | (14ul << 32),
        
        Timestamp =  4 | (26ul << 32),

        Message = 5
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
        public static AsmExecResult Define<T>(int seq, in T id, Duration duration, Exception error)
            => new AsmExecResult(seq, $"{id}", false, duration, error != null? AppMsg.Error(error) : AppMsg.Empty);

        public static AsmExecResult Define<T>(int seq, in T id, Duration duration, bool succeeded)
            => new AsmExecResult(seq, $"{id}", succeeded, duration, AppMsg.Empty);

        public static AsmExecResult Define<T>(int seq, in T id, Duration duration, AppMsg message)
            => new AsmExecResult(seq,$"{id}", message.Kind != AppMsgKind.Error, duration, message);

        // public static AsmExecResult Define(int seq, in ConstPair<OpUri> paired, Duration duration, Exception error)
        //     => new AsmExecResult(seq, paired, false, duration, error != null? AppMsg.Error(error) : AppMsg.Empty);

        // public static AsmExecResult Define(int seq, in ConstPair<OpUri> paired, Duration duration, bool succeeded)
        //     => new AsmExecResult(seq, paired, succeeded, duration, AppMsg.Empty);

        // public static AsmExecResult Define(int seq, in ConstPair<OpUri> paired, Duration duration, AppMsg message)
        //     => new AsmExecResult(seq, paired, message.Kind != AppMsgKind.Error, duration, message);

        AsmExecResult(int seq, string name, bool succeeded, Duration duration, AppMsg message)
        {
            this.Sequence = seq;
            this.CaseName = name;
            this.Status = succeeded ? AsmExecStatus.Passed : AsmExecStatus.Failed;
            this.Duration = duration;
            this.Timestamp = DateTime.Now;
            this.Message = message;
        }
        

        [ReportField(F.Sequence)]
        public int Sequence {get;}

        [ReportField(F.CaseName)]
        public string CaseName {get;}

        [ReportField(F.Status)]
        public AsmExecStatus Status {get;}

        [ReportField(F.Duration)]
        public readonly Duration Duration;

        [ReportField(F.Timestamp)]
        public DateTime Timestamp {get;}

        [ReportField(F.Message)]
        public AppMsg Message {get;}

        public string DelimitedText(char delimiter)
        {
            var dst = Model.Formatter.Reset();
            dst.AppendField(F.Sequence, Sequence);
            dst.DelimitField(F.CaseName, CaseName, delimiter);
            dst.DelimitField(F.Status, Status, delimiter);
            dst.DelimitField(F.Duration, Duration, delimiter);            
            dst.DelimitField(F.Timestamp, Timestamp, delimiter);
            dst.DelimitField(F.Message, Message, delimiter);
            return dst.ToString();
        }

        static readonly Report<F,R> Model = Report<F,R>.Empty;
    }
}