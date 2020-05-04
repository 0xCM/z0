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
    public readonly struct MemberCode : IIdentifiedCode<MemberCode,UriBits>
    {
        public static MemberCode Empty => Define(ApiMember.Empty, BinaryCode.Empty);

        [MethodImpl(Inline)]
        public static MemberCode Define(ApiMember member, BinaryCode code)
            => new MemberCode(member, code);

        [MethodImpl(Inline)]
        public static MemberCode Define(ApiMember member, UriBits code)
            => new MemberCode(member, code);

        public ApiMember Member {get;}

        public UriBits Encoded {get;}
        
        public OpKindId KindId  => Member.KindId;

        public OpIdentity Id  => Member.Id;

        public OpUri Uri  => Member.OpUri;

        public ApiHostUri Host  => Uri.HostPath;

        public MethodInfo Method  => Member.Method;

        public ReadOnlySpan<byte> Bytes { [MethodImpl(Inline)] get => Encoded.Bytes; }

        public int Length { [MethodImpl(Inline)] get => Encoded.Length; }

        public bool IsEmpty { [MethodImpl(Inline)] get => Encoded.IsEmpty; }

        public bool IsNonEmpty { [MethodImpl(Inline)] get => Encoded.IsNonEmpty; }

        [MethodImpl(Inline)]
        public static implicit operator BinaryCode(MemberCode src)
            => src.Encoded.Encoded;

        [MethodImpl(Inline)]
        internal MemberCode(ApiMember member, UriBits code)
        {
            Member = member;
            Encoded = code;
        }

        [MethodImpl(Inline)]
        internal MemberCode(ApiMember member, BinaryCode code)
        {
            Member = member;
            Encoded = new UriBits(member.OpUri, code);
        }

        public bool Equals(MemberCode src)
            => Encoded.Equals(src.Encoded);

        public override int GetHashCode()
            => Uri.GetHashCode();

        public override bool Equals(object src)
            => src is MemberCode m && Equals(m);        

        public string Format(int uripad)
            => text.concat(Member.OpUri.Format().PadRight(uripad), Encoded.Format());

        public string Format()
            => Format(80);

        public override string ToString()
            => Format();             
    }
}