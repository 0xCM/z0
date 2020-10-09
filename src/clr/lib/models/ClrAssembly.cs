//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiDataType]
    public readonly struct ClrAssembly
    {
        [MethodImpl(Inline)]
        public static ClrAssembly from(Assembly src)
            => new ClrAssembly(src);

        public Assembly Definition {get;}

        public ClrArtifactKey Id
        {
            [MethodImpl(Inline)]
            get => ClrArtifactKey.from(Definition);
        }

        [MethodImpl(Inline)]
        public ClrAssembly(Assembly src)
            => Definition = src;

        public bool IsPart
        {
            [MethodImpl(Inline)]
            get => Definition.Id() != 0;
        }

        public string SimpleName
        {
            [MethodImpl(Inline)]
            get => Definition.GetSimpleName();
        }

        [MethodImpl(Inline)]
        public static implicit operator Assembly(ClrAssembly src)
            => src.Definition;

        [MethodImpl(Inline)]
        public static implicit operator ClrAssembly(Assembly src)
            => new ClrAssembly(src);
    }
}