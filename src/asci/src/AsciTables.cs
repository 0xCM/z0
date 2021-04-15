//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    using F = AsciCodeFacets;

    [ApiHost]
    public readonly struct AsciTables
    {
        [MethodImpl(Inline), Op]
        static AsciTable table(AsciTableKind kind, AsciCharCode min, AsciCharCode max)
            => new AsciTable(kind,min,max);

        [MethodImpl(Inline), Op]
        public static AsciTable digits()
            => table(AsciTableKind.Digits, F.MinDigitCode, F.MaxDigitCode);

        [MethodImpl(Inline), Op]
        public static AsciTable letters(LowerCased @case)
            => table(AsciTableKind.LowerLetters, F.MinLowerCode, F.MaxLowerCode);

        [MethodImpl(Inline), Op]
        public static AsciTable letters(UpperCased @case)
            => table(AsciTableKind.UpperLetters, F.MinUpperCode, F.MaxUpperCode);
    }
}