//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class XTend
    {
        public static string FormatNumeric<T>(this T src, NumericKind kind)
            where T : unmanaged, IFixed
        {
            var dst = BitConvert.GetBytes(in src);
            switch(kind)
            {
                case NumericKind.I8:
                    return dst.As<sbyte>().Format();
                case NumericKind.U8:
                    return dst.As<byte>().Format();
                case NumericKind.I16:
                    return dst.As<short>().Format();
                case NumericKind.U16:
                    return dst.As<ushort>().Format();
                case NumericKind.I32:
                    return dst.As<int>().Format();
                case NumericKind.U32:
                    return dst.As<uint>().Format();
                case NumericKind.I64:
                    return dst.As<long>().Format();
                case NumericKind.U64:
                    return dst.As<ulong>().Format();
                case NumericKind.F32:
                    return dst.As<float>().Format();
                case NumericKind.F64:
                    return dst.As<double>().Format();
                default:
                    throw Unsupported.define(kind);
            }
        }                
    }
}