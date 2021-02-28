//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    public readonly struct AsmDocs
    {
        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

        [MethodImpl(Inline), Op]
        public static AsmDocLine line(uint number, TextBlock content)
            => new AsmDocLine(number,content);
    }
}