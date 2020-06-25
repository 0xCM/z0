//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

 
    using static Konst;
    using static Root;
    using static Typed;
    

    public readonly struct TypeCodes
    {
        /// <summary>
        /// 0
        /// </summary>
        readonly PrimalKindId @null;
        
        /// <summary>
        /// 1
        /// </summary>
        readonly PrimalKindId obj;

        /// <summary>
        /// 2
        /// </summary>
        readonly PrimalKindId dbnull;

        /// <summary>
        /// 3
        /// </summary>
        readonly PrimalKindId u1;

        /// <summary>
        /// 4
        /// </summary>
        readonly PrimalKindId c16;

        /// <summary>
        /// 5
        /// </summary>
        readonly PrimalKindId i8;

        /// <summary>
        /// 6
        /// </summary>
        readonly PrimalKindId u8;

        /// <summary>
        /// 7
        /// </summary>
        readonly PrimalKindId i16;

        /// <summary>
        /// 8
        /// </summary>
        readonly PrimalKindId u16;

        /// <summary>
        /// 9
        /// </summary>
        readonly PrimalKindId i32;

        /// <summary>
        /// 10
        /// </summary>
        readonly PrimalKindId u32;

        /// <summary>
        /// 11
        /// </summary>
        readonly PrimalKindId i64;

        /// <summary>
        /// 12
        /// </summary>
        readonly PrimalKindId u64;

        /// <summary>
        /// 13
        /// </summary>
        readonly PrimalKindId f32;

        /// <summary>
        /// 14
        /// </summary>
        readonly PrimalKindId f64;

        /// <summary>
        /// 15
        /// </summary>
        readonly PrimalKindId f128;

        /// <summary>
        /// 16
        /// </summary>
        readonly PrimalKindId dt;

        /// <summary>
        /// 17
        /// </summary>
        readonly PrimalKindId _;

        /// <summary>
        /// 18
        /// </summary>
        readonly PrimalKindId s;

        readonly Type[] Types;

        [MethodImpl(Inline)]
        internal TypeCodes(int i)
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
            _ = (PrimalKindId)17;      
            s = TypeCode.String.ToKind();
            Types = CodedTypes;
        }

        [MethodImpl(Inline)]
        public unsafe TypeCode Lookup(byte index)        
        {
            var address = Root.location(this);
            return (TypeCode)(*(address + index).Pointer<byte>());
        }

        [MethodImpl(Inline)]
        public ref readonly Type Type(TypeCode tc)        
            => ref Types[(int)tc];

        public ref readonly Type this[TypeCode tc]
        {
            [MethodImpl(Inline)]
            get => ref Type(tc);
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


        public static TypeIndex Index()
            => new TypeIndex(CodedTypes);
    }

    public readonly struct TypeIndex
    {
        readonly Type[] PrimalTypes;

        [MethodImpl(Inline)]
        public TypeIndex(Type[] src)
            => PrimalTypes = src;

        public ref readonly Type this[TypeCode code]
        {
            [MethodImpl(Inline)]
            get => ref PrimalTypes[(int)code];
        }
    }

    public readonly struct TypeLU
    {
        internal readonly TxN<sbyte,byte,short,ushort,int,uint,long,ulong,float,double> T;
                
        TypeLU(int i)
        {
            T = Tx.T<sbyte,byte,short,ushort,int,uint,long,ulong,float,double>();
        }        

    }

    [ApiHost]
    public readonly struct TypeLookups
    {        
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Type match<T>(in TypeLU src)
            => src.T.match<T>();

        [MethodImpl(Inline), Op]
        static unsafe ref readonly Type fetchU(in TypeLU lu, byte index)
        {
            var address = Root.location(lu);
            var offset = (byte)index;
            var pType = (address + offset).Pointer<ulong>();
            return ref As.@ref<ulong,Type>(pType);                    
        }

        [MethodImpl(Inline), Op]
        public static ref readonly Type type(in TypeIndex lu, TypeCode index)
            => ref lu[index];        

        [MethodImpl(Inline), Op]
        public static ref readonly Type type(in TypeCodes lu, TypeCode index)
            => ref lu[index];        

        [MethodImpl(Inline), Op]
        public static ref readonly Type type(in TypeLU lu, byte index)
            => ref fetchU(lu,index);

        [MethodImpl(Inline), Op]
        public static TypeCode test_1(in TypeLU lu, in TypeCodes codes, in TypeIndex index)
        {
            byte i = 3;
            var t = type(lu, i);
            return  codes.Lookup(i);
        }

        [MethodImpl(Inline), Op]
        public static Type test_2(in TypeLU lu, in TypeCodes codes, in TypeIndex index)
        {
            byte i = 5;
            var t1 = type(lu, i);
            var c1 = codes.Lookup(i);
            var t2 = index[(TypeCode)c1];
            return t2;
        }

        [MethodImpl(Inline), Op]
        public static bool test_3(in TypeCodes codes)
        {
            byte i = 5;
            var t2 = codes[(TypeCode)i];
            var ok = t2.Name == "Byte";
            return ok;
        }

        [MethodImpl(Inline), Op]
        public static TypeCodes codes()
            => new TypeCodes(0); 
        
        [MethodImpl(Inline), Op]
        public static TypeIndex index()
            => TypeCodes.Index();
    }

    unsafe struct FixedTest
    {
        fixed ulong Data[10];

        TxN<sbyte,byte,short,ushort,int,uint> T;
        

        [MethodImpl(Inline), Op]
        public static FixedTest init(ref ulong src)
        {
            var lu = new FixedTest();
            var pData = lu.Data;
            *pData++ = skip(src,0);
            *pData++ = skip(src,1);
            *pData++ = skip(src,2);
            *pData++ = skip(src,3);
            *pData++ = skip(src,4);
            *pData++ = skip(src,5);
            *pData++ = skip(src,6);
            *pData++ = skip(src,7);
            *pData++ = skip(src,8);
            *pData++ = skip(src,9);
            return lu;
        }

        [MethodImpl(Inline), Op]
        public static ref ulong Lookup(in FixedTest src, byte index)
        {
            fixed(ulong* pData = src.Data)
            {
                ref var rData = ref Unsafe.AsRef<ulong>(pData);
                return ref Unsafe.Add(ref rData, index);
            }            
        }
    }
}