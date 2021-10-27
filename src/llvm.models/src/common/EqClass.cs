//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct EqClass : IEquatable<EqClass>
    {
        public uint ClassId {get;}

        public string ClassName {get;}

        [MethodImpl(Inline)]
        public EqClass(uint id, string name)
        {
            ClassId = id;
            ClassName = name;
        }

        public string Format()
            => ClassName;

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public bool Equals(EqClass src)
            => ClassName.Equals(src.ClassName);

        public override int GetHashCode()
            => ClassName.GetHashCode();

        public override bool Equals(object src)
            => src is EqClass c && Equals(c);

        [MethodImpl(Inline)]
        public static bool operator ==(EqClass a, EqClass b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(EqClass a, EqClass b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        public static implicit operator EqClass((uint id, string name) src)
            => new EqClass(src.id, src.name);
    }
}