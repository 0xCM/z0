//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class XWf
    {
        public static CmdResult RunTask<T>(this T cmd, IWfRuntime wf)
            where T : struct, ICmd
        {
            var task = wf.Dispatch(cmd);
            task.Wait();
            return task.Result;
        }

        public static CmdResult RunDirect<T>(this T cmd, IWfRuntime wf)
            where T : struct, ICmd
                => wf.Execute(cmd);
    }
}