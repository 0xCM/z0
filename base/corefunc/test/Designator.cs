//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{        
    using System;

    /// <summary>
    /// Represents the assembly
    /// </summary>
    public sealed class CoreFuncTest : AssemblyDesignator<CoreFuncTest>
    {
        public override void Run(params string[] args)
            => App.Run(args);

        public override AssemblyRole Role
            => AssemblyRole.Test;
    }


}