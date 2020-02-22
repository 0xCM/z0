//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public static class Root
    {
        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

        public const MethodImplOptions NotInline = MethodImplOptions.NoInlining;

        public const StringComparison IgnoreCase = StringComparison.InvariantCultureIgnoreCase;


        [MethodImpl(Inline)]
        public static NotSupportedException unsupported(object value)
            => new NotSupportedException($"{value}");

        [MethodImpl(Inline)]
        public static NotSupportedException unsupported<T>()
            => new NotSupportedException($"The invoking operation does not support the type {typeof(T).Name}");

        /// <summary>
        /// Computes the byte-size of a type
        /// </summary>
        /// <typeparam name="T">The type</typeparam>
        [MethodImpl(Inline)]
        public static ByteSize size<T>()
            => Unsafe.SizeOf<T>();

        [MethodImpl(Inline)]
        public static int bitsize<T>()            
            where T : unmanaged
                => Unsafe.SizeOf<T>()*8;

        [MethodImpl(Inline)]
        public static T[] array<T>(params T[] src)
            => src;


        [MethodImpl(Inline)]
        internal static bool IdentityEquals(string lhs, string rhs)
            => IdentityCommons.IdentityEquals(lhs,rhs);

        [MethodImpl(Inline)]
        internal static int IdentityCompare(IIdentity lhs, IIdentity rhs)
            => IdentityCommons.IdentityCompare(lhs,rhs);

        [MethodImpl(Inline)]
        internal static bool IdentityEquals(IIdentity lhs, object rhs)
            => IdentityCommons.IdentityEquals(lhs,rhs);

        [MethodImpl(Inline)]
        internal static bool IdentityEquals<T>(in T lhs, in T rhs)
            where T : struct, IIdentity<T>
                => IdentityCommons.IdentityEquals(lhs, rhs);   

        [MethodImpl(Inline)]
        internal static int IdentityHashCode<T>(in T src)     
            where T : struct, IIdentity<T>
                => IdentityCommons.IdentityHashCode(src);
    }
}