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

    [ApiDataType(ApiNames.ClrAssembly, true)]
    public readonly struct ClrAssembly
    {
        public Assembly Definition {get;}

        public ClrArtifactKey Id
        {
            [MethodImpl(Inline)]
            get => ClrArtifactKey.from(Definition);
        }

        [MethodImpl(Inline)]
        public ClrAssembly(Assembly src)
            => Definition = src;

        public PartId Part
        {
            [MethodImpl(Inline)]
            get => Definition.Id();
        }

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