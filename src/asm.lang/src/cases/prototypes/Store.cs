//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;
    partial struct Prototypes
    {
        [ApiHost(prototypes + store)]
        public readonly struct Store
        {

            [Op]
            public void deposit(Span<ulong> dst, ulong a0, ulong a1, ulong a2)
            {
                seek(dst,0) = a0;
                seek(dst,1) = a1;
                seek(dst,2) = a2;
            }

            [Op]
            public void deposit(Span<ulong> dst, ulong a0, ulong a1, ulong a2, ulong a3, ulong a4)
            {
                seek(dst,0) = a0;
                seek(dst,1) = a1;
                seek(dst,2) = a2;
                seek(dst,3) = a3;
                seek(dst,4) = a4;
            }

            [Op]
            public void deposit(Span<sbyte> dst, sbyte a0, sbyte a1, sbyte a2, sbyte a3, sbyte a4)
            {
                seek(dst,0) = a0;
                seek(dst,1) = a1;
                seek(dst,2) = a2;
                seek(dst,3) = a3;
                seek(dst,4) = a4;
            }

        }
    }
}