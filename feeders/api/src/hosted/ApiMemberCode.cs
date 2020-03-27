//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Api;

    /// <summary>
    /// Identifies a member defined by executable code (derived from the method implementation)
    /// </summary>
    
    public readonly struct ApiMemberCode : IApiMember<ApiMemberCode>
    {
        public static ApiMemberCode Empty => Define(ApiStatelessMember.Empty, BinaryCode.Empty);

        public readonly ApiStatelessMember Member;

        public readonly BinaryCode Code;

        public ApiCode ApiCode
        {
            [MethodImpl(Inline)]
            get => ApiCode.Define(Id,Code);
        }

        public OpKindId? KindId {get;}

        public ApiHostUri HostUri => Member.HostUri;

        public OpIdentity Id => Member.Id;

        public OpUri Uri => Member.Uri;

        public MethodInfo Method => Member.Method;

        public bool IsEmpty => Code.IsEmpty && Member.IsEmpty;

        ApiMemberCode INullary<ApiMemberCode>.Zero 
            => Empty;

        [MethodImpl(Inline)]
        public static ApiMemberCode Define(ApiStatelessMember member, BinaryCode code)
            => new ApiMemberCode(member, code);

        [MethodImpl(Inline)]
        public static implicit operator ApiCode(ApiMemberCode src)
            => src.ApiCode;

        [MethodImpl(Inline)]
        ApiMemberCode(ApiStatelessMember member, BinaryCode code)
        {
            this.Member = member;
            this.Code = code;       
            this.KindId = null;     
        }

        public bool Equals(ApiMemberCode other)
            => Code.Equals(other.Code);

        public override int GetHashCode()
            => Uri.GetHashCode();

        public override bool Equals(object src)
            => src is ApiMemberCode m && Equals(m);        

        public string Format(int uripad)
            => text.concat(Member.Uri.Format().PadRight(uripad), Code.Format());
        public string Format()
            => Format(20);

        public override string ToString()
            => Format();             
    }
}