//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Seed;

    /// <summary>
    ///  Defines the dataset accumulated for an operation-targeted capture workflow
    /// </summary>
    public readonly struct MemberExtract
    {        
        [MethodImpl(Inline)]
        public static MemberExtract Define(ApiLocatedMember member, MemoryExtract encoded)
            => new MemberExtract(member.Id, member.Uri, member, encoded);
         
        [MethodImpl(Inline)]
        MemberExtract(OpIdentity id, OpUri uri, ApiLocatedMember member, MemoryExtract encoded)
        {
            this.Id = id;
            this.Uri = uri;
            this.Member = member;
            this.EncodedData = encoded;
        }

        public readonly OpIdentity Id; 

        public readonly OpUri Uri;

        public readonly ApiLocatedMember Member;

        public readonly MemoryExtract EncodedData;
    }

}