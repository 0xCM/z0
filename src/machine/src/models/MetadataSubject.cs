//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct MetadataSubject
    {        
        public MetadataToken Id;

        public MetadataToken OwnerId;

        public asci64 Name;

        public asci64 OwnerName;

        public MemoryAddress Address;

        public MemoryAddress OwnerAddress;

        [MethodImpl(Inline)]
        public MetadataSubject(MetadataToken Id, MetadataToken OwnerId, asci64 Name, asci64 OwnerName, MemoryAddress Address, MemoryAddress OwnerAddress)
        {
            this.Id = Id;
            this.OwnerId = OwnerId;
            this.Name = Name;
            this.OwnerName = OwnerName;
            this.Address = Address;
            this.OwnerAddress = OwnerAddress;
        }
    }
}