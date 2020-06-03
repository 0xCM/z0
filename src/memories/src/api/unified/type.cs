//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using TC = System.TypeCode;

    partial class Memories
    {
        /// <summary>
        /// Produces the parametrically-identified reflected system type
        /// </summary>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Type type<T>()
            => typeof(T);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public ref readonly Type type_alt<T>()
            => ref type_u<T>();        

        [MethodImpl(Inline)]
        ref readonly Type type_u<T>()
        {
            if(typeof(T) == typeof(byte))
                return ref indexed(TC.Byte);
            else if(typeof(T) == typeof(ushort))
                return ref indexed(TC.UInt16);
            else if(typeof(T) == typeof(uint))
                return ref indexed(TC.UInt32);
            else if(typeof(T) == typeof(ulong))
                return ref indexed(TC.UInt64);
            else
                return ref type_i<T>();
        }

        [MethodImpl(Inline)]
        ref readonly Type type_i<T>()
        {
            if(typeof(T) == typeof(sbyte))
                return ref indexed(TC.SByte);
            else if(typeof(T) == typeof(short))
                return ref indexed(TC.Int16);
            else if(typeof(T) == typeof(int))
                return ref indexed(TC.Int32);
            else if(typeof(T) == typeof(long))
                return ref indexed(TC.Int64);
            else
                return ref type_f<T>();
        }

        [MethodImpl(Inline)]
        ref readonly Type type_f<T>()
        {
            if(typeof(T) == typeof(float))
                return ref indexed(TC.Single);
            else if(typeof(T) == typeof(double))
                return ref indexed(TC.Double);
            else if(typeof(T) == typeof(char))
                return ref indexed(TC.Char);
            else if(typeof(T) == typeof(string))
                return ref indexed(TC.String);
            else
                return ref type_x<T>();
        }

        [MethodImpl(Inline)]
        ref readonly Type type_x<T>()
        {
            if(typeof(T) == typeof(decimal))
                return ref indexed(TC.Decimal);
            else if(typeof(T) == typeof(DateTime))
                return ref indexed(TC.DateTime);
            else if(typeof(T) == typeof(object))
                return ref indexed(TC.Object);
            else
                return ref indexed(0);
        }

        [MethodImpl(Inline)]
        ref readonly Type indexed(TC code)
            => ref Control.skip(Module.Types, (int)code);    
    }
}