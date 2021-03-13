//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static AsmRegBits;

    [ApiHost]
    public readonly partial struct AsmRegs
    {
        [MethodImpl(Inline), Op]
        public static Register model(RegisterKind kind)
            => kind;

        [MethodImpl(Inline), Op]
        public static Register model(RegIndex c, RegClass k, RegWidth w)
            => new Register(c, k, w);

        [MethodImpl(Inline), Op]
        public static Register model(@enum<RegisterKind,uint> src)
            => new Register(src.Literal);

        /// <summary>
        /// Determines the register code from the kind
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline), Op]
        public static RegIndex index(RegisterKind src)
            => (RegIndex)Bits.extract((uint)src, (byte)FieldIndex.C, (byte)FieldWidth.C);

        /// <summary>
        /// Determines the register class from the kind
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline), Op]
        public static RegClass @class(RegisterKind src)
            => (RegClass)Bits.extract((uint)src, (byte)FieldIndex.K, (byte)FieldWidth.K);

        /// <summary>
        /// Determines the register width from the kind
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline), Op]
        public static RegWidth width(RegisterKind src)
            => (RegWidth)Bits.extract((uint)src, (byte)FieldIndex.W, (byte)FieldWidth.W);

        /// <summary>
        /// Combines a <see cref='RegIndex'/>, a <see cref='RegClass'/> and a <see cref='RegWidth'/> to produce a <see cref='RegisterKind'/>
        /// </summary>
        /// <param name="i">The register index</param>
        /// <param name="k">The register class</param>
        /// <param name="w">The register width</param>
        [MethodImpl(Inline), Op]
        public static RegisterKind kind(RegIndex i, RegClass k, RegWidth w)
            => (RegisterKind)((uint)i  << IndexField | (uint)k << ClassField | (uint)w << WidthField);

        [MethodImpl(Inline)]
        public static void split(RegisterKind src, out RegIndex c, out RegClass k, out RegWidth w)
        {
            c = AsmRegs.index(src);
            k = AsmRegs.@class(src);
            w = AsmRegs.width(src);
        }

        [Op]
        public static string format(Register src)
        {
            const string Sep = " | ";
            var index = BitFields.format<RegIndex,byte>(src.Code, "Index", 5);
            var @class = BitFields.format<RegClass,byte>(src.Class, "Class", 4);
            var width = BitFields.format<RegWidth,ushort>(src.Width, base10, "Width");
            var dst = text.bracket(text.join(Sep, index, @class, width));
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static bool IsGp(Register r)
            => @class(r) == RegClass.GP;

        [MethodImpl(Inline), Op]
        public static bool IsGp(Register r, RegWidth w)
            => w == r.Width && IsGp(r);

        [Op]
        public static Index<Register> Gp8Filter(Index<Register> src)
            => src.Where(r => IsGp(r, RegWidth.W8));

        [Op]
        public static Index<Register> Gp16Filter(Index<Register> src)
            => src.Where(r => IsGp(r, RegWidth.W16));

        [Op]
        public static Index<Register> Gp32Filter(Index<Register> src)
            => src.Where(r => IsGp(r, RegWidth.W32));

        [Op]
        public static Index<Register> Gp64Filter(Index<Register> src)
            => src.Where(r => IsGp(r, RegWidth.W64));

        [Op]
        public static Index<Register> XmmFilter(Index<Register> src)
            => src.Where(r => @class(r) == RegClass.XMM);

        [Op]
        public static Index<Register> YmmFilter(Index<Register> src)
            => src.Where(r => @class(r) == RegClass.YMM);

        [Op]
        public static Index<Register> ZmmFilter(Index<Register> src)
            => src.Where(r => @class(r) == RegClass.ZMM);

        [Op]
        public static Index<Register> list()
            => Enums.literals<RegisterKind>().Map(model);
        [Op]
        public static AsmRegLookup lookup()
            => AsmRegLookup.create(list());
    }
}