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

    using NK = ClrEnumCode;

    partial struct ClrEnums
    {

        /// <summary>
        /// Attempts to parses an enumeration literal, ignoring case, and returns a default value if parsing failed
        /// </summary>
        /// <param name="name">The literal name</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static E parse<E>(string name, E @default)
            where E : unmanaged, Enum
        {
            if(Enum.TryParse(name,true,out E result))
                return result;
            else
                return @default;
        }

        /// <summary>
        /// Attempts o parse an enum literal, ignoring case, and returns a null value if parsing failed
        /// </summary>
        /// <param name="name">The literal name</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static ParseResult<E> parse<E>(string name)
            where E : unmanaged, Enum
        {
            if(Enum.TryParse(name, true, out E result))
                return root.parsed(name, result);
            else
                return root.unparsed<E>(name);
        }


        public static string format<E>(E src, Base2 n, int? digits = null)
            where E : unmanaged, Enum
                => ecode<E>() switch {
                    NK.U8 => Numeric.Format(e8u(src), n, digits),
                    NK.I8 => Numeric.format(e8i(src), n, digits),
                    NK.I16 => Numeric.Format(e16i(src), n, digits),
                    NK.U16 => Numeric.Format(e16u(src), n, digits),
                    NK.I32 => Numeric.Format(e32i(src), n, digits),
                    NK.U32 => Numeric.Format(e32u(src), n, digits),
                    NK.I64 => Numeric.Format(e64i(src), n, digits),
                    NK.U64 => Numeric.Format(e64u(src), n, digits),
                    _ => src.ToString(),
                };

        public static string format<E>(E src, Base8 n)
            where E : unmanaged, Enum
                => ecode<E>() switch {
                    NK.U8 => Numeric.Format(e8u(src), n),
                    NK.I8 => Numeric.format(e8i(src), n),
                    NK.I16 => Numeric.Format(e16i(src), n),
                    NK.U16 => Numeric.Format(e16u(src), n),
                    NK.I32 => Numeric.Format(e32i(src), n),
                    NK.U32 => Numeric.Format(e32u(src), n),
                    NK.I64 => Numeric.Format(e64i(src), n),
                    NK.U64 => Numeric.Format(e64u(src), n),
                    _ => src.ToString(),
                };

        public static string format<E>(E src, Base16 n, int? digits = null)
            where E : unmanaged, Enum
                => ecode<E>() switch {
                    NK.U8 => Numeric.Format(e8u(src), n, digits),
                    NK.I8 => Numeric.format(e8i(src), n, digits),
                    NK.I16 => Numeric.Format(e16i(src), n, digits),
                    NK.U16 => Numeric.Format(e16u(src), n, digits),
                    NK.I32 => Numeric.Format(e32i(src), n, digits),
                    NK.U32 => Numeric.Format(e32u(src), n, digits),
                    NK.I64 => Numeric.Format(e64i(src), n, digits),
                    NK.U64 => Numeric.Format(e64u(src), n, digits),
                    _ => src.ToString(),
                };

        public static string format<E>(E src, Base10 b, int? digits = null)
            where E : unmanaged, Enum
                => ecode<E>() switch {
                    NK.U8 => Numeric.Format(e8u(src), b, digits),
                    NK.I8 => Numeric.format(e8i(src), b, digits),
                    NK.I16 => Numeric.Format(e16i(src), b, digits),
                    NK.U16 => Numeric.Format(e16u(src), b, digits),
                    NK.I32 => Numeric.Format(e32i(src), b, digits),
                    NK.U32 => Numeric.Format(e32u(src), b, digits),
                    NK.I64 => Numeric.Format(e64i(src), b, digits),
                    NK.U64 => Numeric.Format(e64u(src), b, digits),
                    _ => src.ToString(),
                };

        public static string format<E>(E src, NumericBaseKind b, int? digits = null)
            where E : unmanaged, Enum
                => ecode<E>() switch {
                    NK.U8 => Numeric.Format(e8u(src), b, digits),
                    NK.I8 => Numeric.format(e8i(src), b, digits),
                    NK.I16 => Numeric.Format(e16i(src), b, digits),
                    NK.U16 => Numeric.Format(e16u(src), b, digits),
                    NK.I32 => Numeric.Format(e32i(src), b, digits),
                    NK.U32 => Numeric.Format(e32u(src), b, digits),
                    NK.I64 => Numeric.Format(e64i(src), b, digits),
                    NK.U64 => Numeric.Format(e64u(src), b, digits),
                    _ => src.ToString(),
                };
    }
}