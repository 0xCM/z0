//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public struct ToolExecSpec<T> : ICmd<ToolExecSpec<T>>, ITextual
        where T : struct, ICmd<T>
    {
        public CmdId CmdId {get;}

        public ToolCmdArgs Args {get;}

        [MethodImpl(Inline)]
        public ToolExecSpec(T spec)
        {
            CmdId = Cmd.id<T>();
            Args = Cmd.args(spec);
        }

        public string Format()
            => Cmd.format(this);

        public override string ToString()
            => Format();

        public static ToolExecSpec<T> Empty
            => default;
    }
}