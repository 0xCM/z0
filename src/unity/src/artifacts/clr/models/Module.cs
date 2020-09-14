//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using R = System.Reflection;

    using static Konst;

    partial struct ClrArtifacts
    {
        public readonly struct Module : IClrArtifact<Module>
        {
            readonly R.Module Subject;

            [MethodImpl(Inline)]
            public Module(R.Module src)
                => Subject = src;

            public ArtifactIdentifier Id
            {
                [MethodImpl(Inline)]
                get => Subject.MetadataToken;
            }

            public ClrArtifactKind Kind
            {
                [MethodImpl(Inline)]
                get => ClrArtifactKind.Module;
            }

            public string Name
            {
                [MethodImpl(Inline)]
                get => Subject.Name;
            }

            [MethodImpl(Inline)]
            public static implicit operator Module(R.Module src)
                => new Module(src);

            [MethodImpl(Inline)]
            public static implicit operator R.Module(Module src)
                => src.Subject;

            public string FullName
            {
                [MethodImpl(Inline)]
                get => Subject.FullyQualifiedName;
            }

            public string ScopeName
            {
                [MethodImpl(Inline)]
                get => Subject.ScopeName;
            }
        }
    }
}