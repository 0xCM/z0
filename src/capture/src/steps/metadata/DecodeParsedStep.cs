//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Step(typeof(DecodeParsed), StepName)]
    public readonly struct DecodeParsedStep
    {           
        public const string StepName = nameof(DecodeParsed);
    }
}