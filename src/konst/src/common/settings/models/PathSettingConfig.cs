//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct PathSettingConfig
    {
        readonly PathSetting[] Paths;

        [MethodImpl(Inline)]
        public PathSettingConfig(PathSetting[] paths)
        {
            Paths = paths;
        }

        public ReadOnlySpan<PathSetting> View
        {
            [MethodImpl(Inline)]
            get => Paths;
        }

        public Span<PathSetting> Edit
        {
            [MethodImpl(Inline)]
            get => Paths;
        }
    }
}