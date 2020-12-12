//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public struct CmdSpec<T> : ICmdSpec<CmdSpec<T>>, ITextual
        where T : struct, ICmdSpec<T>
    {
        public CmdId CmdId {get;}

        public CmdArgs Args {get;}

        [MethodImpl(Inline)]
        public CmdSpec(T spec)
        {
            CmdId = Cmd.id<T>();
            Args = Cmd.args(spec);
        }

        public string Format()
            => Cmd.format(this);

        public override string ToString()
            => Format();

        public static CmdSpec<T> Empty
            => default;
    }
}