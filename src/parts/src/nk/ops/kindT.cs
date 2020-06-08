//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using NK = NumericKind;

    partial class NumericKinds
    {            
        /// <summary>
        /// Determines the numeric kind of a parametrically-identified type
        /// </summary>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static NK kind<T>()
            => kind_u<T>();

        [MethodImpl(Inline)]
        static NK kind_u<T>()
        {
            if(typeof(T) == typeof(byte))
                return NK.U8;
            else if(typeof(T) == typeof(ushort))
                return NK.U16;
            else if(typeof(T) == typeof(uint))
                return NK.U32;
            else if(typeof(T) == typeof(ulong))
                return NK.U64;
            else
                return kind_i<T>();
        }

        [MethodImpl(Inline)]
        static NK kind_i<T>()
        {
            if(typeof(T) == typeof(sbyte))
                return NK.I8;
            else if(typeof(T) == typeof(short))
                return NK.I16;
            else if(typeof(T) == typeof(int))
                return NK.I32;
            else if(typeof(T) == typeof(long))
                return NK.I64;
            else
                return kind_f<T>();
        }

        [MethodImpl(Inline)]
        static NK kind_f<T>()
        {
            if(typeof(T) == typeof(float))
                return NK.F32;
            else if(typeof(T) == typeof(double))
                return NK.F64;
            else
                return NK.None;            
        }
    }
}