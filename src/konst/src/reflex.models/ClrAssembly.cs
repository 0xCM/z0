//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using SR = System.Reflection;

    using static Konst;

    partial struct Reflected
    {
        public readonly struct Assembly
        {
            public SR.Assembly Definition {get;}

            public ApiArtifactKey Id
            {
                [MethodImpl(Inline)]
                get => new ApiArtifactKey(Definition);
            }

            [MethodImpl(Inline)]
            public Assembly(SR.Assembly src)
                => Definition = src;

            [MethodImpl(Inline)]
            public static implicit operator SR.Assembly(Assembly src)
                => src.Definition;
        }
    }
}