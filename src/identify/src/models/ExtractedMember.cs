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

    public readonly struct ExtractedMember : IMemberCode<ExtractedMember,LocatedCode>
    {        
        public static ExtractedMember Empty => Define(Member.Empty, LocatedCode.Empty);

        public LocatedCode Encoded {get;}

        public OpIdentity Id {get;}

        public OpUri Uri {get;}
        
        public Member Member {get;}

        public MethodInfo Method => Member.Method;
    
        public ReadOnlySpan<byte> Bytes { [MethodImpl(Inline)] get => Encoded.Bytes; }

        public MemoryAddress Address { [MethodImpl(Inline)] get => Encoded.Address; }

        public MemoryRange MemorySegment
        {
            [MethodImpl(Inline)]
            get => (Address, Address + (MemoryAddress)Encoded.Length);
        }

        [MethodImpl(Inline)]
        public static ExtractedMember Define(Member member, LocatedCode encoded)
            => new ExtractedMember(member.Id, member.OpUri, member, encoded);
         
        [MethodImpl(Inline)]
        internal ExtractedMember(OpIdentity id, OpUri uri, Member member, LocatedCode encoded)
        {
            Id = id;
            Uri = uri;
            Member = member;
            Encoded = encoded;
        }

        public string Format()
            => Encoded.Format();
        
        [MethodImpl(Inline)]
        public bool Equals(ExtractedMember src)
            => Encoded.Equals(src.Encoded);
    }
}