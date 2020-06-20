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
        public LocatedCode Encoded {get;}

        public OpIdentity Id {get;}

        public OpUri Uri {get;}
        
        public ApiMember Member {get;}
    
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
        public ExtractedMember(OpIdentity id, OpUri uri, ApiMember member, LocatedCode encoded)
        {
            Id = id;
            Uri = uri;
            Member = member;
            Encoded = encoded;
        }
        
        [MethodImpl(Inline)]
        public ExtractedMember(ApiMember member, LocatedCode encoded)
            : this(member.Id, member.OpUri, member, encoded)
            {

            }
        
        public MethodInfo Method 
            => Member.Method;

        public MemoryAddress Address 
        { 
            [MethodImpl(Inline)] 
            get => Encoded.Address; 
        }
        
        public string Format()
            => Encoded.Format();
        
        [MethodImpl(Inline)]
        public bool Equals(ExtractedMember src)
            => Encoded.Equals(src.Encoded);

        public static ExtractedMember Empty 
            => new ExtractedMember(ApiMember.Empty, LocatedCode.Empty);
    }
}