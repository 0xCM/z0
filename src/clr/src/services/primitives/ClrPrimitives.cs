//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    [ApiHost]
    public readonly partial struct ClrPrimitives
    {
        static ReadOnlySpan<PrimitiveKind> Kinds
        {
            [MethodImpl(Inline), Op]
            get => recover<PrimitiveKind>(PrimalKindData);
        }

        //PrimalKindId|TypeCode -> PrimalKind
        static ReadOnlySpan<byte> PrimalKindData => new byte[19]{
            (byte)PrimitiveKind.None, //0:Empty/null
            (byte)PrimitiveKind.Object, //1:Object
            (byte)PrimitiveKind.DBNull, //2:DbNull
            (byte)PrimitiveKind.U1, //3:Bool
            (byte)PrimitiveKind.C16, //4:char
            (byte)PrimitiveKind.I8, //5:int8
            (byte)PrimitiveKind.U8, //6:uint8
            (byte)PrimitiveKind.I16, //7:short
            (byte)PrimitiveKind.U16, //8:ushort
            (byte)PrimitiveKind.I32, //9:int32
            (byte)PrimitiveKind.U32, //10:uint32
            (byte)PrimitiveKind.I64, //11:int64
            (byte)PrimitiveKind.U64, //12:uint64
            (byte)PrimitiveKind.F32, //13:float32
            (byte)PrimitiveKind.F64, //14:float64
            (byte)PrimitiveKind.F128, //15:decimal
            (byte)PrimitiveKind.DateTime, //16:datetime
            (byte)PrimitiveKind.None, // 17:empty
            (byte)PrimitiveKind.String //18:string
        };
    }
}