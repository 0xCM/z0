//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Security;

    using static Domain;

    [SuppressUnmanagedCodeSecurity]
    public delegate bit UnaryPredicate<T>(T a);

    [SuppressUnmanagedCodeSecurity]
    public delegate bit UnaryPredicate<W,T>(T a)
         where W : unmanaged, ITypeWidth;

    [SuppressUnmanagedCodeSecurity]
    public delegate bit BinaryPredicate<T>(T a, T b);

    [SuppressUnmanagedCodeSecurity]
    public delegate bit BinaryPredicate<W,T>(T a, T b)
         where W : unmanaged, ITypeWidth;

    [SuppressUnmanagedCodeSecurity]
    public delegate bit TernaryPredicate<T>(T a, T b, T c);        

    [SuppressUnmanagedCodeSecurity]
    public delegate bit TernaryPredicate<W,T>(T a, T b, T c)    
         where W : unmanaged, ITypeWidth; 


     partial class XDomain
     {
        [MethodImpl(Inline)]
        public static UnaryPredicate<T> ToUnaryPredicate<T>(this System.Func<T,bit> f)
            => new UnaryPredicate<T>(f);

        [MethodImpl(Inline)]
        public static Z0.BinaryPredicate<T> ToBinaryPredicate<T>(this System.Func<T,T,bit> f)
            => new Z0.BinaryPredicate<T>(f);

        [MethodImpl(Inline)]
        public static System.Func<T,bit> ToFunc<T>(this UnaryPredicate<T> f)
            => new System.Func<T,bit>(f);

        [MethodImpl(Inline)]
        public static System.Func<T,T,bit> ToFunc<T>(this BinaryPredicate<T> f)
            => new System.Func<T,T,bit>(f);
     }
}