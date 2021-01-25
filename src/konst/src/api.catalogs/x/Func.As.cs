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
        public static BinaryOperatorClass<W> Fixed<W>(this BinaryOperatorClass src)
            where W : unmanaged, ITypeWidth => default;

        [MethodImpl(Inline)]
        public static BinaryOperatorClass<T> As<T>(this BinaryOperatorClass src)
             where T : unmanaged => default;
    }
}