//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static RegisterBitFields;
    using static z;

    using W = RegisterWidth;

    [ApiHost(ApiNames.AsmRegisters)]
    public readonly struct Registers
    {
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

        [MethodImpl(Inline), Op]
        public static RegisterKind join(RegisterIndex c, RegisterClass k, RegisterWidth w)
            => (RegisterKind)((uint)c  << CodeIndex | (uint)k << ClassIndex | (uint)w << WidthIndex);

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

        public static IndexedView<RegisterKind> SymbolKinds
            => Enums.literals<RegisterKind>();

        [MethodImpl(Inline), Op]
        public static IndexedView<RegisterKind> Gp8()
            => SymbolKinds.Where(r => width(r) == W.W8);

        [MethodImpl(Inline), Op]
        public static IndexedView<RegisterKind> Gp16()
            => SymbolKinds.Where(r => width(r) == W.W16);

        [MethodImpl(Inline), Op]
        public static IndexedView<RegisterKind> Gp32()
            => SymbolKinds.Where(r => width(r) == W.W32);

        [MethodImpl(Inline), Op]
        public static IndexedView<RegisterKind> Gp64()
            => SymbolKinds.Where(r => width(r) == W.W64);

        [MethodImpl(Inline), Op]
        public static IndexedView<RegisterKind> V128()
            => SymbolKinds.Where(r => width(r) == W.W128);

        [MethodImpl(Inline), Op]
        public static IndexedView<RegisterKind> V256()
            => SymbolKinds.Where(r => width(r) == W.W256);

        [MethodImpl(Inline), Op]
        public static IndexedView<RegisterKind> V512()
            => SymbolKinds.Where(r => width(r) == W.W512);

        [MethodImpl(Inline)]
        public static void split(RegisterKind src, out RegisterIndex c, out RegisterClass k, out RegisterWidth w)
        {
            c = code(src);
            k = @class(src);
            w = width(src);
        }

    }

    [ApiHost]
    public readonly partial struct XRegisters
    {

    }
}