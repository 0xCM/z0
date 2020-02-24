//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{
    /// <summary>
    /// Represents the assembly
    /// </summary>
    public sealed class ValidationTest : AssemblyResolution<ValidationTest>
    {
        const AssemblyId Identity = AssemblyId.ValidationTest;

        public override AssemblyId Id 
            => Identity;

        public override void Run(params string[] args)
            => App.Run(args);
    }

}