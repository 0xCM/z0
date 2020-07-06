//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Linq;

    using static Konst;
    using static As;

    /// <summary>
    /// Describes an embedded data resource
    /// </summary>
    public readonly struct BinaryResource
    {
        [MethodImpl(Inline)]
        public static BinaryResource define(PartId owner, string id, ReadOnlySpan<byte> src)
            => new BinaryResource(owner, id, src.Length, Addressable.address(src));

        [MethodImpl(Inline)]
        public static BinaryResource define(PartId owner, string id, int Length, ulong address)
            => new BinaryResource(owner, id, Length, address);

        /// <summary>
        /// Returns the properties declared by a type that define binary resource content
        /// </summary>
        /// <typeparam name="T">The defining type</typeparam>
        public static PropertyInfo[] providers<T>() 
            => typeof(T)
                .StaticProperties()
                .Where(p => p.PropertyType == typeof(ReadOnlySpan<byte>))
                .ToArray();


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