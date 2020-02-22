//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    
    using static zfunc;

    /// <summary>
    /// Describes the outcome of a test case
    /// </summary>
    public class TestCaseRecord : IRecord<TestCaseRecord>
    {
        public static TestCaseRecord Define(string name, bool success, Duration duration)
            => new TestCaseRecord(name, success, duration);
        
        TestCaseRecord(string Case, bool Succeeded, Duration Duration)
        {
            this.Case = Case;
            this.Succeeded = Succeeded;
            this.Duration = Duration;
            this.Executed = now();
        }

        [ReportField(CasePad)]
        public string Case {get;set;}

        [ReportField(OutcomePad)]
        public bool Succeeded {get;set;}

        [ReportField(DurationPad)]
        public Duration Duration {get;set;}

        [ReportField]
        public DateTime Executed {get;}

        const string YEA = "verified";
        
        const string BOO = "failed";

        const int CasePad = 75;

        const int OutcomePad = 10;

        const int DurationPad = 10;

        string Outcome
            => Succeeded ? YEA : BOO;

        public string DelimitedText(char delimiter)
            => concat(
                $"{Case.PadRight(CasePad)}{delimiter}" + AsciSym.Space, 
                $"{Outcome.PadRight(OutcomePad)}{delimiter}" + AsciSym.Space, 
                $"{Duration.Ms.ToString().PadRight(DurationPad)}{delimiter}" + AsciSym.Space,
                $"{Executed.ToLexicalString()}"
                );

        public IReadOnlyList<string> GetHeaders()
            => new string[]{
                                nameof(Case).PadRight(CasePad), 
                AsciSym.Space + nameof(Outcome).PadRight(OutcomePad), 
                AsciSym.Space + nameof(Duration).PadRight(DurationPad),
                AsciSym.Space + nameof(Executed)
                };

    }
}