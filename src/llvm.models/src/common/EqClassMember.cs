//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct EqClassMember: IEquatable<EqClassMember>
    {
        public EqClass Class {get;}

        public uint MemberId {get;}

        public string MemberName {get;}

        [MethodImpl(Inline)]
        public EqClassMember(EqClass @class, uint id, string name)
        {
            Class = @class;
            MemberId = id;
            MemberName = name;
        }

        public string Format()
            => string.Format("{0} -> {1}", MemberName, Class.ClassName);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public bool Equals(EqClassMember src)
            => Class.Equals(src.Class) && MemberName == src.MemberName;

        public override int GetHashCode()
            => MemberName.GetHashCode();

        public override bool Equals(object src)
            => src is EqClass c && Equals(c);

        [MethodImpl(Inline)]
        public static bool operator ==(EqClassMember a, EqClassMember b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(EqClassMember a, EqClassMember b)
            => !a.Equals(b);
    }
}