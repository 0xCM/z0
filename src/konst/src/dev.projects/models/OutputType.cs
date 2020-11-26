//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct ProjectModel
    {
        public readonly struct OutputType : IProjectProperty<OutputType>
        {
            public readonly string Value;

            [MethodImpl(Inline)]
            public OutputType(string value)
                => Value = value;

            [MethodImpl(Inline)]
            public string Render()
                => string.Format(TagFormat, nameof(OutputType), Value);

            [MethodImpl(Inline)]
            public bool Equals(OutputType src)
                => text.equals(Value, src.Value);

            public uint Hash
            {
                [MethodImpl(Inline)]
                get => (uint)Value.GetHashCode();
            }

            [Ignore]
            string IProjectElement.Render()
                => Render();

            [Ignore]
            public override int GetHashCode()
                => (int)Hash;

            [Ignore]
            public override string ToString()
                => Render();

            [Ignore]
            public override bool Equals(object src)
                => src is OutputType x && Equals(x);

            [Ignore]
            string IProjectElement.Name
                => nameof(OutputType);

            [Ignore]
            string IProjectProperty.Value
                => Value;
        }
    }
}