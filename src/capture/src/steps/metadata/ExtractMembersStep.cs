//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Step(typeof(ExtractMembers), StepName)]
    public readonly struct ExtractMembersStep
    {        
        public const string StepName = nameof(ExtractMembers);
    }
}