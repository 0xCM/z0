//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;
    using static z;

    using F = TestCaseField;
    using R = TestCaseRecord;

    public enum TestCaseField : uint
    {
        CaseName = 0 | (60 << WidthOffset),

        Passed =  1 | (14 << WidthOffset),

        Duration = 2  | (14 << WidthOffset),

        Finished =  3 | (26 << WidthOffset),

        Message = 4 | (32 << WidthOffset)
    }

    public readonly struct TestCaseRecords
    {
        public static void render(in TestCaseRecord src, ITextBuffer dst, char delimiter = FieldDelimiter)
        {
            dst.AppendValue(src.CaseName, 60u, delimiter);
            dst.AppendValue(src.Passed, 14u, delimiter);
            dst.AppendValue(src.Duration, 14u, delimiter);
            dst.AppendValue(src.Finished, 26u, delimiter);
            dst.Append(src.Message, 32u, delimiter);
        }

        public static string format(in TestCaseRecord src, char delimiter = FieldDelimiter)
        {
            var dst = Buffers.text();
            render(src, dst, delimiter);
            return dst.Emit();
        }
    }

    /// <summary>
    /// Describes the outcome of a test case
    /// </summary>
    public struct TestCaseRecord : ITabular<F,R>
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
            Started = now();
            Message = msg;
            Finished = now();
        }

        public string DelimitedText(char delimiter)
            => TestCaseRecords.format(this, delimiter);
    }
}