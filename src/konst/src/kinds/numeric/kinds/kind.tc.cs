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
    using TC = System.TypeCode;


    partial class NumericKinds
    {            
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static TypeCode code<T>()
            => tc_u<T>();

        [MethodImpl(Inline)]
        static TC tc_u<T>()
        {
            if(typeof(T) == typeof(byte))
                return TC.Byte;
            else if(typeof(T) == typeof(ushort))
                return TC.UInt16;
            else if(typeof(T) == typeof(uint))
                return TC.UInt32;
            else if(typeof(T) == typeof(ulong))
                return TC.UInt64;
            else
                return tc_i<T>();
        }

        [MethodImpl(Inline)]
        static TC tc_i<T>()
        {
            if(typeof(T) == typeof(sbyte))
                return TC.SByte;
            else if(typeof(T) == typeof(short))
                return TC.Int16;
            else if(typeof(T) == typeof(int))
                return TC.Int32;
            else if(typeof(T) == typeof(long))
                return TC.Int64;
            else
                return tc_x<T>();
        }

        [MethodImpl(Inline)]
        static TC tc_x<T>()
        {
            if(typeof(T) == typeof(float))
                return TC.Single;
            else if(typeof(T) == typeof(double))
                return TC.Double;
            else if(typeof(T) == typeof(decimal))
                return TC.Decimal;
            else if(typeof(T) == typeof(char))
                return TC.Char;
            else if(typeof(T) == typeof(bool))
                return TC.Boolean;
            else
                return TC.Object;            
        }

        /// <summary>
        /// Determines the numeric kind identified by a type code, if any
        /// </summary>
        /// <param name="tc">The type code to evaluate</param>
        [Op]
        public static NumericKind kind(TypeCode tc)
        {
            switch(tc)
            {
                case TC.SByte:
                    return NK.I8;

                case TC.Byte:
                    return NK.U8;

                case TC.Int16:
                    return NK.I16;

                case TC.UInt16:
                    return NK.U16;
                
                case TC.Int32:
                    return NK.I32;

                case TC.UInt32:
                    return NK.U32;

                case TC.Int64:
                    return NK.I64;

                case TC.UInt64:
                    return NK.U64;

                case TC.Single:
                    return NK.F32;

                case TC.Double:
                    return NK.F64;
            }
            
            return NK.None;
        }
    }
}