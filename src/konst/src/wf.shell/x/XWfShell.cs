//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;

    using static Part;

    [ApiHost(ApiNames.XWfShell, true)]
    public static partial class XWFShell
    {
        [MethodImpl(Inline), Op]
        public static bool IsBabble(this LogLevel src)
            => src == LogLevel.Babble;

        [MethodImpl(Inline), Op]
        public static bool IsStatus(this LogLevel src)
            => src == LogLevel.Status;

        [MethodImpl(Inline), Op]
        public static bool IsWarning(this LogLevel src)
            => src == LogLevel.Warning;

        [MethodImpl(Inline), Op]
        public static bool IsError(this LogLevel src)
            => src == LogLevel.Error;

        [Op]
        public static Task<CmdResult> Dispatch<T>(this T cmd, IWfShell wf)
            where T : struct, ICmdSpec
                => wf.Dispatch(cmd);

        [Op]
        public static CmdResult Run<T>(this T cmd, IWfShell wf)
            where T : struct, ICmdSpec
        {
            var task = wf.Dispatch(cmd);
            task.Wait();
            return task.Result;
        }

        public static Task Continue<T>(this Task<T> src, Action<T> @continue)
            where T : struct, ICmdSpec
                => src.ContinueWith(t => @continue(t.Result));
    }
}