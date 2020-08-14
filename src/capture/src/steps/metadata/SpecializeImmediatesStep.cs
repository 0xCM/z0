//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Step(typeof(SpecializeImmediates), StepName)]
    public readonly struct SpecializeImmediatesStep
    {
        public const string StepName = nameof(SpecializeImmediates);
    }
}