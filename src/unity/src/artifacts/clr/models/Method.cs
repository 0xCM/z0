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
        public readonly struct Method : IClrArtifact<Method>
        {
            readonly R.MethodInfo Subject;

            [MethodImpl(Inline)]
            public Method(R.MethodInfo src)
                => Subject = src;

            public ArtifactIdentifier Id
            {
                [MethodImpl(Inline)]
                get => Subject.MetadataToken;
            }

            public ClrArtifactKind Kind
            {
                [MethodImpl(Inline)]
                get => ClrArtifactKind.Method;
            }

            public string Name
            {
                [MethodImpl(Inline)]
                get => Subject.Name;
            }

            [MethodImpl(Inline)]
            public static implicit operator Method(R.MethodInfo src)
                => new Method(src);

            [MethodImpl(Inline)]
            public static implicit operator R.MethodInfo(Method src)
                => src.Subject;

            public Type DeclaringType
            {
                [MethodImpl(Inline)]
                get => Subject.DeclaringType;
            }

            public MemoryAddress Address
            {
                [MethodImpl(Inline)]
                get => Subject.MethodHandle.Value;
            }

            public R.CallingConventions CallingConvention
            {
                [MethodImpl(Inline)]
                get => Subject.CallingConvention;
            }

            public bool IsStatic
            {
                [MethodImpl(Inline)]
                get => Subject.IsStatic;
            }

            public bool IsVirtual
            {
                [MethodImpl(Inline)]
                get => Subject.IsVirtual;
            }

        }
    }
}