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
    /// Encoded x86 bytes extracted from a memory source with a known (nonzero) location
    /// </summary>
    public readonly struct LocatedCode : ILocatedCode<LocatedCode,BinaryCode>
    {
        /// <summary>
        /// The head of the memory location from which the data originated
        /// </summary>
        public MemoryAddress Address {get;}
         
        /// <summary>
        /// The encoded content
        /// </summary>
        public BinaryCode Encoded {get;}
        
        /// <summary>
        /// The encoded content as byte array
        /// </summary>
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
        
        public ref readonly byte this[int index] 
        { 
            [MethodImpl(Inline)] 
            get => ref Encoded[index]; 
        }

        [MethodImpl(Inline)]
        public static implicit operator byte[](LocatedCode src)
            => src.Encoded;

        [MethodImpl(Inline)]
        public static implicit operator BinaryCode(LocatedCode src)
            => src.Encoded;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<byte>(LocatedCode src)
            => src.Encoded;

        [MethodImpl(Inline)]
        public static bool operator==(LocatedCode a, LocatedCode b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(LocatedCode a, LocatedCode b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        public LocatedCode(MemoryAddress src, byte[] data)
        {
            Address = Demands.insist(src, x => x.IsNonEmpty);
            Encoded = new BinaryCode(Demands.insist(data));
        }

        [MethodImpl(Inline)]
        public bool Equals(LocatedCode src)
            => Encoded.Equals(src.Encoded);         
        
        public string Format()
            => Encoded.Format(); 


        public override int GetHashCode()
            => Encoded.GetHashCode();
        
        public override bool Equals(object src)
            => src is BinaryCode encoded && Equals(encoded);

        [MethodImpl(Inline)]
        LocatedCode(ulong zero)
        {
            Address = zero;
            Encoded = Array.Empty<byte>();
        }

        public MemoryRange MemorySegment
        {
            [MethodImpl(Inline)]
            get => (Address, Address + (MemoryAddress)Encoded.Length);
        }

        public static LocatedCode Empty 
            => new LocatedCode(0);
    }
}