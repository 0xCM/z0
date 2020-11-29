//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public struct CmdSpec<T> : ICmdSpec<CmdSpec<T>>, ITextual
        where T : struct, ICmdSpec<T>
    {
        public CmdId CmdId {get;}

        public CmdArgIndex Args {get;}

        [MethodImpl(Inline)]
        public CmdSpec(T spec)
        {
            CmdId = Cmd.id<T>();
            Args = Cmd.argidx(spec);
        }
        public string Format()
            => EmptyString;

        public override string ToString()
            => Format();

        public static CmdSpec<T> Empty
        {
            [MethodImpl(Inline)]
            get => new CmdSpec<T>(default(T));
        }
    }
}