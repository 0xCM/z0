//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static RegisterBits;
    using static z;

    using W = RegisterWidth;

    [ApiHost(ApiNames.AsmRegisters)]
    public readonly struct Registers
    {
        public static RegisterLookup lookup()
            => RegisterLookup.create();

        [MethodImpl(Inline), Op]
        public static Register define(RegisterKind kind)
            => kind;

        [MethodImpl(Inline), Op]
        public static Register define(RegisterIndex c, RegisterClass k, RegisterWidth w)
            => new Register(c, k, w);

        [MethodImpl(Inline), Op]
        public static Register define(@enum<RegisterKind,uint> src)
            => new Register(src.Literal);

        [Op]
        public static RegMachine512 machine(W512 w)
            => new RegMachine512(Registers.bank(w,32), Registers.bank(w64, 16));

        [Op]
        public static RegBank512 bank(W512 w, byte count)
            => new RegBank512(new Cell512[count]);

        [Op]
        public static RegBank256 bank(W256 w, byte count)
            => new RegBank256(new Cell256[count]);

        [Op]
        public static RegBank128 bank(W128 w, byte count)
            => new RegBank128(new Cell128[count]);

        [Op]
        public static RegBank64 bank(W64 w, byte count)
            => new RegBank64(new Cell64[count]);

        /// <summary>
        /// Determines the register code from the kind
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline), Op]
        public static RegisterIndex code(RegisterKind src)
            => (RegisterIndex)((byte)src >> CodeIndex);

        /// <summary>
        /// Determines the register class from the kind
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline), Op]
        public static RegisterClass @class(RegisterKind src)
            => (RegisterClass)((uint)src >> ClassIndex);

        /// <summary>
        /// Determines the register width from the kind
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline), Op]
        public static RegisterWidth width(RegisterKind src)
            => (RegisterWidth)((uint)src >> WidthIndex);

        /// <summary>
        /// Combines a <see cref='RegisterIndex'/>, a <see cref='RegisterClass'/> and a <see cref='RegisterWidth'/> to produce a <see cref='RegisterKind'/>
        /// </summary>
        /// <param name="i">The register index</param>
        /// <param name="k">The register class</param>
        /// <param name="w">The register width</param>
        [MethodImpl(Inline), Op]
        public static RegisterKind join(RegisterIndex i, RegisterClass k, RegisterWidth w)
            => (RegisterKind)((uint)i  << CodeIndex | (uint)k << ClassIndex | (uint)w << WidthIndex);

        /// <summary>
        /// Determines whether an upper register is selected
        /// </summary>
        /// <param name="src">The register kind to test</param>
        [MethodImpl(Inline), Op]
        public static bit hi(RegisterKind src)
            => ((uint)Pow2x32.P2ᐞ31 & (uint)src) != 0;

        [MethodImpl(Inline), Op]
        public static RegisterIndex code1(RegisterKind src)
            => (RegisterIndex)Bits.slice((uint)src, (byte)FI.C, (byte)FW.C);

        [MethodImpl(Inline), Op]
        public static RegisterClass @class1(RegisterKind src)
            => (RegisterClass)Bits.slice((uint)src, (byte)FI.K, (byte)FW.K);

        [MethodImpl(Inline), Op]
        public static RegisterKind code(RegisterIndex src, RegisterKind dst)
            => (RegisterKind)(Bits.copy((uint)src, (byte)FI.C, (byte)(FW.C), (uint)dst));

        [MethodImpl(Inline), Op]
        public static RegisterKind @class(RegisterClass src, RegisterKind dst)
            => (RegisterKind)(Bits.copy((uint)src, (byte)FI.K, (byte)(FW.K), (uint)dst));

        [MethodImpl(Inline), Op]
        public static RegisterKind width(RegisterWidth src, RegisterKind dst)
            => (RegisterKind)(Bits.copy((uint)src, (byte)FI.K, (byte)(FW.W), (uint)dst));

        [Op]
        public static Index<Register> All()
            => Enums.literals<RegisterKind>().Map(define);

        [Op]
        public static Index<Register> Gp8()
            => All().Where(r => width(r) == W.W8);

        [Op]
        public static Index<Register> Gp8(Index<Register> src)
            => src.Where(r => width(r) == W.W8);

        [Op]
        public static Index<Register> Gp16()
            => All().Where(r => width(r) == W.W16);

        [Op]
        public static Index<Register> Gp16(Index<Register> src)
            => src.Where(r => width(r) == W.W16);

        [Op]
        public static Index<Register> Gp32()
            => All().Where(r => width(r) == W.W32);

        [Op]
        public static Index<Register> Gp32(Index<Register> src)
            => src.Where(r => width(r) == W.W32);

        [Op]
        public static Index<Register> Gp64()
            => All().Where(r => width(r) == W.W64);

        [Op]
        public static Index<Register> Gp64(Index<Register> src)
            => src.Where(r => width(r) == W.W64);

        [Op]
        public static Index<Register> Xmm()
            => All().Where(r => width(r) == W.W128);

        [Op]
        public static Index<Register> Xmm(Index<Register> src)
            => src.Where(r => width(r) == W.W128);

        [Op]
        public static Index<Register> Ymm()
            => All().Where(r => width(r) == W.W256);

        [Op]
        public static Index<Register> Ymm(Index<Register> src)
            => src.Where(r => width(r) == W.W256);

        [Op]
        public static Index<Register> Zmm()
            => All().Where(r => width(r) == W.W512);

        public static Index<Register> Zmm(Index<Register> src)
            => src.Where(r => width(r) == W.W512);

        [MethodImpl(Inline)]
        public static void split(RegisterKind src, out RegisterIndex c, out RegisterClass k, out RegisterWidth w)
        {
            c = code(src);
            k = @class(src);
            w = width(src);
        }

        [Op]
        public static string format(Register src)
        {
            const string Sep = " | ";
            var seg0 = BitFields.format<RegisterIndex,byte>(src.Code);
            var seg1 = BitFields.format<RegisterClass,byte>(src.Class);
            var seg2 = BitFields.format<RegisterWidth,ushort>(src.Width);
            var dst = text.bracket(text.concat(seg2, Sep, seg1, Sep, seg0));
            return dst;
        }
    }

    [ApiHost]
    public readonly partial struct AsmRegs
    {

    }
}