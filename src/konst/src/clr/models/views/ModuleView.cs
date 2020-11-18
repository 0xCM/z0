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

    partial struct ClrViews
    {
        public readonly struct ModuleView : IClrArtifact<ModuleView>
        {
            readonly R.Module Subject;

            [MethodImpl(Inline)]
            public ModuleView(R.Module src)
                => Subject = src;

            public ClrArtifactKey Key
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
            public static implicit operator ModuleView(R.Module src)
                => new ModuleView(src);

            [MethodImpl(Inline)]
            public static implicit operator R.Module(ModuleView src)
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