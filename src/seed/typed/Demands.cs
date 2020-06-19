//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    [ApiHost]
    public readonly struct Demands : IApiHost<Demands>
    {        
        static Insist Insist => Insist.Service;

        [MethodImpl(Inline), Op]
        public static void insist(bool invariant)
            => Insist.insist(invariant);

        [MethodImpl(Inline), Op]
        public static void insist(bool invariant, string msg)
            => Insist.insist(invariant, msg);    

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T insist<T>(T src, Func<T,bool> f)
            => Insist.insist(src, f);
        
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T insist<T>(T? src)
            where T : struct
                => Insist.insist(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T insist<T>(Option<T> src)
            => Insist.insist(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T insist<T>(T lhs, T rhs)
            where T : IEquatable<T>            
                => Insist.insist(lhs,rhs);

        [MethodImpl(Inline)]
        public static T insist<T>(T src)
            where T : class
                => Insist.insist(src);

        [MethodImpl(Inline)]
        public static void insist<N>(ulong src)
            where N : unmanaged, ITypeNat
                => Insist.insist<N>(src);

        [MethodImpl(Inline)]
        public static void insist<N>(int src)
            where N : unmanaged, ITypeNat
                => Insist.insist<N>(src);        
    }
}