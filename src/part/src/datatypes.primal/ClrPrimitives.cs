//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static memory;
    using static Part;

    using PK = ClrPrimalKind;


    partial class XTend
    {
        public static TernaryBitLogicKind Next(this TernaryBitLogicKind src)
            => src != TernaryBitLogicKind.XFF
                ? (TernaryBitLogicKind)((uint)(src) + 1u)
                : TernaryBitLogicKind.X00;

        public static string Format(this TernaryBitLogicKind kind)
            => kind.ToString();

        public static string Format<T>(this TernaryBitLogicKind kind, T arg1, T arg2, T arg3)
            => $"{kind.Format()}({arg1}, {arg2}, {arg3})";
    }

    [ApiHost(ApiNames.ClrPrimitives, true)]
    public readonly partial struct ClrPrimitives
    {
        static ReadOnlySpan<ClrPrimalKind> Kinds
        {
            [MethodImpl(Inline), Op]
            get => recover<ClrPrimalKind>(PrimalKindData);
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