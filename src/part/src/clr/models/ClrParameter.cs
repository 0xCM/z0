//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using R = System.Reflection;

    using static Root;

    public readonly struct ClrParameter : IClrRuntimeObject<ClrParameter,R.ParameterInfo>
    {
        public R.ParameterInfo Definition {get;}

        [MethodImpl(Inline)]
        public ClrParameter(R.ParameterInfo src)
            => Definition = src;

        public CliToken Token
        {
            [MethodImpl(Inline)]
            get => Definition.MetadataToken;
        }

        public ClrArtifactKind Kind
        {
            [MethodImpl(Inline)]
            get => ClrArtifactKind.ValueParam;
        }

        public ClrTypeAdapter DataType
        {
            get => Definition.ParameterType;
        }

        public string Name
        {
            [MethodImpl(Inline)]
            get => Definition.Name;
        }

        public int Position
        {
            [MethodImpl(Inline)]
            get => Definition.Position;
        }

        public string Format()
            => string.Format("{0}:{1}", Name, DataType.Name);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator ClrParameter(R.ParameterInfo src)
            => new ClrParameter(src);

        [MethodImpl(Inline)]
        public static implicit operator R.ParameterInfo(ClrParameter src)
            => src.Definition;
    }
}