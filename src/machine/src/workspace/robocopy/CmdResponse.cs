//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using C = CmdSpec.robocopy;
    using R = CmdSpec.robocopy_response;
    using M = ProcessMessage;

    partial class CmdSpec
    {
        public class robocopy_response : ProcessComandResponse<R, C>
        {
            internal robocopy_response(C command, M content)
                : base(command, content)
            { }
        }
    }
}