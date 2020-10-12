//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Refs
{

    using static ApiNameAtoms;

    [LiteralProvider]
    public readonly struct Intel
    {
        const string intel = nameof(intel);

        public const string intrinsics = intel + dot + nameof(intrinsics);
    }
}