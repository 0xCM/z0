//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using static Part;

    public static class XCmd
    {
        public static CmdResult<C,P> Success<C,P>(this C cmd, P payload)
            where C : struct, ICmd<C>
                => new CmdResult<C,P>(cmd,true,payload);

        public static  CmdResult<C,P> ToResult<C,P>(this C spec, Outcome<P> outcome)
            where C : struct, ICmd<C>
                => Cmd.result(spec, outcome.Ok, outcome.Data, outcome.Message);
        public static Task<CmdResult> Dispatch<T>(this T cmd, IWfRuntime wf)
            where T : struct, ICmd
                => wf.Dispatch(cmd);

        public static Task Continue<T>(this Task<T> src, Action<T> @continue)
            where T : struct, ICmd
                => src.ContinueWith(t => @continue(t.Result));

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

        public static IEnumerable<ICmd> FindCommands(this IWfRuntime wf)
        {
            foreach(var a in wf.Components)
            {
                foreach(var c in Cmd.search(a))
                {
                    yield return c;
                }
            }
        }

        public static string Format<C>(this C src)
            where C : struct, ICmd<C>
                => CmdFormat.format(src);
    }
}