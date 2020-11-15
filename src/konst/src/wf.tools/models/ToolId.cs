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
    public struct ToolId : IIdentified<ToolId,string>
    {
        public string Id {get;}

        [MethodImpl(Inline)]
        public ToolId(string id)
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
        public bool Equals(ToolId src)
            => Id.Equals(src.Id);

        public override int GetHashCode()
            => Id.GetHashCode();

        public override bool Equals(object src)
            => src is ToolId x && Equals(x);

        [MethodImpl(Inline)]
        public static implicit operator ToolId(string src)
            => new ToolId(src);

        [MethodImpl(Inline)]
        public static implicit operator string(ToolId src)
            => src.Id;

        [MethodImpl(Inline)]
        public static bool operator ==(ToolId a, ToolId b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(ToolId a, ToolId b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        public static implicit operator ToolId(Type src)
            => new ToolId(src.Name);

        public static ToolId Empty
        {
            [MethodImpl(Inline)]
            get => new ToolId(EmptyString);
        }
    }
}