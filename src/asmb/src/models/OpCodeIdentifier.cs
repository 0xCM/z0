//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    /// <summary>
    /// Represents an opcode identifier
    /// </summary>
    public readonly struct OpCodeIdentifier
    {        
        public static OpCodeIdentifier Empty => new OpCodeIdentifier(AsciCode32.Null);
        
        public AsciCode32 Encoded {get;}

        [MethodImpl(Inline)]
        public static implicit operator string(OpCodeIdentifier src)
            => src.Format();

        [MethodImpl(Inline)]
        public static implicit operator OpCodeIdentifier(string src)
            => new OpCodeIdentifier(src);

        [MethodImpl(Inline)]
        public static implicit operator AsciCode32(OpCodeIdentifier src)
            => src.Encoded;

        [MethodImpl(Inline)]
        public static implicit operator OpCodeIdentifier(AsciCode32 src)
            => new OpCodeIdentifier(src);

        [MethodImpl(Inline)]
        public static bool operator ==(OpCodeIdentifier d1, OpCodeIdentifier d2)
            => d1.Equals(d2);

        [MethodImpl(Inline)]
        public static bool operator !=(OpCodeIdentifier d1, OpCodeIdentifier d2)
            => !d1.Equals(d2);

        [MethodImpl(Inline)]
        public OpCodeIdentifier(AsciCode32 src)
        {
            Encoded = src;
        }

        [MethodImpl(Inline)]
        public OpCodeIdentifier(string src)
        {
            Encoded = AsciCodes.encode(n32,src ?? string.Empty);
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Encoded.IsEmpty;
        }

        public ReadOnlySpan<char> Decoded
        {
            [MethodImpl(Inline)]
            get => AsciCodes.decode(Encoded);
        }
        
        public ReadOnlySpan<byte> Data
        {
            [MethodImpl(Inline)]
            get => Symbolic.bytes(Encoded);
        }
        
        [MethodImpl(Inline)]
        public string Format()
            => AsciCodes.format(Encoded);

        [MethodImpl(Inline)]
        public bool Equals(OpCodeIdentifier src)
            => Encoded.Equals(src.Encoded);
        
        public override string ToString()
            => Format();
        
        public override int GetHashCode()
            => Encoded.GetHashCode();
        
        public override bool Equals(object src)
            => src is OpCodeIdentifier id && Equals(id);
    }
}