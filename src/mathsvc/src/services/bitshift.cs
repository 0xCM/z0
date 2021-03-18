//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static MSvcHosts;

    partial class MSvc
    {
        [MethodImpl(Inline)]
        public static Sll<T> sll<T>(T t = default)
            where T : unmanaged
                => default(Sll<T>);

        [MethodImpl(Inline)]
        public static Srl<T> srl<T>(T t = default)
            where T : unmanaged
                => default(Srl<T>);
    }
}