//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;

    public readonly struct MethodAddress : IDataTypeComparable<MethodAddress>
    {
        public MethodInfo Method {get;}

        [MethodImpl(Inline)]
        public MethodAddress(MethodInfo src)
            => Method = src;

        public MemoryAddress Address
            => Method.MethodHandle.Value;

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => Address.Hash;
        }

        [MethodImpl(Inline)]
        public int CompareTo(MethodAddress src)
            => Address.CompareTo(src.Address);

        [MethodImpl(Inline)]
        public bool Equals(MethodAddress src)
            => Address.Equals(src.Address);

        public override bool Equals(object src)
            => src is MethodAddress x && Equals(x);

        public override int GetHashCode()
            => (int)Hash;

        public string Format()
            => string.Format(RP.PSx2, Address, Method.DisplayName());

        public override string ToString()
            => Format();
    }
}