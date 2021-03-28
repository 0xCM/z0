//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [Cmd(CmdName)]
    public struct CheckServiceCmd : ICmd<CheckServiceCmd>
    {
        public const string CmdName = "check-service";

        public Name Name;
    }

    partial class XCmd
    {
        [MethodImpl(Inline), Op]
        public static CheckServiceCmd CheckService(this WfCmdBuilder builder, Name name)
        {
            var dst = new CheckServiceCmd();
            dst.Name = name;
            return dst;
        }
    }
}