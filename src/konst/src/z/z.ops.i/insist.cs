//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    using static Konst;

    partial struct z
    {
        [MethodImpl(Inline), Op]
        public static void require(bool invariant, in Func<string> f)
        {
            if(!invariant)
                sys.@throw(f);
        }

        [Op]
        public static void require(bool invariant, [Caller] string caller = null)
        {
            if(!invariant)
                sys.@throw(AppErrors.InvariantFailure(caller));
        }

        [MethodImpl(Inline), Op]
        public static void insist(bool invariant, [Caller] string caller = null)
            => require(invariant, caller);

        [MethodImpl(Inline), Op, Closures(UInt8k)]
        public static T[] insist<T>(T[] src)
        {
            if(src is null)
                sys.@throw(AppErrors.NullArg());
            return src;
        }

        [MethodImpl(Inline), Op, Closures(UInt8k)]
        public static void insist<T>(T lhs, T rhs)
            where T : IEquatable<T>
        {
            if(nullnot(lhs) && nullnot(rhs) && lhs.Equals(rhs))
                return;

            require(false, () => AppErrors.neq<T>(lhs,rhs));
        }

        [MethodImpl(Inline), Op, Closures(UInt8k)]
        public static T insist<T>(T src, Func<T,bool> f)
        {
            require(f(src),  () => AppErrors.NotTrue(src));
            return src;
        }

        [MethodImpl(Inline), Op]
        public static void insist(bool invariant, string msg, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
        {
            require(invariant, msg, caller, file, line);
        }

        [MethodImpl(Inline), Op]
        public static void insist(bool invariant, Func<string> msg, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
        {
            require(invariant, msg(), caller, file, line);
        }

        [MethodImpl(Inline)]
        public static ulong insist<N>(ulong src, N n = default, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where N : unmanaged, ITypeNat
        {
            require(nat64u<N>() == src,  $"The source value {src} does not match the required natural value {nat64u<N>()}", caller, file, line);
            return src;
        }

        [MethodImpl(Inline)]
        public static int insist<N>(int src, N n = default, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where N : unmanaged, ITypeNat
                => (int)insist<N>((ulong)src, n, caller, file, line);

        [MethodImpl(Inline)]
        public static T[] insist<N,T>(T[] src, N n = default, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where N : unmanaged, ITypeNat
        {
            insist(src.Length, n, caller, file, line);
            return src;
        }

        [MethodImpl(Inline)]
        public static T insist<T>(T src, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : class
        {
            require(src != null, () => AppErrors.NullArg(caller, file, line));
            return src;
        }

        [MethodImpl(Inline), Op]
        public static string insist(string src, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
        {
            insist(text.nonempty(src), $"The source text was empty", caller, file, line);
            return src;
        }

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static T insist<T>(T lhs, T rhs, bool locate, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : IEquatable<T>
        {
            if(nullnot(lhs) && nullnot(rhs) && lhs.Equals(rhs))
                return lhs;
            else
                require(false, $"{lhs} != {rhs}", caller, file, line);

            return default;
        }
    }
}