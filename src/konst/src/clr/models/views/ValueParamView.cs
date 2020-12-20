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
        public readonly struct ValueParamView : IClrArtifact<ValueParamView>
        {
            readonly R.ParameterInfo Subject;

            [MethodImpl(Inline)]
            public ValueParamView(R.ParameterInfo src)
                => Subject = src;

            public CliKey Key
            {
                [MethodImpl(Inline)]
                get => Subject.MetadataToken;
            }

            public ClrArtifactKind Kind
            {
                [MethodImpl(Inline)]
                get => ClrArtifactKind.ValueParam;
            }

            public string Name
            {
                [MethodImpl(Inline)]
                get => Subject.Name;
            }

            [MethodImpl(Inline)]
            public static implicit operator ValueParamView(R.ParameterInfo src)
                => new ValueParamView(src);

            [MethodImpl(Inline)]
            public static implicit operator R.ParameterInfo(ValueParamView src)
                => src.Subject;
        }
    }
}