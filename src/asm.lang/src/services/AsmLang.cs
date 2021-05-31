//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;
    using static core;

    using api = AsmLang;

    [ApiHost]
    public partial class AsmLang : AppService<AsmLang>
    {
        const NumericKind Closure = UnsignedInts;


        // 3 bits
        internal enum ScaleFactor : byte
        {
            S0 = 1,

            S1 = 2,

            S3 = 3,

            S4 = 4
        }

        // 3 bits
        internal enum OpIndex : byte
        {
            S0 = 1,

            S1 = 2,

            S3 = 3,

            S4 = 4
        }


        [StructLayout(LayoutKind.Sequential, Size = 2)]
        internal readonly struct RegSpec
        {

        }

        [StructLayout(LayoutKind.Sequential, Size = 1)]
        internal readonly struct OpInfo
        {

        }

        [MethodImpl(Inline), Op]
        internal static RegSpec join(RegWidth width, RegClass @class, RegIndex index)
            => to(math.or(math.sll((ushort)width,3), math.sll((ushort)@class,5) , math.sll((ushort)index, 10)), out RegSpec _);

        [MethodImpl(Inline), Op]
        internal static OpInfo join(OpIndex index, ScaleFactor scale)
            => to(emath.or(index, emath.srl8(scale, 3)), out OpInfo _);

        [MethodImpl(Inline), Op, Closures(Closure)]
        internal static ref Cell<T> cell<T>(ref Statement src, byte offset)
            where T : unmanaged
                => ref first(recover<Cell<T>>(slice(src.Bytes,offset)));

        [MethodImpl(Inline), Op]
        internal static ref AsmMnemonicCode mnemonic(ref Statement src)
            => ref mnemonic(src.Bytes);


        [MethodImpl(Inline), Op]
        internal static ref AsmMnemonicCode mnemonic(Span<byte> src)
            => ref first(recover<AsmMnemonicCode>(src));

        public struct Statement
        {
            internal Cell256 Data;

            internal Span<byte> Bytes
            {
                [MethodImpl(Inline)]
                get => Data.Bytes;
            }

            public ref AsmMnemonicCode Mnemonic
            {
                [MethodImpl(Inline)]
                get => ref api.mnemonic(Bytes);
            }
        }
    }
}