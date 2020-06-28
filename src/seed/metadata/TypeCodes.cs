//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
 
    using static Konst;

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
        public TypeCodes(int i)
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
}