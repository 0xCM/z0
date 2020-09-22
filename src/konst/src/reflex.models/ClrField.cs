//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.ClrData
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ClrField
    {
        public readonly FieldInfo Definition;

        public ClrArtifactKey Id
        {
            [MethodImpl(Inline)]
            get => Definition.MetadataToken;
        }

        [MethodImpl(Inline)]
        public static bool operator ==(ClrField lhs, ClrField rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(ClrField lhs, ClrField rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static implicit operator FieldInfo(ClrField src)
            => src.Definition;

        [MethodImpl(Inline)]
        public ClrField(FieldInfo data)
            => Definition = data;

        public string Format()
            => Definition.Name;

        public override bool Equals(object obj)
            => Definition.Equals(obj);

        public override int GetHashCode()
            => Definition.GetHashCode();

        public override string ToString()
            => Format();
    }
}