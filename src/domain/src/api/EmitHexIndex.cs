//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static z;
    using static Konst;
    using static ApiDataModel;

    [Cmd(Code)]
    public struct EmitHexIndexCmd : ICmdSpec<EmitHexIndexCmd>
    {
        public const string Code = CmdCodes.EmitHexIndex;
    }

    [CmdHost]
    public sealed class EmitHexIndex : CmdHost<EmitHexIndex, EmitHexIndexCmd>
    {
        protected override CmdResult Execute(IWfShell wf, in EmitHexIndexCmd spec)
        {
            var dst = wf.Db().Table("apihex.index");
            var descriptors = ApiData.BlockDescriptors(wf);
            var count= ApiData.emit(descriptors, dst);
            wf.EmittedTable<CodeBlockDescriptor>(count, dst);
            return Win();
        }
    }
}