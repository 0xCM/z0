//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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
    public class TestCaseResult : IRecord<TestCaseResult>
    {
        public static TestCaseResult Define(string Operation, bool Succeeded, Duration Duration)
            => new TestCaseResult(Operation, Succeeded, Duration);
        
        public TestCaseResult(string Operation, bool Succeeded, Duration Duration)
        {
            this.Operation = Operation;
            this.Succeeded = Succeeded;
            this.Duration = Duration;
        }

        public string Operation {get;set;}

        public bool Succeeded {get;set;}

        public Duration Duration {get;set;}

        const string YEA = "verified";
        
        const string BOO = "failed";

        const int OperationPad = 50;

        const int OutcomePad = 10;

        string Outcome
            => Succeeded ? YEA : BOO;

        public string DelimitedText(char delimiter)
            => concat(
                $"{Operation.PadRight(OperationPad)}{delimiter}" + AsciSym.Space, 
                $"{Outcome.PadRight(OutcomePad)}{delimiter}" + AsciSym.Space, 
                $"{Duration.Ms}"
                );

        public IReadOnlyList<string> GetHeaders()
            => new string[]{
                nameof(Operation).PadRight(OperationPad), 
                AsciSym.Space + nameof(Outcome).PadRight(OutcomePad), 
                AsciSym.Space + nameof(Duration)
                };

    }
}