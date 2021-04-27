//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct Cmd
    {
        [Op]
        public static CmdTypeInfo[] cmdtypes(IWfRuntime wf)
            => wf.Components.Types().Tagged<CmdAttribute>().Select(cmdtype);
    }
}