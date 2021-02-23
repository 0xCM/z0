//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static TestCaseRecords;

    partial class TestApp<A>
    {
        // const int CasePad = (int)((ulong)TestCaseField.CaseName >> 32);

        // const int ExecutedPad = (int)((ulong)TestCaseField.Finished >> 32);

        // const int DurationPad = (int)((ulong)TestCaseField.Duration >> 32);

        // const int StatusPad = (int)((ulong)TestCaseField.Passed >> 32);

        const string FieldSep = " | ";

        static string DurationPlaceholder
            => string.Empty.PadRight((int)DurationPad);

        static string FormatTs(DateTime ts)
            => ts.ToLexicalString().PadRight((int)FinishedPad);

        static string Format(TimeSpan elapsed)
            => $"{elapsed.TotalMilliseconds} ms".PadRight((int)DurationPad);

        static string FormatName(string testName)
            => $"{testName}".PadRight((int)CasePad);

        static string FormatStatus(string status)
            => status.PadRight((int)PassedPad);

        static string TestCaseName(IExplicitTest unit)
        {
            var owner = ApiIdentityKinds.owner(unit.GetType());
            var hostname = unit.GetType().Name;
            var opname = "explicit";
            return $"{owner}/{hostname}/{opname}";
        }

        static AppMsg PreCase(string testName, DateTime start)
        {
            var fields = Arrays.from(
                FormatName(testName),
                FormatStatus("executing"),
                DurationPlaceholder,
                FormatTs(start)
                );

            return AppMsg.colorize(fields.Join(FieldSep), FlairKind.Status);
        }

        static AppMsg PostCase(string testName, TimeSpan elapsed, DateTime start, DateTime end)
        {
            var fields = Arrays.from(
                FormatName(testName),
                FormatStatus("executed"),
                Format(elapsed),
                FormatTs(start),
                FormatTs(end),
                Format(end - start)
                );

            return AppMsg.colorize(fields.Join(FieldSep), FlairKind.Status);
        }

        static AppMsg PostUnit(string hosturi, TimeSpan elapsed, DateTime start, DateTime end)
        {
            var fields = Arrays.from(
                FormatName(hosturi),
                FormatStatus("completed"),
                Format(elapsed),
                FormatTs(start),
                FormatTs(end),
                Format(end - start)
                );

            return AppMsg.colorize(fields.Join(FieldSep), FlairKind.Status);
        }
    }
}