//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    public readonly struct AppPathConfig
    {
        readonly AppPathSetting[] Paths;

        [MethodImpl(Inline)]
        public AppPathConfig(AppPathSetting[] paths)
        {
            Paths = paths;
        }

        public ReadOnlySpan<AppPathSetting> View
        {
            [MethodImpl(Inline)]
            get => Paths;
        }

        public Span<AppPathSetting> Edit
        {
            [MethodImpl(Inline)]
            get => Paths;
        }
    }
}