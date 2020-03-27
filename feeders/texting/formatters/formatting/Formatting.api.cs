//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Textual;

    public static class Formatters
    {
        [MethodImpl(Inline)]
        public static IFormatter<T,BitFormatConfig>  BitFormatter<T>()
            where T : struct
                =>  default(BitFormatter<T>);

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
                    throw Unsupported.define(kind);
            }
        }                
    }

    public static class Formatting
    {             
        /// <summary>
        /// Formats any object, using a custom formatter if it exists or invoking ToString() if not
        /// </summary>
        /// <param name="src">The object to format</param>
        [MethodImpl(Inline)]
        public static string format(object src)
            => src.GetFormatter().Format(src);

        [MethodImpl(Inline)]
        static IFormatter CreateFormatter(Type realization)
        {
            try
            {
                return (IFormatter)Activator.CreateInstance(realization);
            }
            catch(Exception)
            {
                return default(DefaultFormatter);
            }
        }

        [MethodImpl(Inline)]
        static IFormatter GetFormatter(this object src)
        {
            var attrib = src?.GetType()?.GetCustomAttribute<FormatterAttribute>();
            if(attrib != null)
                return CreateFormatter(attrib.Realization);
            else
                return default(DefaultFormatter);
        }

        /// <summary>
        /// Reifies a formatter via Object.ToString()
        /// </summary>
        readonly struct DefaultFormatter : IFormatter
        {
            [MethodImpl(Inline)]
            public string Format(object src)
                => src?.ToString() ?? string.Empty;
        }
    }
}