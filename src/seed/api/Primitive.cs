//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using PK = PrimalKind;

    [ApiHost]
    public readonly struct Primitive
    {
        /// <summary>
        /// Returns the type-code identified primal kind
        /// </summary>
        /// <param name="src">The type code</param>
        [MethodImpl(Inline), Op]
        public static PrimalKind kind(TypeCode src)
            => Root.skip(Kinds,(int)src);

        [MethodImpl(Inline), Op]
        public static PrimalKind kind(Type src)
            => kind(Type.GetTypeCode(src));

        [MethodImpl(Inline), Op]
        public static PrimalKind kind<T>()
            => kind(typeof(T));

        static ReadOnlySpan<PrimalKind> Kinds
        {
            [MethodImpl(Inline)]
            get => Root.cast<PrimalKind>(PrimalKindData);
        }

        //PrimalKindId|TypeCode -> PrimalKind                
        static ReadOnlySpan<byte> PrimalKindData => new byte[19]{
            (byte)PK.None, //0:Empty/null
            (byte)PK.Object, //1:Object
            (byte)PK.DBNull, //2:DbNull
            (byte)PK.U1, //3:Bool
            (byte)PK.Char16, //4:char
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