//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;
    using static GXTypes;

    partial class GX
    {

       [MethodImpl(Inline)]
       public static And<T> and<T>(T t = default)
            where T : unmanaged        
                => And<T>.Op;
 
        [MethodImpl(Inline)]
        public static Or<T> or<T>(T t = default)
            where T : unmanaged        
                => Or<T>.Op;

        [MethodImpl(Inline)]
        public static Xor<T> xor<T>(T t = default)
            where T : unmanaged        
                => Xor<T>.Op;

        [MethodImpl(Inline)]
        public static Nand<T> nand<T>(T t = default)
            where T : unmanaged        
                => Nand<T>.Op;

        [MethodImpl(Inline)]
        public static Nor<T> nor<T>(T t = default)
            where T : unmanaged        
                => Nor<T>.Op;

        [MethodImpl(Inline)]
        public static Xnor<T> xnor<T>(T t = default)
            where T : unmanaged        
                => Xnor<T>.Op;

        [MethodImpl(Inline)]
        public static Select<T> select<T>(T t = default)
            where T : unmanaged        
                => Select<T>.Op;

        [MethodImpl(Inline)]
        public static Not<T> not<T>(T t = default)
            where T : unmanaged        
                => Not<T>.Op;

        [MethodImpl(Inline)]
        public static Impl<T> impl<T>(T t = default)
            where T : unmanaged        
                => Impl<T>.Op;

        [MethodImpl(Inline)]
        public static NonImpl<T> nonimpl<T>(T t = default)
            where T : unmanaged        
                => NonImpl<T>.Op;

        [MethodImpl(Inline)]
        public static CImpl<T> cimpl<T>(T t = default)
            where T : unmanaged        
                => CImpl<T>.Op;

        [MethodImpl(Inline)]
        public static CNonImpl<T> cnonimpl<T>(T t = default)
            where T : unmanaged        
                => CNonImpl<T>.Op;

        [MethodImpl(Inline)]
        public static T eval<T,K>(K kind, T a, T b)
            where T : unmanaged  
            where K : unmanaged, IOperatorKind      
                => eval_1(kind,a,b);

        [MethodImpl(Inline)]
        public static T eval<T,K>(K kind, T a)
            where T : unmanaged  
            where K : unmanaged, IOperatorKind      
            => eval_1(kind,a);

        [MethodImpl(Inline)]
        static T eval_1<T,K>(K kind, T a)
            where T : unmanaged  
            where K : unmanaged, IOperatorKind      
        {
            if(typeof(K) == typeof(HK.Negate))
                return negate<T>().Invoke(a);
            else if(typeof(K) == typeof(HK.Not))
                return not<T>().Invoke(a);
            else 
                throw unsupported<T>();
        }


        [MethodImpl(Inline)]
        static T eval_1<T,K>(K kind, T a, T b)
            where T : unmanaged  
            where K : unmanaged, IOperatorKind      
        {
            if(typeof(K) == typeof(HK.And))
                return and<T>().Invoke(a,b);
            else if(typeof(K) == typeof(HK.Or))
                return or<T>().Invoke(a,b);
            else if(typeof(K) == typeof(HK.Xor))
                return xor<T>().Invoke(a,b);
            else if(typeof(K) == typeof(HK.Nand))
                return nand<T>().Invoke(a,b);
            else if(typeof(K) == typeof(HK.Nor))
                return nor<T>().Invoke(a,b);
            else if(typeof(K) == typeof(HK.Xnor))
                return xnor<T>().Invoke(a,b);
            else
                return eval_2(kind,a,b);
        }

        [MethodImpl(Inline)]
        static T eval_2<T,K>(K kind, T a, T b)
            where T : unmanaged  
            where K : unmanaged, IOperatorKind      
        {
            if(typeof(K) == typeof(HK.Impl))
                return impl<T>().Invoke(a,b);
            else if(typeof(K) == typeof(HK.NonImpl))
                return nonimpl<T>().Invoke(a,b);
            else if(typeof(K) == typeof(HK.CImpl))
                return cimpl<T>().Invoke(a,b);
            else if(typeof(K) == typeof(HK.CNonImpl))
                return cnonimpl<T>().Invoke(a,b);
            else
                throw unsupported<K>();
        }

    }
}