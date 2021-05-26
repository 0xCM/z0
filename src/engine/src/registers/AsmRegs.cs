//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static RegFacets;

    [ApiHost]
    public readonly partial struct AsmRegs
    {
        [Op, Closures(UnsignedInts)]
        public static string format<T>(IReg<T> src)
            where T : unmanaged
        {
            switch(src.Width)
            {
                case RegWidth.W8:
                    return format(src as IReg8<T>);
                case RegWidth.W16:
                    return format(src as IReg16<T>);
                case RegWidth.W32:
                    return format(src as IReg32<T>);
                case RegWidth.W64:
                    return format(src as IReg64<T>);
                default:
                    var data = bytes(src.Content);
                    var formatter = HexFormatter.formatter<byte>();
                    return formatter.Format(data);
            }
        }

        [Op, Closures(UInt8k)]
        public static string format<T>(IReg8<T> src)
            where T : unmanaged
                => bw8(src.Content).FormatHex(specifier:false);

        [Op, Closures(UInt16k)]
        public static string format<T>(IReg16<T> src)
            where T : unmanaged
                => bw16(src.Content).FormatHex(specifier:false);

        [Op, Closures(UInt32k)]
        public static string format<T>(IReg32<T> src)
            where T : unmanaged
                => bw32(src.Content).FormatHex(specifier:false);

        [Op, Closures(UInt64k)]
        public static string format<T>(IReg64<T> src)
            where T : unmanaged
                => bw64(src.Content).FormatHex(specifier:false);

        [Op]
        public static Index<RegClass> classes()
            => Enums.literals<RegClass>();

        [Op]
        public static Index<RegWidth> widths()
            => Enums.literals<RegWidth>();

        [Op]
        public static AsmRegQuery query()
            => new AsmRegQuery(list());

        [MethodImpl(Inline), Op]
        public static Register model(RegKind kind)
            => kind;

        [MethodImpl(Inline), Op]
        public static Register model(RegIndex c, RegClass k, RegWidth w)
            => new Register(c, k, w);

        [MethodImpl(Inline), Op]
        public static Register model(@enum<RegKind,uint> src)
            => new Register(src.Literal);

        /// <summary>
        /// Determines the register code from the kind
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline), Op]
        public static RegIndex index(RegKind src)
            => (RegIndex)Bits.bitslice((uint)src, (byte)FieldIndex.C, (byte)FieldWidth.C);

        /// <summary>
        /// Determines the register class from the kind
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline), Op]
        public static RegClass @class(RegKind src)
            => (RegClass)Bits.bitslice((uint)src, (byte)FieldIndex.K, (byte)FieldWidth.K);

        /// <summary>
        /// Determines the register width from the kind
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline), Op]
        public static RegWidth width(RegKind src)
            => (RegWidth)Bits.bitslice((uint)src, (byte)FieldIndex.W, (byte)FieldWidth.W);

        [MethodImpl(Inline)]
        public static void split(RegKind src, out RegIndex c, out RegClass k, out RegWidth w)
        {
            c = AsmRegs.index(src);
            k = AsmRegs.@class(src);
            w = AsmRegs.width(src);
        }


        [Op]
        public static string format(Register src)
        {
            const string Sep = " | ";
            const string Pattern = "[{0,-12} | {1,-8} | {2}]";
            var index = BitFields.format<RegIndex,byte>(src.Code, src.Name, 5);
            var @class = BitFields.format<RegClass,byte>(src.Class, src.Class.ToString(), 4);
            var width = Enums.field<RegWidth,ushort>(src.Width, base10, "Width");
            return string.Format(Pattern, index, @class, width);
        }

        [MethodImpl(Inline), Op]
        public static uint filter(RegClass @class, ReadOnlySpan<Register> src, Span<Register> dst)
        {
            var k=0u;
            var j = root.min(src.Length, dst.Length);
            for(var i=0; i<j; i++)
            {
                ref readonly var candidate = ref skip(src,i);

                if(invalid(candidate.Code))
                    continue;

                if(candidate.Class == @class)
                    seek(dst,k++) = candidate;
            }
            return k;
        }

        [MethodImpl(Inline), Op]
        public static uint filter(RegWidth width, ReadOnlySpan<Register> src, Span<Register> dst)
        {
            var k=0u;
            var j = root.min(src.Length, dst.Length);
            for(var i=0; i<j; i++)
            {
                ref readonly var candidate = ref skip(src,i);

                if(invalid(candidate.Code))
                    continue;

                if(candidate.Width == width)
                    seek(dst,k++) = candidate;
            }
            return k;
        }

        [MethodImpl(Inline), Op]
        public static uint filter(RegClass @class, RegWidth width, ReadOnlySpan<Register> src, Span<Register> dst)
        {
            var k=0u;
            var j = root.min(src.Length, dst.Length);
            for(var i=0; i<j; i++)
            {
                ref readonly var candidate = ref skip(src,i);

                if(invalid(candidate.Code))
                    continue;

                if(candidate.Width == width && candidate.Class == @class)
                    seek(dst,k++) = candidate;
            }
            return k;
        }

        [MethodImpl(Inline), Op]
        public static bool valid(RegIndex src)
            => (uint)src <= 31;

        [MethodImpl(Inline), Op]
        public static bool invalid(RegIndex src)
            => (uint)src >= 32;

        [MethodImpl(Inline), Op]
        public static bool IsGp(Register r)
            => @class(r) == RegClass.GP;

        [MethodImpl(Inline), Op]
        public static bool IsGp(RegClass c)
            => c == RegClass.GP;

        [MethodImpl(Inline), Op]
        public static bool IsGp(Register r, RegWidth w)
            => w == r.Width && IsGp(r);

        [MethodImpl(Inline), Op]
        public static bool hi(Register r)
            => ((uint)r.Kind & RegFacets.Hi) != 0;

        [Op]
        public static Index<Register> list()
            => Enums.literals<RegKind>().Map(model);
    }
}