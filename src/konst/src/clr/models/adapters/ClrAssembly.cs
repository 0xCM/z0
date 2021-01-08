//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Part;

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

        public FS.FilePath FilePath
        {
            [MethodImpl(Inline)]
            get => FS.path(Definition.CodeBase);
        }

        ref readonly FS.FilePath GetDocPath(out FS.FilePath dst)
        {
            var candidate = FS.path(Path.ChangeExtension(Definition.CodeBase, FileExtensions.Xml.Name));
            dst = candidate.Exists ? candidate : FS.FilePath.Empty;
            return ref dst;
        }

        ref readonly FS.FilePath GetPdbPath(out FS.FilePath dst)
        {
            var candidate = FS.path(Path.ChangeExtension(Definition.CodeBase, FileExtensions.Pdb.Name));
            dst = candidate.Exists ? candidate : FS.FilePath.Empty;
            return ref dst;
        }

        /// <summary>
        /// If found, returns a path to the associated documentation comment file; otherwise returns empty
        /// </summary>
        public FS.FilePath DocPath
            => GetDocPath(out var _);

        /// <summary>
        /// If found, returns a path to the associated pdb file; otherwise returns empty
        /// </summary>
        public FS.FilePath PdbPath
            => GetPdbPath(out var _);

        public ReadOnlySpan<ClrAssemblyName> ReferencedAssemblies
            => Clr.references(Definition);

        public ClrToken Token
            => default;

        public SegRef<byte> RawMetadata
        {
            [MethodImpl(Inline)]
            get => Clr.metadata(Definition);
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