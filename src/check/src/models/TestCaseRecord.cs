//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Root;
    using static core;

    using static RenderFunctions;
    using static FormatFunctions;

    public enum TestCaseField : uint
    {
        CaseName = 0 | (60 << 16),

        Passed =  1 | (14 << 16),

        Duration = 2  | (14 << 16),

        Started =  3 | (26 << 16),

        Finished =  4 | (26 << 16),

        Message = 5 | (32 << 16)
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

        public static RenderCellText<TestCaseRecord> RenderFunction
            => TestCaseRecords.render;

        public static FormatCell<TestCaseRecord> FormatFunction
            => TestCaseRecords.format;

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

        public string Format()
            => TestCaseRecords.format(this);
    }
}