//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ApiResAccessors
    {
        public Type DeclaringType {get;}

        readonly Index<ApiResAccessor> Accessors;

        [MethodImpl(Inline)]
        public ApiResAccessors(Type declaring, ApiResAccessor[] accessors)
        {
            DeclaringType = declaring;
            Accessors = accessors;
        }

        public ReadOnlySpan<ApiResAccessor> View
        {
            [MethodImpl(Inline)]
            get => Accessors;
        }
    }
}