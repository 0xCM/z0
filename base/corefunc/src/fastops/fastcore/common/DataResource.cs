//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static As;

    /// <summary>
    /// Describes an embedded data resource
    /// </summary>
    public readonly struct DataResource
    {
        /// <summary>
        /// Defines a canonical data resource identifier
        /// </summary>
        /// <param name="src">The source span</param>
        [MethodImpl(Inline)]
        public static string Identifier(string basename, ITypeNat w, PrimalKind kind)
            => $"{basename}{w}x{primalsig(kind)}";

        /// <summary>
        /// Defines a canonical data resource identifier
        /// </summary>
        /// <param name="src">The source span</param>
        [MethodImpl(Inline)]
        public static string Identifier(string basename, ITypeNat w1, ITypeNat w2, PrimalKind kind)
            => $"{basename}{w1}x{w2}x{primalsig(kind)}";

        /// <summary>
        /// Describes a data resource
        /// </summary>
        /// <param name="id">The resource id</param>
        /// <param name="src">The resource data</param>
        [MethodImpl(Inline)]
        public static DataResource Define(string id, ReadOnlySpan<byte> src)
            => new DataResource(id, src.Length, location(src));

        [MethodImpl(Inline)]
        public static DataResource Define(string id, int Length, ulong location)
            => new DataResource(id,Length,location);

        [MethodImpl(Inline)]
        internal DataResource(string Id, int Length, ulong Location)
        {
            this.Id = Id;
            this.Length = Length;
            this.Location = Location;
        }

        public readonly string Id;

        public readonly int Length;

        public readonly ulong Location;

        public bool IsEmpty => Location == 0;
         
        [MethodImpl(Inline)]
        public unsafe ReadOnlySpan<byte> GetBytes()
            => new ReadOnlySpan<byte>((void*)Location, Length);
        
        public string Format(bool data = true)
        {
            if(IsEmpty)
                return string.Empty;
                
            var origin = Location.FormatHex(false,true,true,false);
            var datafmt = string.Empty;
            if(data)
            {
                var loaded = GetBytes();
                var current = parenthetical(location(loaded).FormatHex(false,true,true,false));
                datafmt = concat(AsciSym.Colon, AsciSym.Space, embrace(loaded.FormatHexBytes()), AsciSym.Space, current);
            }
            
            return concat($"{Id}, {origin}, {Length}", datafmt);            
        }
        
        public override string ToString()
            => Format();
    }
}