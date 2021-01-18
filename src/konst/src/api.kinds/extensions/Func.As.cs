//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class XKinds
    {
        [MethodImpl(Inline)]
        public static BinaryClass<W> Fixed<W>(this BinaryClass src)
            where W : unmanaged, ITypeWidth => default;

        [MethodImpl(Inline)]
        public static BinaryClass<T> As<T>(this BinaryClass src)
             where T : unmanaged => default;
    }
}