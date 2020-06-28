//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct MemoryModel
    {

    }

    

    public struct MetadataSubject
    {        
        public MetadataToken Id;

        public MetadataToken OwnerId;

        public asci64 Name;

        public asci64 OwnerName;

        public MemoryAddress Address;

        public MemoryAddress OwnerAddress;

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

    public readonly struct MetadataSubjectIndex : IIndex<MetadataSubjectIndex,MetadataSubject>
    {
        readonly MetadataSubject[] Data;

        [MethodImpl(Inline)]
        public static implicit operator MetadataSubjectIndex(MetadataSubject[] src)
            => new MetadataSubjectIndex(src);
        
        [MethodImpl(Inline)]
        public MetadataSubjectIndex(MetadataSubject[] src)
        {
            Data = src;
        }
        
        public MetadataSubject[] Content
        {
            [MethodImpl(Inline)]
            get => Data;
        }
    }
    
    public readonly struct MetadataSubjects
    {
        
    }
}