//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    using PK = PrimalKindId;    

    partial struct LiteralFields
    {
        [Op]
        public static string format(in FieldRef src)
        {       
            var datatype = src.KindId;
            var data = src.Reference.Load();
            return datatype switch {
                PK.String => sys.@string(span16c(src.Reference.Load())),
                PK.C16 => sys.@string(data.AsChar()),
                PK.I8 => hex(first(data.AsInt8())),
                PK.U8 => hex(first(data)),
                PK.I16 => hex(first(data.AsInt16())),
                PK.U16 => hex(first(data.AsUInt16())),
                PK.I32 => hex(first(data.AsInt32())),
                PK.U32 => hex(first(data.AsUInt32())),
                PK.I64 => hex(first(data.AsInt64())),
                PK.U64 => hex(first(data.AsUInt64())),
                PK.F32 => hex(first(data.AsFloat32())),
                PK.F64 => hex(first(data.AsFloat64())),
                PK.F128 => hex(first(data.AsFloat128())),
                PK.U1 => first(data.AsBool()).ToString(),
                _ =>  data.FormatHex()
            };
        }

        [MethodImpl(Inline)]
        static string hex<T>(T src)
            where T : unmanaged
                => Hex.format(src, false, false);        
    }
}