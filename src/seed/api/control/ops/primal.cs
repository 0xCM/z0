//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    using PK = PrimalKind;

    partial class Control
    {
        /// <summary>
        /// Returns the type-code identified primal kind
        /// </summary>
        /// <param name="src">The type code</param>
        [MethodImpl(Inline), Op]
        public static PrimalKind primal(TypeCode src)
            => Control.skip(PrimalKinds,(int)src);

        [MethodImpl(Inline), Op]
        public static PrimalKind primal(Type src)
            => primal(Type.GetTypeCode(src));

        [MethodImpl(Inline), Op]
        public static PrimalKind primal<T>()
            => primal(typeof(T));

        static ReadOnlySpan<PrimalKind> PrimalKinds
        {
            [MethodImpl(Inline)]
            get => cast<PrimalKind>(PrimalKindData);
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