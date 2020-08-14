//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Step(typeof(ExtractHostMembers), StepName)]
    public readonly struct ExtractHostMembersStep
    {
        public const string StepName = nameof(ExtractHostMembers);
    }
}