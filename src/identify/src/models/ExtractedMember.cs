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

    public readonly struct ExtractedMember : IReflectedCode<ExtractedMember,LocatedCode>
    {        
        public static ExtractedMember Empty => Define(ApiMember.Empty, LocatedCode.Empty);

        public LocatedCode Encoded {get;}

        public OpIdentity Id {get;}

        public OpUri Uri {get;}
        
        public ApiMember Member {get;}

        public MethodInfo Method => Member.Method;
    
        public ReadOnlySpan<byte> Bytes { [MethodImpl(Inline)] get => Encoded.Bytes; }

        public int Length { [MethodImpl(Inline)] get => Encoded.Length; }

        public bool IsEmpty { [MethodImpl(Inline)] get => Encoded.IsEmpty; }

        public bool IsNonEmpty { [MethodImpl(Inline)] get => Encoded.IsNonEmpty; }

        public MemoryAddress Address { [MethodImpl(Inline)] get => Encoded.Address; }

        public MemoryRange MemorySegment { [MethodImpl(Inline)] get => Encoded.MemorySegment; }

        [MethodImpl(Inline)]
        public static ExtractedMember Define(ApiMember member, LocatedCode encoded)
            => new ExtractedMember(member.Id, member.OpUri, member, encoded);
         
        [MethodImpl(Inline)]
        internal ExtractedMember(OpIdentity id, OpUri uri, ApiMember member, LocatedCode encoded)
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