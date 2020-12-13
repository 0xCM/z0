//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using TC = System.TypeCode;

    readonly struct ClrTypeCodeCache
    {
        static internal readonly ClrTypeCodes Data = new ClrTypeCodes(0);
    }

    [ApiHost(ApiNames.ClrTypeCodes, true)]
    public readonly struct ClrTypeCodes
    {
        [MethodImpl(Inline), Op]
        public static ref readonly ClrTypeCodes cached()
            => ref ClrTypeCodeCache.Data;

        [MethodImpl(Inline), Op]
        public static TypeCodeIndex index(in ClrTypeCodes src)
            => new TypeCodeIndex(src.Types);

        [MethodImpl(Inline), Op]
        public static ref readonly Type type(in ClrTypeCodes src, TypeCode tc)
            => ref src[tc];

        [MethodImpl(Inline), Op]
        public static ref readonly Type type(in TypeCodeIndex src, TypeCode tc)
            => ref src[tc];

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public Type type<T>()
            => type_u<T>();

        public ref readonly Type this[TypeCode tc]
        {
            [MethodImpl(Inline)]
            get => ref Types[(int)tc];
        }

        /// <summary>
        /// 0
        /// </summary>
        readonly PrimalTypeCode @null;

        /// <summary>
        /// 1
        /// </summary>
        readonly PrimalTypeCode obj;

        /// <summary>
        /// 2
        /// </summary>
        readonly PrimalTypeCode dbnull;

        /// <summary>
        /// 3
        /// </summary>
        readonly PrimalTypeCode u1;

        /// <summary>
        /// 4
        /// </summary>
        readonly PrimalTypeCode c16;

        /// <summary>
        /// 5
        /// </summary>
        readonly PrimalTypeCode i8;

        /// <summary>
        /// 6
        /// </summary>
        readonly PrimalTypeCode u8;

        /// <summary>
        /// 7
        /// </summary>
        readonly PrimalTypeCode i16;

        /// <summary>
        /// 8
        /// </summary>
        readonly PrimalTypeCode u16;

        /// <summary>
        /// 9
        /// </summary>
        readonly PrimalTypeCode i32;

        /// <summary>
        /// 10
        /// </summary>
        readonly PrimalTypeCode u32;

        /// <summary>
        /// 11
        /// </summary>
        readonly PrimalTypeCode i64;

        /// <summary>
        /// 12
        /// </summary>
        readonly PrimalTypeCode u64;

        /// <summary>
        /// 13
        /// </summary>
        readonly PrimalTypeCode f32;

        /// <summary>
        /// 14
        /// </summary>
        readonly PrimalTypeCode f64;

        /// <summary>
        /// 15
        /// </summary>
        readonly PrimalTypeCode f128;

        /// <summary>
        /// 16
        /// </summary>
        readonly PrimalTypeCode dt;

        /// <summary>
        /// 17
        /// </summary>
        readonly PrimalTypeCode _;

        /// <summary>
        /// 18
        /// </summary>
        readonly PrimalTypeCode s;

        internal readonly Type[] Types;

        [MethodImpl(Inline)]
        public ClrTypeCodes(int i)
        {
            @null = TypeCode.Empty.ToKind();
            obj = TypeCode.Object.ToKind();
            dbnull = TypeCode.DBNull.ToKind();
            u1 = TypeCode.Boolean.ToKind();
            i8 = TypeCode.SByte.ToKind();
            u8 = TypeCode.Byte.ToKind();
            i16 = TypeCode.Int16.ToKind();
            u16 = TypeCode.UInt16.ToKind();
            i32 = TypeCode.Int32.ToKind();
            u32 = TypeCode.UInt32.ToKind();
            i64 = TypeCode.Int64.ToKind();
            u64 = TypeCode.UInt64.ToKind();
            f32 = TypeCode.Single.ToKind();
            f64 = TypeCode.Double.ToKind();
            f128 = TypeCode.Decimal.ToKind();
            c16 = TypeCode.Char.ToKind();
            dt = TypeCode.DateTime.ToKind();
            _ = (PrimalTypeCode)17;
            s = TypeCode.String.ToKind();
            Types = CodedTypes;
        }

        internal static Type[] CodedTypes
        {
            get
            {
                return new Type[19]{
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
        }

        [MethodImpl(Inline)]
        internal Type type_u<T>()
        {
            if(typeof(T) == typeof(byte))
                return indexed(TC.Byte);
            else if(typeof(T) == typeof(ushort))
                return indexed(TC.UInt16);
            else if(typeof(T) == typeof(uint))
                return indexed(TC.UInt32);
            else if(typeof(T) == typeof(ulong))
                return indexed(TC.UInt64);
            else
                return type_i<T>();
        }

        [MethodImpl(Inline)]
        Type type_i<T>()
        {
            if(typeof(T) == typeof(sbyte))
                return indexed(TC.SByte);
            else if(typeof(T) == typeof(short))
                return indexed(TC.Int16);
            else if(typeof(T) == typeof(int))
                return indexed(TC.Int32);
            else if(typeof(T) == typeof(long))
                return indexed(TC.Int64);
            else
                return type_f<T>();
        }

        [MethodImpl(Inline)]
        Type type_f<T>()
        {
            if(typeof(T) == typeof(float))
                return indexed(TC.Single);
            else if(typeof(T) == typeof(double))
                return indexed(TC.Double);
            else if(typeof(T) == typeof(char))
                return indexed(TC.Char);
            else if(typeof(T) == typeof(string))
                return indexed(TC.String);
            else
                return type_x<T>();
        }

        [MethodImpl(Inline)]
        Type type_x<T>()
        {
            if(typeof(T) == typeof(decimal))
                return indexed(TC.Decimal);
            else if(typeof(T) == typeof(DateTime))
                return indexed(TC.DateTime);
            else if(typeof(T) == typeof(object))
                return indexed(TC.Object);
            else
                return indexed(0);
        }

        [MethodImpl(Inline)]
        Type indexed(TC code)
            => Types[(uint)code];
    }
}