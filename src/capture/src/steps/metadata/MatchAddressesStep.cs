//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Step(typeof(MatchAddresses), StepName)]
    public readonly struct MatchAddressesStep
    {
        public const string StepName = nameof(MatchAddresses);
    }
}