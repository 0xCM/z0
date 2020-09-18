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
    public readonly struct EvalResult : ITabular<F,R>
    {
        public readonly int Sequence;

        public readonly string CaseName;

        public readonly EvalStatus Status;

        public readonly Duration Duration;

        public readonly DateTime Timestamp;

        public readonly object Message;

        public EvalResult(int seq, string name, bool succeeded, Duration duration, object message)
        {
            Sequence = seq;
            CaseName = name;
            Status = succeeded ? EvalStatus.Passed : EvalStatus.Failed;
            Duration = duration;
            Timestamp = DateTime.Now;
            Message = message ?? "Empty result!";
        }

        public string DelimitedText(char delimiter)
        {
            var dst = Table.formatter<F>(delimiter);
            dst.Append(F.Sequence, Sequence);
            dst.Delimit(F.CaseName, CaseName);
            dst.Delimit(F.Status, Status);
            dst.Delimit(F.Duration, Duration);
            dst.Delimit(F.Timestamp, Timestamp);
            dst.Delimit(F.Message, Message);
            return dst.ToString();
        }
    }
}