//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using S = RobocopySpec;
    using C = CmdSpec.robocopy;
    using R = CmdSpec.robocopy_response;

    [CommandSpec]
    public class RobocopySpec : ProcessCommandSpec<S,C,R>
    {
        readonly C Command;
        
        public RobocopySpec()
        {

        }

        public RobocopySpec(C src)
            : base(src)
        {
            Command = src;
        }
    }
}