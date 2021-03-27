//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;
    using static AsmRegBits;

    [ApiHost]
    public readonly partial struct AsmRegs
    {
        public static RegLayout layout(RegIndex index)
        {
            return default;
        }

        [Op]
        public static Index<RegClass> classes()
            => ClrEnums.literals<RegClass>();

        [Op]
        public static Index<RegWidth> widths()
            => ClrEnums.literals<RegWidth>();

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
            => (RegIndex)Bits.extract((uint)src, (byte)FieldIndex.C, (byte)FieldWidth.C);

        /// <summary>
        /// Determines the register class from the kind
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline), Op]
        public static RegClass @class(RegKind src)
            => (RegClass)Bits.extract((uint)src, (byte)FieldIndex.K, (byte)FieldWidth.K);

        /// <summary>
        /// Determines the register width from the kind
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline), Op]
        public static RegWidth width(RegKind src)
            => (RegWidth)Bits.extract((uint)src, (byte)FieldIndex.W, (byte)FieldWidth.W);

        /// <summary>
        /// Combines a <see cref='RegIndex'/>, a <see cref='RegClass'/> and a <see cref='RegWidth'/> to produce a <see cref='RegKind'/>
        /// </summary>
        /// <param name="i">The register index</param>
        /// <param name="k">The register class</param>
        /// <param name="w">The register width</param>
        [MethodImpl(Inline), Op]
        public static RegKind kind(RegIndex i, RegClass k, RegWidth w)
            => (RegKind)((uint)i  << IndexField | (uint)k << ClassField | (uint)w << WidthField);

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
            var width = BitFields.format<RegWidth,ushort>(src.Width, base10, "Width");
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
            => ((uint)r.Kind & AsmRegBits.Hi) != 0;

        [Op]
        public static Index<Register> list()
            => Enums.literals<RegKind>().Map(model);
    }
}