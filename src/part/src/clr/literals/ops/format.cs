//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    using PK = PrimalCode;

    partial struct ClrLiterals
    {
        [MethodImpl(Inline)]
        static string hex<T>(T src)
            where T : unmanaged
                => HexFormat.format(src, false, false);
        [Op]
        public static string format(object data, PrimalCode code)
            => code switch {
                PK.String => cast<string>(data),
                PK.C16 => cast<char>(data).ToString(),
                PK.I8 => hex(cast<sbyte>(data)),
                PK.U8 => hex(cast<byte>(data)),
                PK.I16 => hex(cast<short>(data)),
                PK.U16 => hex(cast<ushort>(data)),
                PK.I32 => hex(cast<int>(data)),
                PK.U32 => hex(cast<uint>(data)),
                PK.I64 => hex(cast<long>(data)),
                PK.U64 => hex(cast<ulong>(data)),
                PK.F32 => hex(cast<float>(data)),
                PK.F64 => hex(cast<double>(data)),
                PK.F128 => hex(cast<decimal>(data)),
                PK.U1 => cast<bool>(data).ToString(),
                _ =>  $"{code} unrecognized"
            };

        [Op]
        public static string format(in FieldRef src)
        {
            var datatype = src.KindId;
            var data = src.Field.GetRawConstantValue();
            if(src.Field.FieldType.IsEnum)
                return data.ToString();

            return format(data, src.KindId);
        }
    }
}