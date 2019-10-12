//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;    

    partial class inxvoc
    {

        [MethodImpl(Inline)]
        public static Vec256<long> vperm4x64_256x64i_DCBA(in Vec256<long> x)
            => dinx.vperm4x64(x,Perm4.DCBA);

        [MethodImpl(Inline)]
        public static Vec256<long> vperm4x64_256x64i_BADC(in Vec256<long> x)
            => dinx.vperm4x64(x,Perm4.DCBA);

        [MethodImpl(Inline)]
        public static Vec256<ulong> vperm4x64_256x64u_DCBA(in Vec256<ulong> x)
            => dinx.vperm4x64(x,Perm4.DCBA);

        [MethodImpl(Inline)]
        public static Vec256<ulong> vperm4x64_256x64i_BADC(in Vec256<ulong> x)
            => dinx.vperm4x64(x,Perm4.DCBA);

        [MethodImpl(Inline)]
        public static Vec256<double> vperm4x64_256x64f_DCBA(in Vec256<double> x)
            => dinx.vperm4x64(x,Perm4.DCBA);

        [MethodImpl(Inline)]
        public static Vec256<double> vperm4x64_256x64i_BADC(in Vec256<double> x)
            => dinx.vperm4x64(x,Perm4.DCBA);

    }
}