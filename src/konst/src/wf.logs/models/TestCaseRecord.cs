//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;
    using static memory;

    public enum TestCaseField : uint
    {
        CaseName = 0 | (60 << WidthOffset),

        Passed =  1 | (14 << WidthOffset),

        Duration = 2  | (14 << WidthOffset),

        Started =  3 | (26 << WidthOffset),

        Finished =  4 | (26 << WidthOffset),

        Message = 5 | (32 << WidthOffset)
    }

    public readonly struct TestCaseRecords
    {
        const string Delimiter = "| ";

        public const uint CasePad = (uint)TestCaseField.CaseName >> WidthOffset;

        public const uint StartedPad = (uint)TestCaseField.Started >> WidthOffset;

        public const uint FinishedPad = (uint)TestCaseField.Finished >> WidthOffset;

        public const uint DurationPad = (uint)TestCaseField.Duration >> WidthOffset;

        public const uint PassedPad = (uint)TestCaseField.Passed >> WidthOffset;

        public const uint MessagePad = (uint)TestCaseField.Message >> WidthOffset;

        public static void render(in TestCaseRecord src, ITextBuffer dst)
        {
            dst.AppendPadded(src.CaseName, CasePad, Delimiter);
            dst.AppendPadded(src.Passed, PassedPad, Delimiter);
            dst.AppendPadded(src.Duration, DurationPad, Delimiter);
            dst.AppendPadded(src.Started, StartedPad, Delimiter);
            dst.AppendPadded(src.Finished, FinishedPad, Delimiter);
            dst.AppendPadded(src.Message, MessagePad, Delimiter);
        }

        public static string format(in TestCaseRecord src, char delimiter = FieldDelimiter)
        {
            var dst = Buffers.text();
            render(src, dst);
            return dst.Emit();
        }
    }

    /// <summary>
    /// Describes the outcome of a test case
    /// </summary>
    public struct TestCaseRecord : IRecord<TestCaseRecord>, ITextual
    {
        public utf8 CaseName;

        public bool Passed;

        public Timestamp Started;

        public Timestamp Finished;

        public Duration Duration;

        public string Message;

        public static TestCaseRecord define(string name, bool succeeded, Duration duration)
            => new TestCaseRecord(name, succeeded, duration, EmptyString);

        public static TestCaseRecord define(string name, bool succeeded, Timestamp started, Timestamp finished, Duration duration, string msg = EmptyString)
            => new TestCaseRecord(name, succeeded, started, finished, duration, msg);

        internal TestCaseRecord(string name, bool succeeded, Timestamp started, Timestamp finished, Duration duration, string msg)
        {
            CaseName = name ?? "<missing_name>";
            Passed = succeeded;
            Duration = duration;
            Started = started;
            Message = msg;
            Finished = finished;
        }

        internal TestCaseRecord(string name, bool succeeded, Duration duration, string msg)
        {
            CaseName = name ?? "<missing_name>";
            Passed = succeeded;
            Duration = duration;
            Started = root.now();
            Message = msg;
            Finished = root.now();
        }

        public string Format()
            => TestCaseRecords.format(this);
    }
}