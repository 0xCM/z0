//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using F = EvalAspectKey;
    using R = EvalResult;

    /// <summary>
    /// Describes the outcome of a test case
    /// </summary>
    public readonly struct EvalResult : ITabular<F,R>
    {
        public EvalAspectKey FieldKind => EvalAspectKey.Sequence;

        public readonly int Sequence;

        public readonly string CaseName;

        public readonly EvalStatusKind Status;

        public readonly Duration Duration;

        public readonly DateTime Timestamp;

        public readonly object Message;

        public EvalResult(int seq, string name, bool succeeded, Duration duration, object message)
        {
            Sequence = seq;
            CaseName = name;
            Status = succeeded ? EvalStatusKind.Passed : EvalStatusKind.Failed;
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