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
        static ReadOnlySpan<ClrPrimalKind> Kinds
        {
            [MethodImpl(Inline), Op]
            get => recover<ClrPrimalKind>(PrimalKindData);
        }

        //PrimalKindId|TypeCode -> PrimalKind
        static ReadOnlySpan<byte> PrimalKindData => new byte[19]{
            (byte)ClrPrimalKind.None, //0:Empty/null
            (byte)ClrPrimalKind.Object, //1:Object
            (byte)ClrPrimalKind.DBNull, //2:DbNull
            (byte)ClrPrimalKind.U1, //3:Bool
            (byte)ClrPrimalKind.C16, //4:char
            (byte)ClrPrimalKind.I8, //5:int8
            (byte)ClrPrimalKind.U8, //6:uint8
            (byte)ClrPrimalKind.I16, //7:short
            (byte)ClrPrimalKind.U16, //8:ushort
            (byte)ClrPrimalKind.I32, //9:int32
            (byte)ClrPrimalKind.U32, //10:uint32
            (byte)ClrPrimalKind.I64, //11:int64
            (byte)ClrPrimalKind.U64, //12:uint64
            (byte)ClrPrimalKind.F32, //13:float32
            (byte)ClrPrimalKind.F64, //14:float64
            (byte)ClrPrimalKind.F128, //15:decimal
            (byte)ClrPrimalKind.DateTime, //16:datetime
            (byte)ClrPrimalKind.None, // 17:empty
            (byte)ClrPrimalKind.String //18:string
        };
    }
}