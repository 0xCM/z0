//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;    

    using static Konst;

    partial class TestApp<A>
    {
        const int CasePad = (int)((ulong)TestCaseField.Case >> 32);
        
        const int ExecutedPad = (int)((ulong)TestCaseField.Executed >> 32);

        const int DurationPad = (int)((ulong)TestCaseField.Duration >> 32);

        const int StatusPad = (int)((ulong)TestCaseField.Status >> 32);

        const string FieldSep = "| ";

        static string DurationPlaceholder 
            => string.Empty.PadRight(DurationPad);

        static string FormatTs(DateTime ts)
            => ts.ToLexicalString().PadRight(ExecutedPad);

        static string Format(TimeSpan elapsed)
            => $"{elapsed.TotalMilliseconds} ms".PadRight(DurationPad);

        static string FormatName(string testName)
            => $"{testName}".PadRight(CasePad);

        static string FormatStatus(string status)
            => status.PadRight(StatusPad);

        static string TestCaseName(IExplicitTest unit)
        {
            var owner = Identify.OwningPartText(unit.GetType());
            var hostname = unit.GetType().Name;
            var opname = "explicit";
            return $"{owner}/{hostname}/{opname}";
        }

        string TestActionName
        {
            get 
            {
                var owner = Identify.OwningPartText(GetType());
                var hostname = GetType().Name;
                var opname = "action";         
                return $"{owner}/{hostname}/{opname}";
            }
        }   

        static AppMsg PreCase(string testName, DateTime start)
        {
            var fields = Arrays.from(
                FormatName(testName), 
                FormatStatus("executing"), 
                DurationPlaceholder, 
                FormatTs(start)
                );                

            return AppMsg.Colorize(fields.Concat(FieldSep), AppMsgColor.Blue);
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

            return AppMsg.Colorize(fields.Concat(FieldSep), AppMsgColor.Blue);
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

            return AppMsg.Colorize(fields.Concat(FieldSep), AppMsgColor.Blue);
        }
    }
}