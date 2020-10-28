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

    public struct CmdToolId : IIdentified<CmdToolId,string>
    {
        public string Id {get;}

        [MethodImpl(Inline)]
        public CmdToolId(string id)
            => Id = id;

        [MethodImpl(Inline)]
        public string Format()
            => Id;

        public override string ToString()
            => Id;

        [MethodImpl(Inline)]
        public static implicit operator CmdToolId(string src)
            => new CmdToolId(src);

        [MethodImpl(Inline)]
        public static implicit operator string(CmdToolId src)
            => src.Id;

        [MethodImpl(Inline)]
        public bool Equals(string src)
            => text.equals(Id, src);

        public override int GetHashCode()
            => Id?.GetHashCode() ?? 0;

        public override bool Equals(object src)
            => src is CmdToolId x && Equals(x);

        [MethodImpl(Inline)]
        public static bool operator ==(CmdToolId a, CmdToolId b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(CmdToolId a, CmdToolId b)
            => !a.Equals(b);
    }
}