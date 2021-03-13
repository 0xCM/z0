//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Reflection.Metadata;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Root;

    public readonly struct ClrAssembly : IClrRuntimeObject<ClrAssembly,Assembly>
    {
        public Assembly Definition {get;}

        [MethodImpl(Inline)]
        public ClrAssembly(Assembly src)
            => Definition = src;

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

        public Name SimpleName
        {
            [MethodImpl(Inline)]
            get => Definition.GetSimpleName();
        }

        public ClrAssemblyName Name
            => Definition;

        public ReadOnlySpan<ClrAssemblyName> ReferencedAssemblies
            => Clr.references(Definition);

        public ClrToken Id
            => (uint)Part;

        public ReadOnlySpan<byte> RawMetadata
        {
            [MethodImpl(Inline)]
            get => CliBridge.metaspan(Definition);
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