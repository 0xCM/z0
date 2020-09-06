//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    public readonly struct ApiMethods
    {
        readonly MethodInfo[] Data;

        public static implicit operator ApiMethods(MethodInfo[] src)
            => new ApiMethods(src);

        [MethodImpl(Inline)]
        public ApiMethods(MethodInfo[] src)
            => Data = src;

        public ReadOnlySpan<MethodInfo> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public Span<MethodInfo> Edit
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public MethodInfo[] Storage
        {
            [MethodImpl(Inline)]
            get => Data;
        }
    }
}