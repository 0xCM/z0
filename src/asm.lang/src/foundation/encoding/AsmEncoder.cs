//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;
    using static memory;
    using static OperatingMode;
    using static OperandSize;
    using static AsmRefs;

    using RF = RexFieldIndex;

    [ApiHost]
    public readonly partial struct AsmEncoder
    {
        [MethodImpl(Inline), Op]
        public static Vsib vsib(byte src)
            => new Vsib(src);

        [MethodImpl(Inline), Op]
        public static AsmHexCode rex(uint4 wrxb, uint4 index)
        {
            var dst = AsmBytes.hexcode();
            dst.Cell(index) = rex(wrxb);
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode prefix(LockPrefixCode code, uint4 index)
        {
            var dst = AsmBytes.hexcode();
            dst.Cell(index) = (byte)code;
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode prefix(EscapeCode escape, uint4 index)
        {
            var dst = AsmBytes.hexcode();
            dst.Cell(index) = (byte)escape;
            return dst;
        }

        /// <summary>
        /// Effective address computation with vsib addressing
        /// </summary>
        /// <remarks>
        /// Each element i of the effective address array is computed using the formula:
        /// effective address[i] = scale * index[i] + base + displacement, where index[i]
        /// is the ith element of the XMM/YMM register specified by {X, VSIB.index}.
        /// An index element is either 32 or 64 bits wide and is treated as a signed integer
        /// </remarks>
        [MethodImpl(Inline), Op]
        public static MemoryAddress effective(Vsib vsib, Vector256<uint> src, uint dx)
            => vsib.Scale()*cpu.vcell(src, vsib.Index)+ (ulong)vsib.Base + (ulong)dx;

        [MethodImpl(Inline), Op]
        public static ModRm modrm(byte src)
            => new ModRm(src);

        [MethodImpl(Inline), Op]
        public static ModRm modrm(uint3 rm, uint3 reg, uint2 mod)
            => modrm(BitFields.join((rm,0), (reg,3), (mod,6)));

        [MethodImpl(Inline), Op]
        public static ModRm modrm(uint3 r1, uint3 r2)
            => modrm(r1,r2,uint2.Max);

        public static Hex8 rex()
            => (byte)RexPrefixCode.Rex40;

        [MethodImpl(Inline), Op]
        public static byte rex(bit b, bit x, bit r, bit w)
        {
            var bx = math.slor((byte)b, 0, (byte)x, 1);
            var rw = math.slor((byte)r, 2, (byte)w, 3);
            return math.or(bx, rw, rex());
        }

        [MethodImpl(Inline), Op]
        public static Hex8 rex(uint4 wrxb)
            => math.or((byte)RexPrefixCode.Rex40, (byte)wrxb);

        public static void render(ModRm src, ITextBuffer dst)
        {
            const char Open = Chars.LBracket;
            const char Close = Chars.RBracket;
            const char Sep = Chars.Pipe;

            dst.Append(Open);

            dst.Append("Mod");
            dst.Append(Open);
            dst.Append(src.Mod.Format());
            dst.Append(Close);
            dst.Append(Chars.Space);
            dst.Append(Sep);

            dst.Append(Chars.Space);
            dst.Append("Reg");
            dst.Append(Open);
            dst.Append(src.Reg.Format());
            dst.Append(Close);
            dst.Append(Chars.Space);
            dst.Append(Sep);

            dst.Append(Chars.Space);
            dst.Append("Rm");
            dst.Append(Open);
            dst.Append(src.Rm.Format());
            dst.Append(Close);

            dst.Append(Close);
        }

        internal const byte MinRexCode = 0x40;

        internal const byte MaxRexCode = 0x4F;

        [MethodImpl(Inline), Op]
        public static RexPrefix next(RexPrefix src)
        {
            if(src.Data < MaxRexCode)
                return new RexPrefix(++src.Data);
            else
                return new RexPrefix(MinRexCode);
        }

        [MethodImpl(Inline), Op]
        public static RexPrefix prior(RexPrefix src)
        {
            if(src.Data > MinRexCode)
                return new RexPrefix(--src.Data);
            else
                return new RexPrefix(MaxRexCode);
        }

        static ReadOnlySpan<byte> _RexPrefixBytes
            => new byte[16]{0x40,0x41,0x42,0x43,0x44,0x45,0x46,0x47,0x48,0x49,0x4A,0x4B,0x4C,0x4D,0x4E,0x4F};

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<RexPrefix> RexPrefixBits()
            => recover<RexPrefix>(_RexPrefixBytes);

        [Op]
        static string bits(RexPrefix src)
        {
            var bs = src.Data.FormatBits();
            var chars = text.span(bs);
            var lo = slice(chars,0,4);
            var hi = slice(chars,4,4);
            return text.format("[{0} {1}]", lo, hi);
        }

        [Op]
        public static string describe(RexPrefix src)
            => $"{src.Format()} | {bits(src)} | {RF.W}:{src.W} | {RF.R}:{src.R} | {RF.X}:{src.X} | {RF.B}:{src.B}";

        public static string describe(Vsib src)
        {
            var buffer = text.buffer();
            buffer.Append("[ ");
            buffer.Append(src.SS.ToString());
            buffer.Append(" | ");
            buffer.Append(src.Index.ToString());
            buffer.Append(" | ");
            buffer.Append(src.Base.ToString());
            buffer.Append(" ]");
            return buffer.Emit();
        }

        /// <summary>
        /// Determines whether a 66h prefix is required to indicate an operand-size override
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="default"></param>
        /// <param name="effective"></param>
        [Op, Doc(Amd + V3 + C1 + S2 + T2)]
        public static bit need66(OperatingMode mode, OperandSize @default, OperandSize effective)
            => mode switch{
                Mode64 => effective switch {
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
    }
}