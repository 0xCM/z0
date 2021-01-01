//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using NBK = NumericBaseKind;

    [ApiHost]
    public readonly struct NumericLiterals
    {
        const NumericKind Closure = AllNumeric;

        /// <summary>
        /// The zero-value for an 8-bit signed integer
        /// </summary>
        const sbyte z8i = 0;

        /// <summary>
        /// The zero-value for an 8-bit unsigned integer
        /// </summary>
        const byte z8 = 0;

        /// <summary>
        /// The zero-value for a 16-bit signed integer
        /// </summary>
        const short z16i = 0;

        /// <summary>
        /// The zero-value for a 16-bit unsigned integer
        /// </summary>
        const ushort z16 = 0;

        /// <summary>
        /// The zero-value for a 32-bit signed integer
        /// </summary>
        const int z32i = 0;

        /// <summary>
        /// The zero-value for a 32-bit unsigned integer
        /// </summary>
        const uint z32 = 0;

        /// <summary>
        /// The zero-value for a 64-bit signed integer
        /// </summary>
        const long z64i = 0;

        /// <summary>
        /// The zero-value for a 64-bit unsigned integer
        /// </summary>
        const ulong z64 = 0;

        /// <summary>
        /// The zero-value for a 32-bit float
        /// </summary>
        const float z32f = 0;

        /// <summary>
        /// The zero-value for a 64-bit float
        /// </summary>
        const double z64f = 0;

        /// <summary>
        /// The maximum value for an 8-bit signed integer
        /// </summary>
        const sbyte i8max = sbyte.MaxValue;

        /// <summary>
        /// The maximum value for an 8-bit unsigned integer
        /// </summary>
        const byte u8max = byte.MaxValue;

        /// <summary>
        /// The maximum value for a 16-bit signed integer
        /// </summary>
        const short i16max = short.MaxValue;

        /// <summary>
        /// The maximum value for a 16-bit unsigned integer
        /// </summary>
        const ushort u16max = ushort.MaxValue;

        /// <summary>
        /// The maximum value for a 32-bit signed integer
        /// </summary>
        const int i32max = int.MaxValue;

        /// <summary>
        /// The maximum value for a 32-bit unsigned integer
        /// </summary>
        const uint u32max = uint.MaxValue;

        /// <summary>
        /// The maximum value for a 64-bit signed integer
        /// </summary>
        const long i64max = long.MaxValue;

        /// <summary>
        /// The maximum value for a 64-bit unsigned integer
        /// </summary>
        const ulong u64max = ulong.MaxValue;

        /// <summary>
        /// The maximum value for a 32-bit float
        /// </summary>
        const float f32max = float.MaxValue;

        /// <summary>
        /// The maximum value for a 64-bit float
        /// </summary>
        const double f64max = double.MaxValue;

        /// <summary>
        /// The minimum value for an 8-bit signed integer
        /// </summary>
        const sbyte i8min = sbyte.MinValue;

        /// <summary>
        /// The minimum value for a 16-bit signed integer
        /// </summary>
        const short i16min = short.MinValue;

        /// <summary>
        /// The minimum value for a 32-bit signed integer
        /// </summary>
        const int i32min = int.MinValue;

        /// <summary>
        /// The minimum value for a 64-bit signed integer
        /// </summary>
        const long i64min = long.MinValue;

        const byte Ones8u = byte.MaxValue;

        const sbyte Ones8i = -1;

        const ushort Ones16u = ushort.MaxValue;

        const short Ones16i = -1;

        const uint Ones32u = uint.MaxValue;

        const int Ones32i = -1;

        const ulong Ones64u = ulong.MaxValue;

        const long Ones64i = -1;

        [MethodImpl(Inline), Op]
        public static NumericLiteral define(string Name, object Value, string Text, NBK @base)
            => new NumericLiteral(Name,Value,Text, @base);

        [MethodImpl(Inline), Op]
        public static NumericLiteral base2(string Name, object Value, string Text)
            => new NumericLiteral(Name, Value, Text, NBK.Base2);

        [MethodImpl(Inline), Op]
        public static NumericLiteral base10(string Name, object Value, string Text)
            => new NumericLiteral(Name, Value, Text, NBK.Base10);

        [MethodImpl(Inline), Op]
        public static NumericLiteral base16(string Name, object Value, string Text)
            => new NumericLiteral(Name, Value, Text, NBK.Base16);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static NumericLiteral<T> base2<T>(string Name, T Value, string Text)
            where T : unmanaged
                => new NumericLiteral<T>(Name, Value, Text, NBK.Base2);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static NumericLiteral<T> base10<T>(string Name, T data, string Text)
            where T : unmanaged
            => new NumericLiteral<T>(Name, data, Text, NBK.Base10);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static NumericLiteral<T> base16<T>(string Name, T data, string Text)
            where T : unmanaged
            => new NumericLiteral<T>(Name, data, Text, NBK.Base16);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static NumericLiteral<T> define<T>(string Name, T data, string Text, NBK @base)
            where T : unmanaged
                => new NumericLiteral<T>(Name,data, Text, @base);

        /// <summary>
        /// Returns generic 0 for a primal source type
        /// </summary>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T zero<T>()
            where T : unmanaged
                => default;

        /// <summary>
        /// Returns generic 1 for a primal source type
        /// </summary>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T one<T>()
            where T : unmanaged
                => NumericCast.force<T>(1);

        /// <summary>
        /// Ones all bits each and every ... one
        /// </summary>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T ones<T>()
            where T : unmanaged
                => ones_u<T>();

        /// <summary>
        /// Returns the minimum value supported by a parametrically-identified primal type
        /// </summary>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T minval<T>(T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte)
            || typeof(T) == typeof(short)
            || typeof(T) == typeof(int)
            || typeof(T) == typeof(long))
                return minval_i<T>();
            else if(typeof(T) == typeof(byte)
            || typeof(T) == typeof(ushort)
            || typeof(T) == typeof(uint)
            || typeof(T) == typeof(ulong))
                return minval_u<T>();
            else
                return minval_f<T>();
        }

        /// <summary>
        /// Returns the maximim value supported by a parametrically-identified primal type
        /// </summary>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T maxval<T>(T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte)
            || typeof(T) == typeof(short)
            || typeof(T) == typeof(int)
            || typeof(T) == typeof(long))
                return maxval_i<T>();
            else if(typeof(T) == typeof(byte)
            || typeof(T) == typeof(ushort)
            || typeof(T) == typeof(uint)
            || typeof(T) == typeof(ulong))
                return maxval_u<T>();
            else
                return maxval_f<T>();
        }

        [MethodImpl(Inline)]
        static T minval_i<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return NumericCast.force<T>(z8i);
            else if(typeof(T) == typeof(short))
                return NumericCast.force<T>(z16i);
            else if(typeof(T) == typeof(int))
                return NumericCast.force<T>(z32i);
            else
                return NumericCast.force<T>(z64i);
        }

        [MethodImpl(Inline)]
        static T minval_u<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return NumericCast.force<T>(z8);
            else if(typeof(T) == typeof(ushort))
                return NumericCast.force<T>(z16);
            else if(typeof(T) == typeof(uint))
                return NumericCast.force<T>(z32);
            else
                return NumericCast.force<T>(z64);
        }

        [MethodImpl(Inline)]
        static T minval_f<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return NumericCast.force<T>(z32f);
            else if(typeof(T) == typeof(double))
                return NumericCast.force<T>(z64f);
            else
                throw no<T>();
        }

        [MethodImpl(Inline)]
        static T maxval_i<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return NumericCast.force<T>(i8max);
            else if(typeof(T) == typeof(short))
                return NumericCast.force<T>(i16max);
            else if(typeof(T) == typeof(int))
                return NumericCast.force<T>(i32max);
            else
                return NumericCast.force<T>(i64max);
        }

        [MethodImpl(Inline)]
        static T maxval_u<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return NumericCast.force<T>(u8max);
            else if(typeof(T) == typeof(ushort))
                return NumericCast.force<T>(u16max);
            else if(typeof(T) == typeof(uint))
                return NumericCast.force<T>(u32max);
            else
                return NumericCast.force<T>(u64max);
        }

        [MethodImpl(Inline)]
        static T maxval_f<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return NumericCast.force<T>(f32max);
            else if(typeof(T) == typeof(double))
                return NumericCast.force<T>(f64max);
            else
                throw no<T>();
        }

        [MethodImpl(Inline)]
        static T ones_u<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return NumericCast.force<T>(Ones8u);
            else if(typeof(T) == typeof(ushort))
                return NumericCast.force<T>(Ones16u);
            else if(typeof(T) == typeof(uint))
                return NumericCast.force<T>(Ones32u);
            else if(typeof(T) == typeof(ulong))
                return NumericCast.force<T>(Ones64u);
            else
                return ones_i<T>();
        }

        [MethodImpl(Inline)]
        static T ones_i<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return NumericCast.force<T>(Ones8i);
            else if(typeof(T) == typeof(short))
                return NumericCast.force<T>(Ones16i);
            else if(typeof(T) == typeof(int))
                return NumericCast.force<T>(Ones32i);
            else if(typeof(T) == typeof(long))
                return NumericCast.force<T>(Ones64i);
            else
                 return ones_f<T>();
       }

        [MethodImpl(Inline)]
        static T ones_f<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return NumericCast.force<T>((float)Ones32u);
            else if(typeof(T) == typeof(double))
                return NumericCast.force<T>((double)Ones64u);
            else
                 throw no<T>();
       }
    }
}