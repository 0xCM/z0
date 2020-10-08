//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {
        /// <summary>
        /// Reimagines a boolean value as a character value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static char @char(bool src)
            => (char)(u8(src) + 48);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref char @char<E>(in E src)
            where E : unmanaged
                => ref @as<E,char>(src);

        [MethodImpl(Inline)]
        public static char @char<S,T,N>(Symbol<S,T,N> src)
            where S : unmanaged
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => Unsafe.As<S,char>(ref edit(src.Value));

        [MethodImpl(Inline)]
        public static char @char<S,T>(Symbol<S,T> src)
            where S : unmanaged
            where T : unmanaged
                => Unsafe.As<S,char>(ref edit(src.Value));

        [MethodImpl(Inline)]
        public static char @char<S>(Symbol<S> src)
            where S : unmanaged
                => Unsafe.As<S,char>(ref edit(src.Value));
    }
}