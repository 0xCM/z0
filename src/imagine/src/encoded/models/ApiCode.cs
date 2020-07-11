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
    public readonly struct ApiCode : IIdentifiedCode<ApiCode,MemberCode>
    {
        public ApiMember Member {get;}

        public MemberCode Encoded {get;}

        public OpUri OpUri 
        {
            [MethodImpl(Inline)] 
            get => Encoded.OpUri;        
        }
        
        public byte[] Data 
        { 
            [MethodImpl(Inline)] 
            get => Encoded.Data;
        }
        
        public int Length 
        { 
            [MethodImpl(Inline)] 
            get => Encoded.Length; 
        }

        public ref readonly byte this[int index] 
        { 
            [MethodImpl(Inline)] 
            get => ref Encoded[index]; 
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
        public static implicit operator BinaryCode(ApiCode src)
            => src.Encoded.Encoded;

        [MethodImpl(Inline)]
        public ApiCode(ApiMember member, IdentifiedCode code)
        {
            Member = member;
            Encoded = new MemberCode(member.OpUri, new LocatedCode(member.Address, code.Encoded));
        }

        [MethodImpl(Inline)]
        public ApiCode(ApiMember member, BinaryCode code)
        {
            Member = member;
            Encoded = new MemberCode(member.OpUri, new LocatedCode(member.Address, code));
        }

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

        public bool Equals(ApiCode src)
            => Encoded.Equals(src.Encoded);

        public override int GetHashCode()
            => Uri.GetHashCode();

        public override bool Equals(object src)
            => src is ApiCode m && Equals(m);        

        public string Format(int uripad)
            => text.concat(Member.OpUri.Format().PadRight(uripad), Encoded.Format());

        public string Format()
            => Format(80);

        public override string ToString()
            => Format();             

        public static ApiCode Empty 
            => new ApiCode(ApiMember.Empty, BinaryCode.Empty);
    }
}