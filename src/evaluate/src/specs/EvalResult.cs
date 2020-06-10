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
    public class EvalResult : ITabular<F,R>
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
        
        [TabularField(F.Sequence)]
        public int Sequence {get;}

        [TabularField(F.CaseName)]
        public string CaseName {get;}

        [TabularField(F.Status)]
        public EvalStatus Status {get;}

        [TabularField(F.Duration)]
        public readonly Duration Duration;

        [TabularField(F.Timestamp)]
        public DateTime Timestamp {get;}

        [TabularField(F.Message)]
        public AppMsg Message {get;}

        public string DelimitedText(char delimiter)
        {
            var dst = Model.Formatter.Reset(delimiter);
            dst.Append(F.Sequence, Sequence);
            dst.Delimit(F.CaseName, CaseName);
            dst.Delimit(F.Status, Status);
            dst.Delimit(F.Duration, Duration);            
            dst.Delimit(F.Timestamp, Timestamp);
            dst.Delimit(F.Message, Message);
            return dst.ToString();
        }

        static readonly Report<F,R> Model = Report<F,R>.Empty;
    }
}