//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static SFuncs;
    using static MathSvcHosts;
    
    using OK = OpKinds;
    
    partial class MathServices
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
            where K : unmanaged, IBitLogicKind      
                => eval_1(kind,a,b);

        [MethodImpl(Inline)]
        public static T eval<T,K>(K kind, T a)
            where T : unmanaged  
            where K : unmanaged, IBitLogicKind      
                => eval_1(kind,a);

        [MethodImpl(Inline)]
        static T eval_1<T,K>(K kind, T a)
            where T : unmanaged  
            where K : unmanaged, IBitLogicKind      
        {
            if(typeof(K) == typeof(OK.Not))
                return not<T>().Invoke(a);
            else 
                throw Unsupported.define<T>();
        }

        [MethodImpl(Inline)]
        static T eval_1<T,K>(K kind, T a, T b)
            where T : unmanaged  
            where K : unmanaged, IBitLogicKind      
        {
            if(typeof(K) == typeof(OK.And))
                return and<T>().Invoke(a,b);
            else if(typeof(K) == typeof(OK.Or))
                return or<T>().Invoke(a,b);
            else if(typeof(K) == typeof(OK.Xor))
                return xor<T>().Invoke(a,b);
            else if(typeof(K) == typeof(OK.Nand))
                return nand<T>().Invoke(a,b);
            else if(typeof(K) == typeof(OK.Nor))
                return nor<T>().Invoke(a,b);
            else if(typeof(K) == typeof(OK.Xnor))
                return xnor<T>().Invoke(a,b);
            else
                return eval_2(kind,a,b);
        }

        [MethodImpl(Inline)]
        static T eval_2<T,K>(K kind, T a, T b)
            where T : unmanaged  
            where K : unmanaged, IBitLogicKind      
        {
            if(typeof(K) == typeof(OK.Impl))
                return impl<T>().Invoke(a,b);
            else if(typeof(K) == typeof(OK.NonImpl))
                return nonimpl<T>().Invoke(a,b);
            else if(typeof(K) == typeof(OK.CImpl))
                return cimpl<T>().Invoke(a,b);
            else if(typeof(K) == typeof(OK.CNonImpl))
                return cnonimpl<T>().Invoke(a,b);
            else
                 throw Unsupported.define<T>();

        }
    }
}