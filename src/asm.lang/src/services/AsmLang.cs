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

    [ApiHost]
    public partial class AsmLang : AppService<AsmLang>
    {
        const NumericKind Closure = UnsignedInts;

        [StructLayout(LayoutKind.Sequential, Size = 2)]
        internal readonly struct RegSpec
        {

        }

        [MethodImpl(Inline), Op]
        internal static RegSpec join(RegWidth width, RegClass @class, RegIndex index)
            => to(math.or(math.srl((ushort)width,3), math.sll((ushort)@class,5) , math.sll((ushort)index, 10)), out RegSpec _);


        [MethodImpl(Inline), Op, Closures(Closure)]
        internal static ref Cell<T> cell<T>(ref Statement src, byte offset)
            where T : unmanaged
                => ref first(recover<Cell<T>>(slice(src.Bytes,offset)));

        [MethodImpl(Inline), Op]
        internal static ref AsmMnemonicCode mnemonic(ref Statement src)
            => ref first(recover<AsmMnemonicCode>(src.Bytes));

        public struct Statement
        {
            internal Cell256 Data;

            internal Span<byte> Bytes
            {
                [MethodImpl(Inline)]
                get => Data.Bytes;
            }
        }

    }
}