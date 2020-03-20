//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Root;

    /// <summary>
    /// Exposes formatting capabilites via exension methods
    /// </summary>
    partial class FormattingOps
    {
        public static string FormatNumeric<T>(this T src, NumericKind kind)
            where T : unmanaged, IFixed
        {
            var dst = BitConvert.GetBytes(in src);
            switch(kind)
            {
                case NumericKind.I8:
                    return dst.As<sbyte>().FormatDataList();
                case NumericKind.U8:
                    return dst.As<byte>().FormatDataList();
                case NumericKind.I16:
                    return dst.As<short>().FormatDataList();
                case NumericKind.U16:
                    return dst.As<ushort>().FormatDataList();
                case NumericKind.I32:
                    return dst.As<int>().FormatDataList();
                case NumericKind.U32:
                    return dst.As<uint>().FormatDataList();
                case NumericKind.I64:
                    return dst.As<long>().FormatDataList();
                case NumericKind.U64:
                    return dst.As<ulong>().FormatDataList();
                case NumericKind.F32:
                    return dst.As<float>().FormatDataList();
                case NumericKind.F64:
                    return dst.As<double>().FormatDataList();
                default:
                    throw unsupported(kind);
            }
        }
    }
}