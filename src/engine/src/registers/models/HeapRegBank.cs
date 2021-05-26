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

    public interface IRegBank<T>
        where T : unmanaged
    {
        ref T this[RegIndex r] {get;}

        RegWidth RegWidth
            => (RegWidth)(ushort)width<T>();
    }

    public readonly struct HeapRegBanks
    {
        public abstract class RegBank<T>
            where T : unmanaged
        {
        }

        public class ZmmRegBank : RegBank<Cell512>, IRegBank<Cell512>
        {
            readonly Index<Cell512> Data;

            public ZmmRegBank()
            {
                Data = core.alloc<Cell512>(32);
            }

            public ZmmRegBank(uint count)
            {
                Data = core.alloc<Cell512>(count);
            }

            [MethodImpl(Inline)]
            public ZmmRegBank(Index<Cell512> src)
            {
                Data = src;
            }

            public RegWidth RegWidth
            {
                [MethodImpl(Inline)]
                get => RegWidth.W512;
            }

            public ref Cell512 this[RegIndex r]
            {
                [MethodImpl(Inline)]
                get => ref Data[(byte)r];
            }

            public ref Cell512 this[W512 w, RegIndex r]
            {
                [MethodImpl(Inline)]
                get => ref this[r];
            }

            public ref Cell256 this[W256 w, RegIndex r]
            {
                [MethodImpl(Inline)]
                get => ref @as<Cell512,Cell256>(this[r]);
            }

            public ref Cell128 this[W128 w, RegIndex r]
            {
                [MethodImpl(Inline)]
                get => ref @as<Cell512,Cell128>(this[r]);
            }
        }

        public class YmmRegBank : RegBank<Cell256>, IRegBank<Cell256>
        {
            readonly Index<Cell256> Data;

            public YmmRegBank()
            {
                Data = core.alloc<Cell256>(32);
            }

            public YmmRegBank(uint count)
            {
                Data = core.alloc<Cell256>(count);
            }

            [MethodImpl(Inline)]
            public YmmRegBank(Index<Cell256> src)
            {
                Data = src;
            }

            public RegWidth RegWidth
            {
                [MethodImpl(Inline)]
                get => RegWidth.W256;
            }

            public ref Cell256 this[RegIndex r]
            {
                [MethodImpl(Inline)]
                get => ref Data[(byte)r];
            }

            public ref Cell256 this[W256 w, RegIndex r]
            {
                [MethodImpl(Inline)]
                get => ref this[r];
            }

            public ref Cell128 this[W128 w, RegIndex r]
            {
                [MethodImpl(Inline)]
                get => ref @as<Cell256,Cell128>(this[r]);
            }
        }

        public class XmmRegBank : RegBank<Cell128>, IRegBank<Cell128>
        {
            readonly Index<Cell128> Data;

            public XmmRegBank()
            {
                Data = core.alloc<Cell128>(32);
            }

            public XmmRegBank(uint count)
            {
                Data = core.alloc<Cell128>(count);
            }

            [MethodImpl(Inline)]
            public XmmRegBank(Index<Cell128> src)
            {
                Data = src;
            }

            public RegWidth RegWidth
            {
                [MethodImpl(Inline)]
                get => RegWidth.W128;
            }

            public ref Cell128 this[RegIndex r]
            {
                [MethodImpl(Inline)]
                get => ref Data[(byte)r];
            }

            public ref Cell128 this[W128 w, RegIndex r]
            {
                [MethodImpl(Inline)]
                get => ref this[r];
            }
        }

        public sealed class GpRegBank : RegBank<Cell64>, IRegBank<Cell64>
        {
            readonly Index<Cell64> Data;

            public GpRegBank()
            {
                Data = core.alloc<Cell64>(16);
            }

            public GpRegBank(uint count)
            {
                Data = core.alloc<Cell64>(count);
            }

            [MethodImpl(Inline)]
            public GpRegBank(Index<Cell64> src)
            {
                Data = src;
            }

            public ref Cell64 this[RegIndex r]
            {
                [MethodImpl(Inline)]
                get => ref Data[(byte)r];
            }

            public ref Cell64 this[W64 w, RegIndex r]
            {
                [MethodImpl(Inline)]
                get => ref Data[(byte)r];
            }

            public ref Cell32 this[W32 w, RegIndex r]
            {
                [MethodImpl(Inline)]
                get => ref @as<Cell64,Cell32>(Data[(byte)r]);
            }

            public ref Cell16 this[W16 w, RegIndex r]
            {
                [MethodImpl(Inline)]
                get => ref @as<Cell64,Cell16>(Data[(byte)r]);
            }

            public ref Cell8 this[W8 w, RegIndex r]
            {
                [MethodImpl(Inline)]
                get => ref @as<Cell64,Cell8>(Data[(byte)r]);
            }
        }
    }

    /*
        | Index | Code  | [63:0] | [31:0] | [15:0] | [7:0] |
        | 0     | 00000 | rax    | eax    | ax     | al    |
        | 1     | 00001 | rcx    | ecx    | cx     | cl    |
        | 2     | 00010 | rdx    | edx    | dx     | dl    |
        | 3     | 00011 | rbx    | ebx    | bx     | bl    |
        | 4     | 00100 | rsp    | esp    | sp     | spl   |
        | 5     | 00101 | rbp    | ebp    | bp     | bpl   |
        | 6     | 00110 | rsi    | esi    | si     | sil   |
        | 7     | 00111 | rdi    | edi    | di     | dil   |
        | 8     | 01000 | r8     | r8d    | r8w    | r8b   |
        | 9     | 01001 | r9     | r9d    | r9w    | r9b   |
        | 10    | 01010 | r10    | r10d   | r10w   | r10b  |
        | 11    | 01011 | r11    | r11d   | r11w   | r11b  |
        | 12    | 01100 | r12    | r12d   | r12w   | r12b  |
        | 13    | 01101 | r13    | r13d   | r13w   | r13b  |
        | 14    | 01110 | r14    | r14d   | r14w   | r14b  |
        | 15    | 01111 | r15    | r15d   | r15w   | r15b  |

        | Index | Code   | [511:0] | [255:0] | [127:0] |
        | 0     | 000000 | zmm0    | ymm0    | xmm0    |
        | 1     | 000001 | zmm1    | ymm1    | xmm1    |
        | 2     | 000010 | zmm2    | ymm2    | xmm2    |
        | 3     | 000011 | zmm3    | ymm3    | xmm3    |
        | 4     | 000100 | zmm4    | ymm4    | xmm4    |
        | 5     | 000101 | zmm5    | ymm5    | xmm5    |
        | 6     | 000110 | zmm6    | ymm6    | xmm6    |
        | 7     | 000111 | zmm7    | ymm7    | xmm7    |
        | 8     | 001000 | zmm8    | ymm8    | xmm8    |
        | 9     | 001001 | zmm9    | ymm9    | xmm9    |
        | 10    | 001010 | zmm10   | ymm10   | xmm10   |
        | 11    | 001011 | zmm11   | ymm11   | xmm11   |
        | 12    | 001100 | zmm12   | ymm12   | xmm12   |
        | 13    | 001101 | zmm13   | ymm13   | xmm13   |
        | 14    | 001110 | zmm14   | ymm14   | xmm14   |
        | 15    | 001111 | zmm15   | ymm15   | xmm15   |
    */
}