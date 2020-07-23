//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    
    using F = EvalResultField;
    using R = EvalResult;

    public enum EvalResultField : uint
    {
        Sequence = 0 | (10u << WidthOffset),

        CaseName =  1 | (70u << WidthOffset),

        Status =  2 | (10 << WidthOffset),

        Duration = 3  | (14u << WidthOffset),
        
        Timestamp =  4 | (26u << WidthOffset),

        Message = 5 | (20u << WidthOffset)
    }

    public enum EvalStatus : byte
    {
        Failed = 0,

        Passed = 1
    }

    /// <summary>
    /// Describes the outcome of a test case
    /// </summary>
    public readonly struct EvalResult : ITabular<F,R>, ISequential
    {        
        public readonly int Sequence;

        public readonly string CaseName;

        public readonly EvalStatus Status;

        public readonly Duration Duration;

        public readonly DateTime Timestamp;

        public readonly AppMsg Message;

        public static EvalResult Define<T>(int seq, in T id, Duration duration, Exception error)
            => new EvalResult(seq, $"{id}", false, duration, error != null? AppMsg.Error(error) : AppMsg.Empty);

        public static EvalResult Define<T>(int seq, in T id, Duration duration, bool succeeded)
            => new EvalResult(seq, $"{id}", succeeded, duration, AppMsg.Empty);

        public static EvalResult Define<T>(int seq, in T id, Duration duration, AppMsg message)
            => new EvalResult(seq,$"{id}", message.Kind != AppMsgKind.Error, duration, message);

        public static EvalResult Define<T>(uint seq, in T id, Duration duration, Exception error)
            => new EvalResult((int)seq, $"{id}", false, duration, error != null? AppMsg.Error(error) : AppMsg.Empty);

        public static EvalResult Define<T>(uint seq, in T id, Duration duration, bool succeeded)
            => new EvalResult((int)seq, $"{id}", succeeded, duration, AppMsg.Empty);

        public static EvalResult Define<T>(uint seq, in T id, Duration duration, AppMsg message)
            => new EvalResult((int)seq,$"{id}", message.Kind != AppMsgKind.Error, duration, message);

        public EvalResult(int seq, string name, bool succeeded, Duration duration, AppMsg message)
        {
            this.Sequence = seq;
            this.CaseName = name;
            this.Status = succeeded ? EvalStatus.Passed : EvalStatus.Failed;
            this.Duration = duration;
            this.Timestamp = DateTime.Now;
            this.Message = message;
        }
        
        public string DelimitedText(char delimiter)
        {            
            var dst = DataFields.formatter<F>(delimiter);
            dst.Append(F.Sequence, Sequence);
            dst.Delimit(F.CaseName, CaseName);
            dst.Delimit(F.Status, Status);
            dst.Delimit(F.Duration, Duration);            
            dst.Delimit(F.Timestamp, Timestamp);
            dst.Delimit(F.Message, Message);
            return dst.ToString();
        }        

        int ISequential.Sequence 
            => Sequence;
    }
}