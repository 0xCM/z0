//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines a uri-identified encoded block with a known base address
    /// </summary>
    public readonly struct MemberCode : IMemberCode<MemberCode,LocatedCode>
    {
        /// <summary>
        /// The source member identity
        /// </summary>
        public OpUri OpUri {get;}

        /// <summary>
        /// The data, located
        /// </summary>
        public LocatedCode Encoded {get;}

        [MethodImpl(Inline)]
        public static MemberCode define(OpUri uri, LocatedCode data)
            => new MemberCode(uri, data);

        [MethodImpl(Inline)]
        public static MemberCode define(OpUri uri, MemoryAddress address, BinaryCode encoded)
            => new MemberCode(uri, new LocatedCode(address,encoded));
            
        /// <summary>
        /// The encoded content as byte array
        /// </summary>
        public byte[] Data 
        { 
            [MethodImpl(Inline)] 
            get => Encoded.Data;
        }
        
        /// <summary>
        /// The encoded byte count
        /// </summary>
        public int Size 
        { 
            [MethodImpl(Inline)] 
            get => Encoded.Length; 
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
        public static implicit operator ReadOnlySpan<byte>(MemberCode code)
            => code.Data;

        [MethodImpl(Inline)]
        public static implicit operator BinaryCode(MemberCode src)
            => src.Encoded.Encoded;

        [MethodImpl(Inline)]
        public static implicit operator LocatedCode(MemberCode src)
            => src.Encoded;

        [MethodImpl(Inline)]
        public static implicit operator IdentifiedCode(MemberCode src)
            => new IdentifiedCode(src.Address, src.OpUri, src.Encoded);

        [MethodImpl(Inline)]
        public MemberCode(OpUri uri, LocatedCode code)
        {
            OpUri = uri;
            Encoded = code;
        }

        public MemoryAddress Address  
        { 
            [MethodImpl(Inline)] 
            get => Encoded.Address; 
        }

        public PartId Part 
            => OpUri.Part;
        
        public OpIdentity OpId 
            => OpUri.OpId;

        public ApiHostUri Host 
            => OpUri.Host;

        public string Format(int idpad)
        {
            var a = Encoded.Format();
            var b = OpUri.Format().PadRight(idpad);
            return string.Concat(a,b);
        }

        public string Format()
            => Format(80);

        public bool Equals(MemberCode src)
            => Encoded.Equals(src.Encoded);

        public override int GetHashCode()
            => OpUri.GetHashCode();

        public override bool Equals(object src)
            => src is MemberCode x && Equals(x);        

        public static MemberCode Empty 
            => define(OpUri.Empty, LocatedCode.Empty);
    }
}