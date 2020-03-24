//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    using TC = System.TypeCode;

    using static CastInternals;
    
    [ApiHost("cast", ApiHostKind.Generic)]
    public static partial class Cast
    {
        /// <summary>
        /// Explicitly casts a source value to value of the indicated type, raising an exception if operation fails
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]   
        public static T force<T>(object src) 
            => (T)src;

        [MethodImpl(Inline)]   
        public static T to<S,T>(S src)
            => to_u<S,T>(src);        

        // [MethodImpl(Inline)]   
        // public static T to<T>(bit src, T t = default)
        //     where T : unmanaged
        //         => to_u<T>(src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static T to<T>(sbyte src)
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

        /// <summary>
        /// byte -> T
        /// </summary>
        /// <param name="src">The value to convert</param>
        /// <typeparam name="T">The target conversion type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static T to<T>(byte src)
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

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static T to<T>(short src)
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

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static T to<T>(ushort src)
            => to_u<T>(src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static T to<T>(int src)
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

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static T to<T>(uint src)
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

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static T to<T>(long src)
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

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static T to<T>(ulong src)
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

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static T to<T>(float src)
            => to_u<T>(src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static T to<T>(double src)
            => to_u<T>(src);

        [Op]
        public static object ocast(object src, NumericKind dst)
        {
            var tc = Type.GetTypeCode(src?.GetType());
            switch(tc)
            {
                case TC.SByte:
                    return from8i(dst, src);

                case TC.Byte:
                    return from8u(dst, src);

                case TC.Int16:
                    return from16i(dst, src);

                case TC.UInt16:
                    return from16u(dst, src);
                
                case TC.Int32:
                    return from32i(dst, src);

                case TC.UInt32:
                    return from32u(dst, src);

                case TC.Int64:
                    return from64i(dst, src);

                case TC.UInt64:
                    return from64u(dst, src);

                case TC.Single:
                    return from32f(dst, src);

                case TC.Double:
                    return from64f(dst,src);
            }
            return src;
        }
    }
}