//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsmSigTokens;

    [ApiHost]
    public partial class AsmSigs : Service<AsmSigs>
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static AsmSigToken<K> token<K>(AsmSigTokenKind kind, K value)
            where K : unmanaged
                => new AsmSigToken<K>(kind,value);

        [MethodImpl(Inline), Op]
        public static Decorator operand(DecoratorToken src)
            => src;

        [MethodImpl(Inline), Op]
        public static FarPtr operand(FarPtrToken src)
            => src;

        [MethodImpl(Inline), Op]
        public static FpuMem operand(FpuMemToken src)
            => src;

        [MethodImpl(Inline), Op]
        public static FpuReg operand(FpuRegToken src)
            => src;

        [MethodImpl(Inline), Op]
        public static GpReg operand(GpRegToken src)
            => src;

        [MethodImpl(Inline), Op]
        public static GpRm operand(GpRmToken src)
            => src;

        [MethodImpl(Inline), Op]
        public static Imm operand(ImmToken src)
            => src;

        [MethodImpl(Inline), Op]
        public static MaskReg operand(MaskRegToken src)
            => src;

        [MethodImpl(Inline), Op]
        public static Mem operand(MemToken src)
            => src;

        [MethodImpl(Inline), Op]
        public static MemPair operand(MemPairToken src)
            => src;

        [MethodImpl(Inline), Op]
        public static MmxReg operand(MmxRegToken src)
            => src;

        [MethodImpl(Inline), Op]
        public static Moffs operand(MoffsToken src)
            => src;

        [MethodImpl(Inline), Op]
        public static Ptr operand(PtrToken src)
            => src;

        [MethodImpl(Inline), Op]
        public static Rel operand(RelToken src)
            => src;

        [MethodImpl(Inline), Op]
        public static SrcOp src(SrcOpToken src)
            => src;

        [MethodImpl(Inline), Op]
        public static VecReg src(VecRegToken src)
            => src;

        [MethodImpl(Inline), Op]
        public static VecRm src(VecRmToken src)
            => src;

        [MethodImpl(Inline), Op]
        public static ZmmBCast src(ZmmBCastToken src)
            => src;

        [MethodImpl(Inline), Op]
        public static SysReg src(SysRegToken src)
            => src;
    }
}