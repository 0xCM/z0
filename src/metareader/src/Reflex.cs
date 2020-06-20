//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    using TC = System.TypeCode;

    public readonly struct Reflex
    {
        public static Reflex Create()
            => new Reflex(0);
        
        Reflex(int i)
        {
            TypeData = new Type[19]{
            typeof(void),       //0
            typeof(object),     //1
            typeof(DBNull),     //2
            typeof(bool),       //3
            typeof(char),       //4
            typeof(sbyte),      //5
            typeof(byte),       //6
            typeof(short),      //7
            typeof(ushort),     //8
            typeof(int),        //9
            typeof(uint),       //10
            typeof(long),       //11
            typeof(ulong),      //12
            typeof(float),      //13
            typeof(double),     //14
            typeof(decimal),    //15
            typeof(DateTime),   //16
            typeof(void),       //17
            typeof(string),     //18
            };        

        }
    
        readonly Type[] TypeData {get;}
        
        public ReadOnlySpan<Type> Types 
            => TypeData;

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
            => ref Root.skip(Types, (int)code);    
    }
}