//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using PK = PrimalKind;

    [ApiHost]
    public readonly struct PrimalKinds
    {
        /// <summary>
        /// Returns the type-code identified primal kind
        /// </summary>
        /// <param name="src">The type code</param>
        [MethodImpl(Inline), Op]
        public static PrimalKind kind(TypeCode src)
            => skip(Kinds, (uint)src);

        [MethodImpl(Inline), Op]
        public static PrimalKind kind(Type src)
            => kind(sys.typecode(src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static PrimalKind kind<T>()
            => kind(sys.typecode<T>());

        [MethodImpl(Inline)]
        public static bool test(Type src)
            => kind(src) != 0;

        [MethodImpl(Inline), Op]
        public static bool literal(PrimalKind src)
            => ((byte)src > 2 && (byte)src<16) || (byte)src == 18;

        /// <summary>
        /// Determines the literal kind of a type, if any
        /// </summary>
        /// <param name="src">The source type</param>
        [MethodImpl(Inline), Op]
        public static LiteralKind literal(Type src)
        {
            var i = index(src);
            var test = (i > 2 && i <16) || i == 18;
            return test ? (LiteralKind)z.skip(PrimalKindData,i) : LiteralKind.None;
        }

        /// <summary>
        /// Determines an enumeration's underlying kind
        /// </summary>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static EnumTypeCode ecode<E>(E e = default)
            where E : unmanaged, Enum
                => (EnumTypeCode)default(E).GetTypeCode();

        /// <summary>
        /// Determines an enumeration's underlying kind
        /// </summary>
        [MethodImpl(Inline), Op]
        public static EnumTypeCode ecode(Type src)
            => (EnumTypeCode)sys.typecode(src);

        /// <summary>
        /// Determines equality for unmanaged primitive values
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <typeparam name="T">The numeric type</typeparam>
        [MethodImpl(Inline), Eq, Closures(AllNumeric)]
        public static uint1 eq<T>(T a, T b)
            where T : unmanaged
                => eq_1(a,b);

        [MethodImpl(Inline)]
        static uint1 eq_1<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return uint8(a) == uint8(b);
            else if(typeof(T) == typeof(ushort))
                return uint16(a) == uint16(b);
            else if(typeof(T) == typeof(uint))
                return (uint32(a) == uint32(b));
            else if(typeof(T) == typeof(ulong))
                return (uint64(a) == uint64(b));
            else
                return eq_2(a,b);
        }

        [MethodImpl(Inline)]
        static uint1 eq_2<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return int8(a) == int8(b);
            else if(typeof(T) == typeof(short))
                 return int16(a) == int16(b);
            else if(typeof(T) == typeof(int))
                 return int32(a) == int32(b);
            else if(typeof(T) == typeof(long))
                 return int64(a) == int64(b);
             else
                return eq_3(a,b);
       }

        [MethodImpl(Inline)]
        static uint1 eq_3<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(bool))
                 return @byte(a) == @byte(b);
            else if(typeof(T) == typeof(char))
                 return c16(a) == c16(b);
            else if(typeof(T) == typeof(float))
                 return float32(a) == float32(b);
            else if(typeof(T) == typeof(double))
                 return float64(a) == float64(b);
            else
                throw no<T>();
        }

        [MethodImpl(Inline), Op]
        static byte index(Type src)
            => (byte)Type.GetTypeCode(src);

        static ReadOnlySpan<PrimalKind> Kinds
        {
            [MethodImpl(Inline), Op]
            get => recover<PrimalKind>(PrimalKindData);
        }

        //PrimalKindId|TypeCode -> PrimalKind
        static ReadOnlySpan<byte> PrimalKindData => new byte[19]{
            (byte)PK.None, //0:Empty/null
            (byte)PK.Object, //1:Object
            (byte)PK.DBNull, //2:DbNull
            (byte)PK.U1, //3:Bool
            (byte)PK.C16, //4:char
            (byte)PK.I8, //5:int8
            (byte)PK.U8, //6:uint8
            (byte)PK.I16, //7:short
            (byte)PK.U16, //8:ushort
            (byte)PK.I32, //9:int32
            (byte)PK.U32, //10:uint32
            (byte)PK.I64, //11:int64
            (byte)PK.U64, //12:uint64
            (byte)PK.F32, //13:float32
            (byte)PK.F64, //14:float64
            (byte)PK.F128, //15:decimal
            (byte)PK.DateTime, //16:datetime
            (byte)PK.None, // 17:empty
            (byte)PK.String //18:string
        };
    }
}