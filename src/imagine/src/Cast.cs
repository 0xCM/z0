//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    using static Konst;
    using static As;
    
    public static partial class XTend  { }

    [ApiHost]
    public static class Cast
    {
        /// <summary>
        /// Unconditionally converts, with much haste and no waste, a value of parametric numeric kind 
        /// to a value of another parametric numeric kind.
        /// </summary>
        /// <param name="src">The soruce value</param>
        /// <typeparam name="S">The source numeric kind</typeparam>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline)]   
        public static T to<S,T>(S src)
            => ToNumeric.to<S,T>(src);        

        [MethodImpl(Inline)]   
        public static T to<T>(sbyte src)
            => ToNumeric.to<T>(src);

        [MethodImpl(Inline)]   
        public static T to<T>(byte src)
            => ToNumeric.to<T>(src);

        [MethodImpl(Inline)]
        public static T to<T>(short src)
            => ToNumeric.to<T>(src);

        [MethodImpl(Inline)]
        public static T to<T>(ushort src)
            => ToNumeric.to<T>(src);

        [MethodImpl(Inline)]
        public static T to<T>(int src)
            => ToNumeric.to<T>(src);

        [MethodImpl(Inline)]
        public static T to<T>(uint src)
            => ToNumeric.to<T>(src);

        [MethodImpl(Inline)]
        public static T to<T>(long src)
            => ToNumeric.to<T>(src);

        [MethodImpl(Inline)]
        public static T to<T>(ulong src)
            => ToNumeric.to<T>(src);

        [MethodImpl(Inline)]
        public static T to<T>(float src)
            => ToNumeric.to<T>(src);

        [MethodImpl(Inline)]
        public static T to<T>(double src)
            => ToNumeric.to<T>(src);

        [MethodImpl(Inline)]   
        public static object to(object src, NumericKind dst)
            => As.rebox(src,dst);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T force<T>(object src) 
            => (T)src;
 
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T to<T>(char src)
        {
            if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return to_i<T>(src);
            else if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return to_u<T>(src);
            else
                return to_x<T>(src);
        }

        [MethodImpl(Inline)]
        static T to_i<T>(char src)
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>((sbyte)src);
            else if(typeof(T) == typeof(short))
                return generic<T>((short)src);
            else if(typeof(T) == typeof(int))
                return generic<T>((int)src);
            else  
                return generic<T>((long)src);           
        }

        [MethodImpl(Inline)]
        static T to_u<T>(char src)
        {
            if(typeof(T) == typeof(byte))
                return generic<T>((byte)src);
            else if(typeof(T) == typeof(ushort))
                return generic<T>((ushort)src);
            else if(typeof(T) == typeof(uint))
                return generic<T>((uint)src);
            else  
                return generic<T>((ulong)src);
        }

        [MethodImpl(Inline)]
        static T to_x<T>(char src)
        {
            if(typeof(T) == typeof(float))
                return generic<T>((float)src);
            else if(typeof(T) == typeof(double))
                return generic<T>((double)(src));
            else if(typeof(T) == typeof(char))
                return generic<T>((char)src);
            else            
                return Unsupported.define<char,T>(src);
       }         
    }
}