//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    partial struct IntelSdm
    {
        [StructLayout(LayoutKind.Sequential, Pack =1)]
        public struct Page
        {
            public ushort Number;

            [MethodImpl(Inline)]
            public Page(ushort number)
            {
                Number = number;
            }

            public string Format()
                => Number.ToString();

            public override string ToString()
                => Format();

            [MethodImpl(Inline)]
            public static implicit operator Page(ushort src)
                => new Page(src);

            [MethodImpl(Inline)]
            public static implicit operator Page(int src)
                => new Page((ushort)src);
        }
    }
}