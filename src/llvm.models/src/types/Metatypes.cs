//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System.Runtime.InteropServices;

    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Derived from ValueTypes.td
    /// </summary>
    public readonly partial struct Metatypes
    {
        const LayoutKind Layout = LayoutKind.Sequential;

        public struct TypeDescriptor
        {
            public StringAddress Name;

            public BitWidth Width;
        }

        [MethodImpl(Inline), Op]
        internal static StringAddress name(string src)
            => StringAddress.from(src);

        [MethodImpl(Inline)]
        internal static ushort width<T>(T src = default)
            where T : unmanaged
                => (ushort)core.width<T>();

        [MethodImpl(Inline)]
        public static ref TypeDescriptor describe<T>(out TypeDescriptor dst)
            where T : unmanaged, IValueType<T>
        {
            var t = default(T);
            dst.Name = t.Name;
            dst.Width = t.Width;
            return ref dst;
        }
    }
}