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

    /// <summary>
    /// Identifies a workflow step - which is synonymous with its actuator/host/controller
    /// </summary>
    public readonly struct WfRouterId
    {
        public ulong Id {get;}


        [MethodImpl(Inline)]
        public WfRouterId(ulong id)
            => Id = id;

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Id == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Id != 0;
        }

        [MethodImpl(Inline)]
        public bool Equals(WfRouterId src)
            => src.Id == Id;

        public uint Hashed
        {
            [MethodImpl(Inline)]
            get => z.hash(Id);
        }

        public string Format()
            => Id.FormatHexBytes();

        public override int GetHashCode()
            => (int)Hashed;

        public override bool Equals(object src)
            => src is WfRouterId i && Equals(i);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator WfRouterId(ulong src)
            => new WfRouterId(src);

        public static WfRouterId Empty
            => default;
    }
}