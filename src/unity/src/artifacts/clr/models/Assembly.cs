//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using R = System.Reflection;

    partial struct ClrArtifacts
    {
        public readonly struct Assembly : IClrArtifact<Assembly>
        {
            readonly R.Assembly Subject;

            [MethodImpl(Inline)]
            public Assembly(R.Assembly src)
                => Subject = src;

            [MethodImpl(Inline)]
            public static implicit operator Assembly(R.Assembly src)
                => new Assembly(src);

            [MethodImpl(Inline)]
            public static implicit operator R.Assembly(Assembly src)
                => src.Subject;

            public string Name
            {
                [MethodImpl(Inline)]
                get => Subject.FullName;
            }

            public ArtifactIdentifier Id
            {
                [MethodImpl(Inline)]
                get => Subject.GetHashCode();
            }

            public ClrArtifactKind Kind
            {
                [MethodImpl(Inline)]
                get => ClrArtifactKind.Assembly;
            }
        }
    }
}