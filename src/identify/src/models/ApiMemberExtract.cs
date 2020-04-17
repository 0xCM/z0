//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Seed;

    /// <summary>
    ///  Defines the dataset accumulated for an operation-targeted capture workflow
    /// </summary>
    public readonly struct ApiMemberExtract
    {        
        public static ApiMemberExtract Empty => Define(ApiMember.Empty, Addressable.Empty);
        
        [MethodImpl(Inline)]
        public static ApiMemberExtract Define(ApiMember member, Addressable encoded)
            => new ApiMemberExtract(member.Id, member.OpUri, member, encoded);
         
        [MethodImpl(Inline)]
        ApiMemberExtract(OpIdentity id, OpUri uri, ApiMember member, Addressable encoded)
        {
            this.Id = id;
            this.Uri = uri;
            this.Member = member;
            this.EncodedData = encoded;
        }

        public readonly OpIdentity Id; 

        public readonly OpUri Uri;

        public readonly ApiMember Member;

        public readonly Addressable EncodedData;
    }
}