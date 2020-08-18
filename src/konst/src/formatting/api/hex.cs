//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;
    using static z;
        
    partial struct Render
    {
        /// <summary>
        /// Renders a primal numeric value as hex-formatted text
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="zpad">Specifies whether the output should be 0-padded to the data type width</param>
        /// <param name="specifier">Specifies whether the output should be prefixed/postfixed with a hex specifier</param>
        /// <param name="uppercase">Specifies whether the alphabetic hex digits should be uppercased</param>
        /// <param name="prespec">Specifies whether the hex specifier, if emitted, should be the canonical prefix or postfix specifier</param>
        /// <typeparam name="T">The primal numeric type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static string hex<T>(T src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            where T : unmanaged
                => Hex.format(src,zpad, specifier, uppercase,prespec);

        /// <summary>
        /// Renders a sequence of primal numeric T-cells as a sequence of hex-formatted values 
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="config">The format configuration</param>
        /// <param name="dst">The rendered data receiver</param>
        /// <typeparam name="T">The primal numeric type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void hex<T>(ReadOnlySpan<T> src, in HexFormatConfig config, StringBuilder dst)
            where T : unmanaged
        {
            var count = src.Length;
            ref readonly var cell = ref first(src);
            var last = count - 1;
            for(var i=0u; i<count; i++)
            {
                ref readonly var current = ref skip(cell,i);
                var formatted = hex(current, config.ZPad, config.Specifier, config.Uppercase, config.PreSpec);
                dst.Append(formatted);

                if(i != last)
                    dst.Append(config.Delimiter);
            }                        
        }   

        [MethodImpl(Inline), Op]
        static string hex64(ulong src, bool postspec = false)
            => src.ToString(HexFormatSpecs.SmallHexSpec) + (postspec ? HexFormatSpecs.PostSpec : EmptyString);

        [MethodImpl(Inline), Op]
        static string hex8(byte src, bool postspec = false)
            => hex64(((ulong)src), postspec);

        [MethodImpl(Inline), Op]
        static string hex16(ushort src, bool postspec = false)
            => hex64(((ulong)src), postspec);

        [MethodImpl(Inline), Op]
        static string hex32(uint src, bool postspec = false)
            => hex64(((ulong)src), postspec);

        [MethodImpl(Inline), Op]
        public static string hex(W8 w, byte src, bool postspec = false)
            => hex8(src,postspec);

        [MethodImpl(Inline), Op]
        public static string hex(W16 w, ushort src, bool postspec = false)
            => hex16(src,postspec);

        [MethodImpl(Inline), Op]
        public static string hex(W32 w, uint src, bool postspec = false)
            => hex32(src,postspec);

        [MethodImpl(Inline), Op]
        public static string hex(W64 w, ulong src, bool postspec = false)
            => hex64(src,postspec);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static string hex<T>(W8 w, T src, bool postspec = false)
            where T : unmanaged
                => hex8(uint8(src), postspec);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static string hex<T>(W16 w, T src, bool postspec = false)
            where T : unmanaged
                => hex16(uint16(src), postspec);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static string hex<T>(W32 w, T src, bool postspec = false)
            where T : unmanaged
                => hex32(uint32(src), postspec);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static string hex<T>(W64 w, T src, bool postspec = false)
             where T : unmanaged
                => hex64(uint64(src), postspec);
    }
}