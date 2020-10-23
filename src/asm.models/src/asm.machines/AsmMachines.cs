//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost(ApiNames.AsmMachines, true)]
    public readonly partial struct AsmMachines
    {
        [Op]
        public static YmmMachine create(W256 w)
            => new YmmMachine(new Ymm[YmmMachine.RegisterCount]);

        [Op]
        public static YmmMachine load(W256 w, Ymm[] src)
            => new YmmMachine(src);

        [Op]
        public static R64Machine create(W64 w)
            => new R64Machine(new R64[R64Machine.RegisterCount]);

        [Op]
        public static R64Machine load(W64 w, R64[] src)
            => new R64Machine(src);
    }
}