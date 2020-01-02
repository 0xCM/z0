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
        public static TestCaseRecord Define(string Operation, bool Succeeded, Duration Duration)
            => new TestCaseRecord(Operation, Succeeded, Duration);
        
        public TestCaseRecord(string Operation, bool Succeeded, Duration Duration)
        {
            this.Operation = Operation;
            this.Succeeded = Succeeded;
            this.Duration = Duration;
            this.Executed = now();
        }

        public string Operation {get;set;}

        public bool Succeeded {get;set;}

        public Duration Duration {get;set;}

        public DateTime Executed {get;}

        const string YEA = "verified";
        
        const string BOO = "failed";

        const int OperationPad = 50;

        const int OutcomePad = 10;

        const int DurationPad = 10;

        string Outcome
            => Succeeded ? YEA : BOO;

        public string DelimitedText(char delimiter)
            => concat(
                $"{Operation.PadRight(OperationPad)}{delimiter}" + AsciSym.Space, 
                $"{Outcome.PadRight(OutcomePad)}{delimiter}" + AsciSym.Space, 
                $"{Duration.Ms.ToString().PadRight(DurationPad)}{delimiter}" + AsciSym.Space,
                $"{Executed.ToLexicalString()}"
                );

        public IReadOnlyList<string> GetHeaders()
            => new string[]{
                                nameof(Operation).PadRight(OperationPad), 
                AsciSym.Space + nameof(Outcome).PadRight(OutcomePad), 
                AsciSym.Space + nameof(Duration).PadRight(DurationPad),
                AsciSym.Space + nameof(Executed)
                };

    }
}