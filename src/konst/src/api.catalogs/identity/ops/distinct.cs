//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static Konst;
    using static z;

    using NK = NumericKind;
    using ID = NumericApiKind;

    partial struct ApiIdentify
    {
        /// <summary>
        /// For a system-defined type, returns the C#-specific keyword for the type if it has one;
        /// otherwise, returns an empty string
        /// </summary>
        /// <param name="src">The type to test</param>
        [Op]
        public static string keyword(Type src)
        {
            if(src.IsSByte())
                return "sbyte";
            else if(src.IsByte())
                return "byte";
            else if(src.IsUInt16())
                return "ushort";
            else if(src.IsInt16())
                return "short";
            else if(src.IsInt32())
                return "int";
            else if(src.IsUInt32())
                return "uint";
            else if(src.IsInt64())
                return "long";
            else if(src.IsUInt64())
                return "ulong";
            else if(src.IsSingle())
                return "float";
            else if(src.IsDouble())
                return "double";
            else if(src.IsDecimal())
                return "decimal";
            else if(src.IsBool())
                return "bool";
            else if(src.IsChar())
                return "char";
            else if(src.IsString())
                return "string";
            else if(src.IsVoid())
                return "void";
            else if(src.IsObject())
                return "object";
            else
                return EmptyString;
        }

        [Op]
        public static HashSet<NumericKind> distinct(NumericKind k)
        {
            var dst = new HashSet<NumericKind>();
            if(NumericKinds.contains(k, ID.U8))
                dst.Add(NK.U8);

            if(NumericKinds.contains(k, ID.I8))
                dst.Add(NK.I8);

            if(NumericKinds.contains(k, ID.U16))
                dst.Add(NK.U16);

            if(NumericKinds.contains(k, ID.I16))
                dst.Add(NK.I16);

            if(NumericKinds.contains(k, ID.U32))
                dst.Add(NK.U32);

            if(NumericKinds.contains(k, ID.I32))
                dst.Add(NK.I32);

            if(NumericKinds.contains(k, ID.U64))
                dst.Add(NK.U64);

            if(NumericKinds.contains(k, ID.I64))
                dst.Add(NK.I64);

            if(NumericKinds.contains(k, ID.F32))
                dst.Add(NK.F32);

            if(NumericKinds.contains(k, ID.F64))
                dst.Add(NK.F64);

            return dst;
        }
    }
}