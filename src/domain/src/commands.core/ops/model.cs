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

    partial struct Cmd
    {
        [Op]
        public static CmdModel model(Type src)
            => new CmdModel(src, src.DeclaredInstanceFields());

        public static CmdModel<T> model<T>()
            where T : struct, ICmdSpec<T>
                => default;
    }
}