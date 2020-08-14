//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Step(typeof(CaptureHostMembers), StepName)]
    public readonly struct CaptureHostMembersStep
    {        
        public const string StepName = nameof(CaptureHostMembers);        
    }
}