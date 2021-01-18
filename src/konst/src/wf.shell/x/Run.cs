//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class XWf
    {
        public static CmdResult Run<T>(this T cmd, IWfShell wf)
            where T : struct, ICmdExecSpec
        {
            var task = wf.Dispatch(cmd);
            task.Wait();
            return task.Result;
        }
    }
}