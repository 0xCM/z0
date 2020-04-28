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
    public readonly struct MemberExtract : IOperationalIdentity, ILocatedCode<MemberExtract,LocatedCode>
    {        
        public static MemberExtract Empty => Define(Member.Empty, LocatedCode.Empty);

        public readonly LocatedCode Code;

        public OpIdentity Id {get;}

        public OpUri Uri {get;}
        
        public LocatedCode Content => Code;

        public Member Member {get;}

        [MethodImpl(Inline)]
        public static MemberExtract Define(Member member, LocatedCode encoded)
            => new MemberExtract(member.Id, member.OpUri, member, encoded);
         
        [MethodImpl(Inline)]
        MemberExtract(OpIdentity id, OpUri uri, Member member, LocatedCode encoded)
        {
            this.Id = id;
            this.Uri = uri;
            this.Member = member;
            this.Code = encoded;
        }

        public ReadOnlySpan<byte> Bytes 
        {
            [MethodImpl(Inline)]
            get => Content.Bytes;
        }

        public MemoryAddress Address
        {
            [MethodImpl(Inline)]
            get => Content.Address;
        }
    
        public string Format()
            => Content.Format();
        
        public bool Equals(MemberExtract src)
        {
            var result = Content.Equals(src.Content);
            result &= Id.Equals(src.Id);
            result &= Uri.Equals(src.Uri);
            result &= Member.Equals(src.Member);
            return result;
        }
    }
}