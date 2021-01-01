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

    public readonly struct ClrParameter : IClrArtifact<ClrParameter>
    {
        readonly R.ParameterInfo Subject;

        [MethodImpl(Inline)]
        public ClrParameter(R.ParameterInfo src)
            => Subject = src;

        public ClrToken Token
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
        public static implicit operator ClrParameter(R.ParameterInfo src)
            => new ClrParameter(src);

        [MethodImpl(Inline)]
        public static implicit operator R.ParameterInfo(ClrParameter src)
            => src.Subject;
    }

}