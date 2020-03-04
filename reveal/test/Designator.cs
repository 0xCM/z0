//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Resolutions
{        
    /// <summary>
    /// Represents the assembly
    /// </summary>
    public sealed class RevealTest : AssemblyResolution<RevealTest>
    {

        public override void Run(params string[] args)
            => App.Run(args);
    }
}