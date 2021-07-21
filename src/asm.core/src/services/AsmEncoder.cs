//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static System.Runtime.Intrinsics.X86.Sse3;
    using static Root;
    using static core;
    using static AsmCodes;
    using static AsmOpCodes;
    using static MachineModeKind;
    using static OperandSize;

    using K = AsmCodes.RexPrefixCode;

    [ApiHost]
    public readonly struct AsmEncoder
    {
        [MethodImpl(Inline), Op]
        public static AsmHexCode jo(Hex8 cb)
        {
            const byte OpCode = 0x70;
            var dst = new AsmHexCode(OpCode);
            dst[1] = cb;
            dst[15] = 2;
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode jo(Hex32 cb)
        {
            const ushort OpCode = 0x7080;
            var dst = new AsmHexCode(OpCode);
            ref var x = ref seek(dst.Bytes,1);
            ref var y = ref @as<byte,Hex32>(x);
            y = cb;
            dst[15] = 6;
            return dst;
        }

        // RexBBits:[Index[00000] | Token[000]]
        [MethodImpl(Inline), Op]
        public static RexB rexb(RexBToken token, RegIndexCode r)
            => new RexB(token,r);

        [MethodImpl(Inline), Op]
        public static ModRmByte modrm(byte src)
            => new ModRmByte(src);

        [MethodImpl(Inline), Op]
        public static MandatoryPrefix mandatory(MandatoryPrefixCode code)
            => new MandatoryPrefix(code);

        [MethodImpl(Inline), Op]
        public static Vsib vsib(byte src)
            => new Vsib(src);

        [MethodImpl(Inline), Op]
        public static RexPrefix rex()
            => (byte)RexPrefixCode.Base;

        [MethodImpl(Inline), Op]
        public static BndPrefix bnd()
            => BndPrefixCode.BND;

        [MethodImpl(Inline), Op]
        public static AsmPrefix prefix()
            => new AsmPrefix(0);

        [MethodImpl(Inline), Op]
        public static ref AsmPrefix modrm(uint3 rm, uint3 reg, uint2 mod, ref AsmPrefix dst)
        {
            dst.Content(modrm(rm,reg,mod));
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ModRmByte modrm(uint3 r1, uint3 r2)
            => modrm(r1, r2, uint2.Max);

        [MethodImpl(Inline), Op]
        public static RexPrefix rex(uint4 wrxb)
            => math.or((byte)RexPrefixCode.Base, (byte)wrxb);

        [MethodImpl(Inline), Op]
        public static ModRmByte modrm(uint3 rm, uint3 reg, uint2 mod)
            => new ModRmByte(Bits.join((rm, 0), (reg, 3), (mod, 6)));

        [MethodImpl(Inline), Op]
        public static ref AsmHexCode rex(uint4 wrxb, uint4 index, ref AsmHexCode dst)
        {
            dst.Cell(index) = rex(wrxb);
            dst.Cell(15) = 1;
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static BranchHint hint(bit bt)
            => bt ? BranchHintCode.BT : BranchHintCode.BNT;

        [MethodImpl(Inline), Op]
        public static RexPrefix rex(bit w, bit r, bit x, bit b)
        {
            var bx = math.slor((byte)b, 0, (byte)x, 1);
            var rw = math.slor((byte)r, 2, (byte)w, 3);
            return math.or(bx, rw, rex());
        }

        [MethodImpl(Inline), Op]
        public static SizeOverrides sizes(bit opsz, bit adsz)
            => new SizeOverrides(opsz,adsz);

        [MethodImpl(Inline), Op]
        public static bit test(K src, K match)
            => (src & match) == match;


        [MethodImpl(Inline), Op]
        public static ref AsmHexCode encode(RexPrefix a0, ref AsmHexCode dst)
        {
            var writer = write(dst.Bytes);
            writer.Write8(a0);
            dst = close(writer, dst.Bytes);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode encode(RexPrefix a0, Hex8 a1, Imm64 a2)
        {
            var writer = write(buffer());
            writer.Write8(a0);
            writer.Write8(a1);
            writer.Write64(a2);
            return load(writer);
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode encode(Hex8 a0, Imm8 a1)
        {
            var writer = write(buffer());
            writer.Write8(a0);
            writer.Write8(a1);
            return load(writer);
        }

        /// <summary>
        /// Determines whether a 66h prefix is required to indicate an operand-size override
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="default"></param>
        /// <param name="effective"></param>
        [Op]
        public static bit need66(MachineModeKind mode, OperandSize @default, OperandSize effective)
            => mode switch{
                IA32e => effective switch {
                    W16 => 1,
                    W32 => 0,
                    W64 => 0,
                    _ => 0,
                },

                Compatibilty => effective switch {
                    W16 => @default switch{
                        W16 => 1,
                        W32 => 0,
                        _ => 0,
                    },

                    W32 => @default switch{
                        W16 => 0,
                        W32 => 1,
                        _ => 0,
                    },

                    _ => 0
                },

                Protected => effective switch {
                    W16 => @default switch {
                        W16 => 1,
                        W32 => 0,
                        _ => 0,
                    },
                    W32 => @default switch {
                        W16 => 0,
                        W32 => 1,
                        _ => 0,
                    },
                    _ => 0
                },

                Virtual8086 => effective switch {
                    W16 => @default switch {
                        W16 => 1,
                        W32 => 0,
                        _ => 0,
                    },
                    W32 => @default switch {
                        W16 => 0,
                        W32 => 1,
                        _ => 0,
                    },
                    _ => 0
                },

                Real => effective switch {
                    W16 => @default switch {
                        W16 => 1,
                        W32 => 0,
                        _ => 0,
                    },
                    W32 => @default switch {
                        W16 => 0,
                        W32 => 1,
                        _ => 0,
                    },
                    _ => 0
                },
              _ => 0
            };

        [MethodImpl(Inline), Op]
        static Span<byte> buffer()
            => ByteBlocks.alloc(n16).Bytes;

        [MethodImpl(Inline)]
        static SpanWriter write(Span<byte> dst)
            => Spans.writer(dst);

        [MethodImpl(Inline), Op]
        static AsmHexCode close(in SpanWriter writer, Span<byte> dst)
        {
            seek(dst, AsmHexCode.SizeIndex) = (byte)writer.BytesWritten;
            return new AsmHexCode(first(recover<Cell128>(dst)));
        }

        [MethodImpl(Inline)]
        static unsafe Vector128<byte> vload(Span<byte> src)
            => LoadDquVector128(gptr(first(src)));

        [MethodImpl(Inline), Op]
        static AsmHexCode load(SpanWriter writer)
        {
            seek(writer.Target, AsmHexCode.SizeIndex) = (byte)writer.BytesWritten;
            return new AsmHexCode(vload(writer.Target));
        }
    }
}