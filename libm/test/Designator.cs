//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{        
    using System;
    using System.Reflection;
    using System.Linq;
    using System.Collections.Generic;

    using D = Z0.Designators;

    /// <summary>
    /// Represents the assembly
    /// </summary>
    public sealed class LibMTest : AssemblyDesignator<LibMTest>
    {
        public override void Run(params string[] args)
            => App.Run(args);

    }

}