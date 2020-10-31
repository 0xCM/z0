//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    [ApiDataType(ApiNames.ClrEnumLiteral, true)]
    public readonly struct ClrEnumLiteral
    {
        public FieldInfo Definition {get;}

        [MethodImpl(Inline)]
        public ClrEnumLiteral(FieldInfo src)
            => Definition = src;

        [MethodImpl(Inline)]
        public string Format()
            => Definition.Name;

        [MethodImpl(Inline)]
        public bool Equals(ClrEnumLiteral src)
            => Definition.Equals(src.Definition);

        [MethodImpl(Inline)]
        public static bool operator ==(ClrEnumLiteral lhs, ClrEnumLiteral rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(ClrEnumLiteral lhs, ClrEnumLiteral rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static implicit operator FieldInfo(ClrEnumLiteral src)
            => src.Definition;

        [MethodImpl(Inline)]
        public static implicit operator ClrEnumLiteral(FieldInfo src)
            => new ClrEnumLiteral(src);

        public override bool Equals(object obj)
            => Definition.Equals(obj);

        public override int GetHashCode()
            => Definition.GetHashCode();

        public override string ToString()
            => Format();
    }
}