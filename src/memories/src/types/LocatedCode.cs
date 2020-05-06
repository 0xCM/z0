//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Seed;
    using static Memories;

    /// <summary>
    /// Encoded x86 bytes extracted from a memory source with a known (nonzero) location
    /// </summary>
    public readonly struct LocatedCode : ILocatedCode<LocatedCode,BinaryCode>
    {
        /// <summary>
        /// Defines a block of encoded data based at a specifed address
        /// </summary>
        /// <param name="data">The source data</param>
        [MethodImpl(Inline)]
        public static LocatedCode Define(MemoryAddress src, byte[] data)
            => new LocatedCode(src, data);        
        
        /// <summary>
        /// The canonical zero
        /// </summary>
        public static LocatedCode Empty => new LocatedCode(0);

        /// <summary>
        /// The head of the memory location from which the data originated
        /// </summary>
        public MemoryAddress Address {get;}
         
        /// <summary>
        /// The encoded content
        /// </summary>
        public BinaryCode Encoded {get;}
        
        public int ByteCount { [MethodImpl(Inline)] get => Encoded.ByteCount; }

        public ReadOnlySpan<byte> Bytes { [MethodImpl(Inline)] get => Encoded.Bytes; }

        public int Length { [MethodImpl(Inline)] get => Encoded.Length; }

        public bool IsEmpty { [MethodImpl(Inline)] get => !Address.NonZero; }

        public bool IsNonEmpty { [MethodImpl(Inline)] get => Address.NonZero; }

        public ref readonly byte Head { [MethodImpl(Inline)] get => ref Encoded.Head;}
        
        public ref readonly byte this[int index] { [MethodImpl(Inline)] get => ref Encoded[index]; }

        public MemoryRange MemorySegment
        {
            [MethodImpl(Inline)]
            get => (Address, Address + (MemoryAddress)Encoded.Length);
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
        public bool Equals(LocatedCode src)
            => Encoded.Equals(src.Encoded); 

        public string Format()
            => Encoded.Format(); 

        [MethodImpl(Inline)]
        public LocatedCode(MemoryAddress src, byte[] data)
        {
            this.Address = insist(src, x => x.NonZero);
            this.Encoded = BinaryCode.Define(insist(data));
        }

        public override int GetHashCode()
            => Encoded.GetHashCode();
        
        public override bool Equals(object src)
            => src is BinaryCode encoded && Equals(encoded);

        [MethodImpl(Inline)]
        LocatedCode(ulong zero)
        {
            Address = zero;
            Encoded = Control.array<byte>();
        }
    }
}