//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static ApiNameParts;

    public readonly struct PartResId
    {
        public const string OpCodeSpecs = nameof(OpCodeSpecs);

        const string intel = nameof(intel);

        const string intrinsics = nameof(intrinsics);

        public const string IntelIntinsicx = intel + dot + nameof(intrinsics);
    }
}