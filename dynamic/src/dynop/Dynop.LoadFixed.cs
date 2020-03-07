//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Runtime.CompilerServices;

    using static Root;
    using static FKT;

    partial class Dynop
    {

        [MethodImpl(Inline)]
        public static FixedFunc<X0,R> LoadFixed<X0,R>(this BufferToken buffer, in AsmCode src)
            where X0 : unmanaged, IFixed
            where R : unmanaged, IFixed
                => buffer.Load(src).FixedAdapter<X0,R>(src.Id);                                

        [MethodImpl(Inline)]
        public static FixedFunc<X0,X1,R> LoadFixed<X0,X1,R>(this BufferToken buffer, in AsmCode src)
            where X0 : unmanaged, IFixed
            where X1 : unmanaged, IFixed
            where R : unmanaged, IFixed
                => buffer.Load(src).FixedAdapter<X0,X1,R>(src.Id);

    }
}