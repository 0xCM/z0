//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Describes an embedded data resource
    /// </summary>
    public readonly struct BinaryResource
    {
        public readonly string Identifier;

        public readonly PartId Owner;

        public readonly int Length;

        public readonly MemoryAddress Address;

        public ReadOnlySpan<byte> Data 
            => Bytes;

        public bool IsEmpty 
            => Address == 0;

        public string Uri 
            => string.Concat("res", Chars.Colon, Chars.FSlash, Chars.FSlash, Owner.Format(), Chars.FSlash, Identifier);            

        [MethodImpl(Inline)]
        internal BinaryResource(PartId part, string id, int length, ulong address)
        {
            Owner = part;
            Identifier = id;
            Length = length;
            Address = address;
        }         
        
        unsafe ReadOnlySpan<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => new ReadOnlySpan<byte>(Address.Pointer<byte>(), Length);       
        }
    }
}