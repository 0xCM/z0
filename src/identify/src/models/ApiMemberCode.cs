//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Seed;

    /// <summary>
    /// Identifies a member defined by executable code (derived from the method implementation)
    /// </summary>    
    public readonly struct ApiMemberCode 
    {
        public static ApiMemberCode Empty => Define(ApiMember.Empty, BinaryCode.Empty);

        public readonly ApiMember Member;

        public readonly BinaryCode Encoded;

        public OpKindId? KindId {get;}

        [MethodImpl(Inline)]
        public static ApiMemberCode Define(ApiMember member, BinaryCode code)
            => new ApiMemberCode(member, code);

        public IdentifiedCode ApiCode
        {
            [MethodImpl(Inline)]
            get => IdentifiedCode.Define(Id,Encoded);
        }

        public ApiHostUri HostUri => Member.HostUri;

        public OpIdentity Id => Member.Id;

        public OpUri Uri => Member.OpUri;

        public MethodInfo Method => Member.Method;

        [MethodImpl(Inline)]
        public static implicit operator IdentifiedCode(ApiMemberCode src)
            => src.ApiCode;

        [MethodImpl(Inline)]
        ApiMemberCode(ApiMember member, BinaryCode code)
        {
            this.Member = member;
            this.Encoded = code;       
            this.KindId = member.KindId;     
        }

        public bool Equals(ApiMemberCode other)
            => Encoded.Equals(other.Encoded);

        public override int GetHashCode()
            => Uri.GetHashCode();

        public override bool Equals(object src)
            => src is ApiMemberCode m && Equals(m);        

        public string Format(int uripad)
            => text.concat(Member.OpUri.Format().PadRight(uripad), Encoded.Format());

        public string Format()
            => Format(20);

        public override string ToString()
            => Format();             
    }
}