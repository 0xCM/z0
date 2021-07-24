//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading.Tasks;

    using static Root;
    using static core;

    partial class XTend
    {
        public static CmdResult<C,P> Success<C,P>(this C cmd, P payload)
            where C : struct, ICmd<C>
                => new CmdResult<C,P>(cmd,true,payload);

        public static  CmdResult<C,P> ToResult<C,P>(this C spec, Outcome<P> outcome)
            where C : struct, ICmd<C>
                => Cmd.result(spec, outcome.Ok, outcome.Data, outcome.Message);

        public static Task Continue<T>(this Task<T> src, Action<T> @continue)
            where T : struct, ICmd
                => src.ContinueWith(t => @continue(t.Result));

        public static byte To8u(this CmdArg arg)
            => byte.Parse(arg.Value);

        public static sbyte To8i(this CmdArg arg)
            => sbyte.Parse(arg.Value);

        public static ushort To16u(this CmdArg arg)
            => ushort.Parse(arg.Value);

        public static short To16i(this CmdArg arg)
            => short.Parse(arg.Value);

        public static uint To32u(this CmdArg arg)
            => uint.Parse(arg.Value);

        public static int To32i(this CmdArg arg)
            => int.Parse(arg.Value);

        public static ulong To64u(this CmdArg arg)
            => ulong.Parse(arg.Value);

        public static long To64i(this CmdArg arg)
            => long.Parse(arg.Value);
    }
}