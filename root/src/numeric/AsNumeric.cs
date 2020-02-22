//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Root;
    using static AsIn;
    using static AsNumericDefaults;

    [ApiHost]
    public static class AsNumeric
    {                
        /// <summary>
        /// Converts the source value to a numeric target value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static T As<S,T>(S src)
            where T : unmanaged
                => As_u<S,T>(src);

        [MethodImpl(Inline)]
        public static AsI8<S> I8<S>()        
            => Reify<AsI8<S>,S,sbyte>();

        [MethodImpl(Inline)]
        public static AsU8<S> U8<S>()        
            => default(AsU8<S>);

        [MethodImpl(Inline)]
        public static AsI16<S> I16<S>()        
            => default(AsI16<S>);

        [MethodImpl(Inline)]
        public static AsU16<S> U16<S>()        
            => default(AsU16<S>);

        [MethodImpl(Inline)]
        public static AsI32<S> I32<S>()        
            => default(AsI32<S>);

        [MethodImpl(Inline)]
        public static AsU32<S> U32<S>()        
            => default(AsU32<S>);

        [MethodImpl(Inline)]
        public static AsI64<S> I64<S>()        
            => default(AsI64<S>);

        [MethodImpl(Inline)]
        public static AsU64<S> U64<S>()        
            => default(AsU64<S>);

        [MethodImpl(Inline)]
        public static AsF32<S> F32<S>()        
            => default(AsF32<S>);

        [MethodImpl(Inline)]
        public static AsF64<S> F64<S>()        
            => default(AsF64<S>);

        [MethodImpl(Inline)]
        static T As_u<S,T>(S src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))            
                return generic<T>(U8<S>().As(src));
            else if(typeof(T) == typeof(ushort))            
                return generic<T>(U16<S>().As(src));
            else if(typeof(T) == typeof(uint))            
                return generic<T>(U32<S>().As(src));
            else if(typeof(T) == typeof(ulong))            
                return generic<T>(U64<S>().As(src));
            else 
                return As_i<S,T>(src);
        }

        [MethodImpl(Inline)]
        static T As_i<S,T>(S src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))            
                return generic<T>(I8<S>().As(src));
            else if(typeof(T) == typeof(short))            
                return generic<T>(I16<S>().As(src));
            else if(typeof(T) == typeof(int))            
                return generic<T>(I32<S>().As(src));
            else if(typeof(T) == typeof(long))            
                return generic<T>(I64<S>().As(src));
            else 
                return As_f<S,T>(src);
        }

        [MethodImpl(Inline)]
        static T As_f<S,T>(S src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))            
                return generic<T>(F32<S>().As(src));
            else if(typeof(T) == typeof(double))            
                return generic<T>(F64<S>().As(src));
            else
                throw unsupported<T>();
        }
    }
}