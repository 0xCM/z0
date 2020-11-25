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

    [DataType]
    public struct CmdHostId : IIdentified<CmdHostId,string>
    {
        public string Id {get;}

        [MethodImpl(Inline)]
        public CmdHostId(string id)
            => Id = id;

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => text.empty(Id);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => text.nonempty(Id);
        }

        [MethodImpl(Inline)]
        public string Format()
            => Id;

        public override string ToString()
            => Id;

        [MethodImpl(Inline)]
        public bool Equals(CmdHostId src)
            => Id.Equals(src.Id);

        public override int GetHashCode()
            => Id.GetHashCode();

        public override bool Equals(object src)
            => src is CmdHostId x && Equals(x);

        [MethodImpl(Inline)]
        public static implicit operator CmdHostId(string src)
            => new CmdHostId(src);

        [MethodImpl(Inline)]
        public static implicit operator string(CmdHostId src)
            => src.Id;

        [MethodImpl(Inline)]
        public static bool operator ==(CmdHostId a, CmdHostId b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(CmdHostId a, CmdHostId b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        public static implicit operator CmdHostId(Type src)
            => new CmdHostId(src.Name);

        public static CmdHostId Empty
        {
            [MethodImpl(Inline)]
            get => new CmdHostId(EmptyString);
        }
    }
}