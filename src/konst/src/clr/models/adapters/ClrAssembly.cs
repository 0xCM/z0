//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ClrAssembly : IClrRuntimeObject<ClrAssembly,Assembly>
    {
        public Assembly Definition {get;}

        [MethodImpl(Inline)]
        public ClrAssembly(Assembly src)
            => Definition = src;

        [Ignore]
        public ClrArtifactKind Kind
            => ClrArtifactKind.Assembly;

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

        public ClrAssemblyName Name
            => Definition;

        public ClrArtifactKind ClrKind
            => ClrArtifactKind.Assembly;

        public ReadOnlySpan<ClrAssemblyName> ReferencedAssemblies
            => ClrQuery.references(Definition);

        public ClrToken Token
            => default;

        public Ref<byte> RawMetadata
        {
            [MethodImpl(Inline)]
            get => ClrQuery.metadata(Definition);
        }

        string IClrArtifact.Name
            => Definition.FullName;

        [MethodImpl(Inline)]
        public static implicit operator Assembly(ClrAssembly src)
            => src.Definition;

        [MethodImpl(Inline)]
        public static implicit operator ClrAssembly(Assembly src)
            => new ClrAssembly(src);
    }
}