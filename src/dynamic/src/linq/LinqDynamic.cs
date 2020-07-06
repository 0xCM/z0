//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq.Expressions;

    using Z0.Dynamics.Operators;

    using static Konst;
    using static Root;
    using static XPress;
    using static As;

    [ApiHost]
    public readonly struct LinqDynamic
    {        
        [MethodImpl(Inline)]
        public static Negate<T> negate<T>() 
            where T : unmanaged
                => new Negate<T>(lambda<T,T>(Expression.Negate).Compile());     

        [MethodImpl(Inline)]
        public static And<T> and<T>() 
            where T : unmanaged
                => new And<T>(lambda<T,T,T>(Expression.And).Compile());     

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Xor<T> xor<T>() 
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return new Xor<T>(generic<T>(Ops8u.Xor));
            else if(typeof(T) == typeof(ushort))
                return new Xor<T>(generic<T>(Ops8u.Xor));
            else if(typeof(T) == typeof(uint))
                return new Xor<T>(generic<T>(Ops8u.Xor));
            else if(typeof(T) == typeof(ulong))
                return new Xor<T>(generic<T>(Ops8u.Xor));
            else
                throw Unsupported.define<T>();
        }
            
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static GtEq<T> gteq<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return new GtEq<T>(generic<T>(Ops8u.GtEq.Compile()));
            else if(typeof(T) == typeof(ushort))
                return new GtEq<T>(Root.cast<Func<T,T,bool>>(Ops16u.GtEq.Compile()));
            else if(typeof(T) == typeof(uint))
                return new GtEq<T>(Root.cast<Func<T,T,bool>>(Ops32u.GtEq.Compile()));
            else if(typeof(T) == typeof(ulong))
                return new GtEq<T>(Root.cast<Func<T,T,bool>>(Ops64u.GtEq.Compile()));
            else
                return new GtEq<T>(lambda<T,T,bool>(Expression.GreaterThanOrEqual).Compile());
        }
    }
}