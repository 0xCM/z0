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

    public readonly struct WfToken : ITextual, IEquatable<WfToken>, IComparable<WfToken>
    {
        [MethodImpl(Inline), Op]
        public static WfToken create(WfPartKind kind, Type src)
            => new WfToken((((uint)src.MetadataToken & BitMasks.Literals.Lo24u) | ((uint)kind << 24) ) | hash(src.AssemblyQualifiedName));

        [MethodImpl(Inline), Op]
        public static WfToken create(WfStepId step)
            => new WfToken((((uint)step.HostKey & BitMasks.Literals.Lo24u) | (1u << 24) ) | hash(step.HostName));

        public readonly ulong Value;

        public static WfToken Empty => default;

        [MethodImpl(Inline)]
        public WfToken(ulong value)
            => Value = value;

        public WfPartKind Kind
        {
            [MethodImpl(Inline)]
            get => (WfPartKind)((uint)Value >> 24);
        }

        public Address32 Offset
        {
            [MethodImpl(Inline)]
            get => (uint)Value & BitMasks.Literals.Lo24u;
        }

        public uint Id
        {
            [MethodImpl(Inline)]
            get => (uint)(Value >> 32);
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Value == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Value != 0;
        }

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => hash(Id);
        }

        public ulong Hash64
        {
            [MethodImpl(Inline)]
            get => Id;
        }

        [MethodImpl(Inline)]
        public bool Equals(WfToken src)
            => Id == src.Id;

        [MethodImpl(Inline)]
        public int CompareTo(WfToken src)
            => Id.CompareTo(src.Id);

        public override bool Equals(object src)
            => src is WfToken t && Equals(t);
        public string Format()
            => text.format("{0}:{1} {2}", Kind.ToString(), Offset, Id.FormatAsmHex());

        public override int GetHashCode()
            => (int)Hash;

        public override string ToString()
            => Format();
    }
}