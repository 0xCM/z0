//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    /// <summary>
    /// Identifies a member defined by executable code (derived from the method implementation)
    /// </summary>    
    public readonly struct ApiMemberCode : IIdentifiedCode<ApiMemberCode,UriHex>
    {
        public ApiMember Member {get;}

        public UriHex Encoded {get;}
        
        public OpKindId KindId
             => Member.KindId;

        public OpIdentity Id  
            => Member.Id;
        
        public OpUri Uri  
            => Member.OpUri;

        public ApiHostUri Host
             => Uri.Host;

        public MethodInfo Method
             => Member.Method;

        public ReadOnlySpan<byte> Bytes 
        { 
            [MethodImpl(Inline)] 
            get => Encoded.Bytes; 
        }

        public int Length 
        { 
            [MethodImpl(Inline)] 
            get => Encoded.Length; 
        }

        public bool IsEmpty 
        { 
            [MethodImpl(Inline)] 
            get => Encoded.IsEmpty; 
        }

        public bool IsNonEmpty 
        { 
            [MethodImpl(Inline)] 
            get => Encoded.IsNonEmpty; 
        }

        [MethodImpl(Inline)]
        public static implicit operator BinaryCode(ApiMemberCode src)
            => src.Encoded.Encoded;

        [MethodImpl(Inline)]
        public ApiMemberCode(ApiMember member, UriHex code)
        {
            Member = member;
            Encoded = code;
        }

        [MethodImpl(Inline)]
        public ApiMemberCode(ApiMember member, BinaryCode code)
        {
            Member = member;
            Encoded = new UriHex(member.OpUri, code);
        }

        public bool Equals(ApiMemberCode src)
            => Encoded.Equals(src.Encoded);

        public override int GetHashCode()
            => Uri.GetHashCode();

        public override bool Equals(object src)
            => src is ApiMemberCode m && Equals(m);        

        public string Format(int uripad)
            => text.concat(Member.OpUri.Format().PadRight(uripad), Encoded.Format());

        public string Format()
            => Format(80);

        public override string ToString()
            => Format();             

        public static ApiMemberCode Empty 
            => new ApiMemberCode(ApiMember.Empty, BinaryCode.Empty);
    }
}