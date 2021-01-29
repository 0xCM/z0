//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static ApiNameParts;

    public readonly struct ContentNames
    {
        public const string OpCodeSpecs = nameof(OpCodeSpecs);

        const string intel = nameof(intel);

        const string intrinsics = nameof(intrinsics);

        public static ContentName IntelIntinsics => intel + dot + nameof(intrinsics);

        public static ContentName StokeX86 => "stoke-x86.csv";
    }
}