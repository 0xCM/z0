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
        public static UnaryOpClass<T> As<T>(this UnaryOpClass src)
            where T : unmanaged => default;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static TernaryOpClass<T> As<T>(this TernaryOpClass src)
            where T : unmanaged => default;

        public static OperatorClass<W> Fixed<W>(this OperatorClass src)
            where W : unmanaged, ITypeWidth => default;

        public static UnaryOpClass<W> Fixed<W>(this UnaryOpClass src)
            where W : unmanaged, ITypeWidth => default;

        public static TernaryOpClass<W> Fixed<W>(this TernaryOpClass src)
            where W : unmanaged, ITypeWidth => default;
    }
}