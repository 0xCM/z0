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
    public readonly struct MemberCode : IEncoded<MemberCode,OperationCode>, IOperational
    {
        public static MemberCode Empty => Define(Member.Empty, BinaryCode.Empty);

        public Member Member {get;}

        public OperationCode Content {get;}

        public OpKindId? KindId {get;}

        public OpIdentity Id => Member.Id;

        public OpUri Uri => Member.OpUri;

        public ApiHostUri Host => Uri.HostPath;

        public MethodInfo Method => Member.Method;

        [MethodImpl(Inline)]
        public static MemberCode Define(Member member, BinaryCode code)
            => new MemberCode(member, code);

        [MethodImpl(Inline)]
        public static implicit operator OperationCode(MemberCode src)
            => src.Content;

        [MethodImpl(Inline)]
        MemberCode(Member member, BinaryCode code)
        {
            Member = member;
            KindId = member.KindId;  
            Content = OperationCode.Define(member.Id, code);   
        }

        public ReadOnlySpan<byte> Bytes 
        {
            [MethodImpl(Inline)]
            get => Content.Bytes;
        }

        public bool Equals(MemberCode other)
            => Content.Equals(other.Content);

        public override int GetHashCode()
            => Uri.GetHashCode();

        public override bool Equals(object src)
            => src is MemberCode m && Equals(m);        

        public string Format(int uripad)
            => text.concat(Member.OpUri.Format().PadRight(uripad), Content.Format());

        public string Format()
            => Format(20);

        public override string ToString()
            => Format();             
    }
}