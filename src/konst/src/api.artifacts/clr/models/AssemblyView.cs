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
        public readonly struct AssemblyView : IClrArtifact<AssemblyView>
        {
            readonly R.Assembly Subject;

            [MethodImpl(Inline)]
            public AssemblyView(R.Assembly src)
                => Subject = src;

            [MethodImpl(Inline)]
            public static implicit operator AssemblyView(R.Assembly src)
                => new AssemblyView(src);

            [MethodImpl(Inline)]
            public static implicit operator R.Assembly(AssemblyView src)
                => src.Subject;

            public string Name
            {
                [MethodImpl(Inline)]
                get => Subject.FullName;
            }

            public ApiArtifactKey Id
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