//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Part;

    partial class XKinds
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static OperatorClass<T> As<T>(this OperatorClass src)
            where T : unmanaged => default;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static UnaryClass<T> As<T>(this UnaryClass src)
            where T : unmanaged => default;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static TernaryClass<T> As<T>(this TernaryClass src)
            where T : unmanaged => default;

        public static OperatorClass<W> Fixed<W>(this OperatorClass src)
            where W : unmanaged, ITypeWidth => default;

        public static UnaryClass<W> Fixed<W>(this UnaryClass src)
            where W : unmanaged, ITypeWidth => default;

        public static TernaryClass<W> Fixed<W>(this TernaryClass src)
            where W : unmanaged, ITypeWidth => default;
    }
}