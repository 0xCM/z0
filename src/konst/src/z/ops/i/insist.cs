//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;    
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    partial struct z
    {
        [MethodImpl(Inline), Op]
        static void require(bool invariant, string msg, string caller, string file, int? line)
        {
            if(!invariant)
                sys.@throw(new Exception($"{msg}: See line {line} in {file}"));
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
            require(value<N>() == src,  $"The source value {src} does not match the required natural value {value<N>()}", caller, file, line);
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

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T insist<T>(T src, Func<T,bool> f, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
        {
            require(f(src), $"Predicate evaluation over {src} failed", caller, file, line);
            return src;
        }

        [MethodImpl(Inline)]
        public static T insist<T>(T src, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : class
        {
            require(src != null, $"The {type<T>()}-kinded value was null", caller, file, line);
            return src;
        }

        [MethodImpl(Inline)]
        public static FilePath insist(FilePath src, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
        {
            insist(src.Exists, $"The file {src} does not exist", caller, file, line);
            return src;
        }

        [MethodImpl(Inline)]
        public static string insist(string src, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
        {
            insist(text.nonempty(src), $"The source text was empty", caller, file, line);
            return src;
        }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T insist<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : IEquatable<T>            
        {
            if(z.nullnot(lhs) && z.nullnot(rhs) && lhs.Equals(rhs))
                return lhs;
            else
                insist(false, $"{lhs} != {rhs}", caller, file, line);
            
            return default;
        }
    }
}