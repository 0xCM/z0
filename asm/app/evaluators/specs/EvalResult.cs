//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using F = EvalResultField;
    using R = EvalResult;

    public enum EvalResultField : ulong
    {
        Sequence = 0 | (10ul << 32),

        CaseName =  1 | (70ul << 32),

        Status =  2 | (10 << 32),

        Duration = 3  | (14ul << 32),
        
        Timestamp =  4 | (26ul << 32),

        Message = 5
    }

    public enum EvalStatus : byte
    {
        Failed = 0,

        Passed = 1
    }

    /// <summary>
    /// Describes the outcome of a test case
    /// </summary>
    public class EvalResult : IRecord<F,R>
    {        
        public static EvalResult Define<T>(int seq, in T id, Duration duration, Exception error)
            => new EvalResult(seq, $"{id}", false, duration, error != null? AppMsg.Error(error) : AppMsg.Empty);

        public static EvalResult Define<T>(int seq, in T id, Duration duration, bool succeeded)
            => new EvalResult(seq, $"{id}", succeeded, duration, AppMsg.Empty);

        public static EvalResult Define<T>(int seq, in T id, Duration duration, AppMsg message)
            => new EvalResult(seq,$"{id}", message.Kind != AppMsgKind.Error, duration, message);

        EvalResult(int seq, string name, bool succeeded, Duration duration, AppMsg message)
        {
            this.Sequence = seq;
            this.CaseName = name;
            this.Status = succeeded ? EvalStatus.Passed : EvalStatus.Failed;
            this.Duration = duration;
            this.Timestamp = DateTime.Now;
            this.Message = message;
        }
        
        [ReportField(F.Sequence)]
        public int Sequence {get;}

        [ReportField(F.CaseName)]
        public string CaseName {get;}

        [ReportField(F.Status)]
        public EvalStatus Status {get;}

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