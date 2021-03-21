//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Part;
    using LK = ClrLiteralKind;

    [ApiHost(ApiNames.ClrLiteralKinds, true)]
    public readonly struct ClrLiteralKinds
    {
        /// <summary>
        /// Returns the <see cref='ClrLiteralKind'/> classification of a parametrically-identified primitive
        /// </summary>
        /// <typeparam name="T">The type to classify</typeparam>
        [MethodImpl(Inline)]
        public static ClrLiteralKind kind<T>()
        {
            if(typeof(T) == typeof(string))
                return LK.String;
            else if(typeof(T) == typeof(char))
                return LK.C16;
            else if(typeof(T) == typeof(bool))
                return LK.U1;
            else
                return numeric<T>();
        }

        /// <summary>
        /// Returns the <see cref='ClrLiteralKind'/> classification of a parametrically-identified numeric primitive
        /// </summary>
        /// <typeparam name="T">The type to classify</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ClrLiteralKind numeric<T>()
            => numeric_u<T>();

        [MethodImpl(Inline)]
        static ClrLiteralKind numeric_u<T>()
        {
            if(typeof(T) == typeof(byte))
                return LK.U8;
            else if(typeof(T) == typeof(ushort))
                return LK.U16;
            else if(typeof(T) == typeof(uint))
                return LK.U32;
            else if(typeof(T) == typeof(ulong))
                return LK.U64;
            else
                return numeric_i<T>();
        }

        [MethodImpl(Inline)]
        static ClrLiteralKind numeric_i<T>()
        {
            if(typeof(T) == typeof(sbyte))
                return LK.I8;
            else if(typeof(T) == typeof(short))
                return LK.I16;
            else if(typeof(T) == typeof(int))
                return LK.I32;
            else if(typeof(T) == typeof(long))
                return LK.I64;
            return numeric_f<T>();
        }

        [MethodImpl(Inline)]
        static ClrLiteralKind numeric_f<T>()
        {
            if(typeof(T) == typeof(float))
                return LK.I8;
            else if(typeof(T) == typeof(double))
                return LK.I16;
            else if(typeof(T) == typeof(decimal))
                return LK.I32;
            else
                return ClrLiteralKind.None;
        }
    }
}