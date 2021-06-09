//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using F = AsciCodeFacets;

    [ApiHost]
    public readonly struct AsciTables
    {
        [MethodImpl(Inline), Op]
        static AsciTable table(AsciTableKind kind, AsciCode min, AsciCode max)
            => new AsciTable(kind,min,max);

        [MethodImpl(Inline), Op]
        public static AsciTable segment(AsciCode min, AsciCode max)
            => new AsciTable(AsciTableKind.None, min,max);

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