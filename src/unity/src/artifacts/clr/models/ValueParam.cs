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
        public readonly struct ValueParam : IClrArtifact<ValueParam>
        {
            readonly R.ParameterInfo Subject;

            [MethodImpl(Inline)]
            public ValueParam(R.ParameterInfo src)
                => Subject = src;

            public ArtifactIdentifier Id
            {
                [MethodImpl(Inline)]
                get => Subject.MetadataToken;
            }

            public ClrArtifactKind Kind
            {
                [MethodImpl(Inline)]
                get => ClrArtifactKind.Param;
            }

            public string Name
            {
                [MethodImpl(Inline)]
                get => Subject.Name;
            }

            [MethodImpl(Inline)]
            public static implicit operator ValueParam(R.ParameterInfo src)
                => new ValueParam(src);

            [MethodImpl(Inline)]
            public static implicit operator R.ParameterInfo(ValueParam src)
                => src.Subject;
        }
    }
}