//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
 
    using static Root;

    /// <summary>
    ///  Defines the dataset accumulated for an operation-targeted capture workflow
    /// </summary>
    public readonly struct OpExtract
    {        
        [MethodImpl(Inline)]
        public static OpExtract Defne(OpIdentity id, OpUri uri, LocatedMember member, MemoryExtract encoded)
            => new OpExtract(id,uri,member,encoded);
         
        [MethodImpl(Inline)]
        OpExtract(OpIdentity id, OpUri uri, LocatedMember member, MemoryExtract encoded)
        {
            this.Id = id;
            this.Uri = uri;
            this.Member = member;
            this.EncodedData = encoded;
        }

        public readonly OpIdentity Id; 

        public readonly OpUri Uri;

        public readonly LocatedMember Member;

        public readonly MemoryExtract EncodedData;
    }

    public readonly struct OpExtracts : IFiniteSeq<OpExtract>
    {
        [MethodImpl(Inline)]
        public static implicit operator OpExtracts(OpExtract[] src)
            => new OpExtracts(src);
        
        [MethodImpl(Inline)]
        public OpExtracts(OpExtract[] content)
        {
            this.Content = content;
        }
        
        public OpExtract[] Content {get;}
    }
}