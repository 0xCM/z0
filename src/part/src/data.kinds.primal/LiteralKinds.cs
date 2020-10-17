//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static LiteralKind;
    using static Part;

    [ApiHost(ApiNames.LiteralKinds, true)]
    public readonly struct LiteralKinds
    {
        /// <summary>
        /// Returns the <see cref='LiteralKind'/> classification of a parametrically-identified primitive
        /// </summary>
        /// <typeparam name="T">The type to classify</typeparam>
        [MethodImpl(Inline)]
        public static LiteralKind kind<T>()
        {
            if(typeof(T) == typeof(string))
                return String;
            else if(typeof(T) == typeof(char))
                return C16;
            else if(typeof(T) == typeof(bool))
                return U1;
            else
                return numeric<T>();
        }

        /// <summary>
        /// Returns the <see cref='LiteralKind'/> classification of a parametrically-identified numeric primitive
        /// </summary>
        /// <typeparam name="T">The type to classify</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static LiteralKind numeric<T>()
            => numeric_u<T>();

        [MethodImpl(Inline)]
        static LiteralKind numeric_u<T>()
        {
            if(typeof(T) == typeof(byte))
                return U8;
            else if(typeof(T) == typeof(ushort))
                return U16;
            else if(typeof(T) == typeof(uint))
                return U32;
            else if(typeof(T) == typeof(ulong))
                return U64;
            else
                return numeric_i<T>();
        }

        [MethodImpl(Inline)]
        static LiteralKind numeric_i<T>()
        {
            if(typeof(T) == typeof(sbyte))
                return I8;
            else if(typeof(T) == typeof(short))
                return I16;
            else if(typeof(T) == typeof(int))
                return I32;
            else if(typeof(T) == typeof(long))
                return I64;
            return numeric_f<T>();
        }

        [MethodImpl(Inline)]
        static LiteralKind numeric_f<T>()
        {
            if(typeof(T) == typeof(float))
                return I8;
            else if(typeof(T) == typeof(double))
                return I16;
            else if(typeof(T) == typeof(decimal))
                return I32;
            else
                return LiteralKind.None;
        }
    }
}