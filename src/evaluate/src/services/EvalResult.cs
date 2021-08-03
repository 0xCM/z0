//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Describes the outcome of a test case
    /// </summary>
    public struct EvalResult : IRecord<EvalResult>
    {
        public EvalAspectKey FieldKind => EvalAspectKey.Sequence;

        public int Sequence;

        public string CaseName;

        public EvalStatusKind Status;

        public Duration Duration;

        public DateTime Timestamp;

        public string Message;

        public EvalResult(int seq, string name, bool succeeded, Duration duration, string message)
        {
            Sequence = seq;
            CaseName = name;
            Status = succeeded ? EvalStatusKind.Passed : EvalStatusKind.Failed;
            Duration = duration;
            Timestamp = DateTime.Now;
            Message = message ?? "Empty result!";
        }
    }
}