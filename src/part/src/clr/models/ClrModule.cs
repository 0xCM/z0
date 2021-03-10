//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using R = System.Reflection;

    using static Part;
    using static memory;

    public readonly struct ClrModule : IClrArtifact<ClrModule>
    {
        readonly R.Module Subject;

        [MethodImpl(Inline)]
        public ClrModule(R.Module src)
            => Subject = src;

        public ClrToken Id
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

        [MethodImpl(Inline)]
        public static implicit operator ClrModule(R.Module src)
            => new ClrModule(src);

        [MethodImpl(Inline)]
        public static implicit operator R.Module(ClrModule src)
            => src.Subject;
    }
}