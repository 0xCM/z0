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
        public static OpCodeIdentifier Empty => new OpCodeIdentifier(asci32.Null);
        
        public asci32 Body {get;}

        [MethodImpl(Inline)]
        public static implicit operator string(OpCodeIdentifier src)
            => src.Format();

        [MethodImpl(Inline)]
        public static implicit operator OpCodeIdentifier(string src)
            => new OpCodeIdentifier(src);

        [MethodImpl(Inline)]
        public static implicit operator asci32(OpCodeIdentifier src)
            => src.Body;

        [MethodImpl(Inline)]
        public static implicit operator OpCodeIdentifier(asci32 src)
            => new OpCodeIdentifier(src);

        [MethodImpl(Inline)]
        public static bool operator ==(OpCodeIdentifier d1, OpCodeIdentifier d2)
            => d1.Equals(d2);

        [MethodImpl(Inline)]
        public static bool operator !=(OpCodeIdentifier d1, OpCodeIdentifier d2)
            => !d1.Equals(d2);

        [MethodImpl(Inline)]
        public OpCodeIdentifier(asci32 src)
        {
            Body = src;
        }

        [MethodImpl(Inline)]
        public OpCodeIdentifier(string src)
        {
            Body = AsciCodes.encode(n32,src ?? string.Empty);
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Body.IsEmpty;
        }

        public ReadOnlySpan<byte> Encoded
        {
            [MethodImpl(Inline)]
            get => Symbolic.bytes(Body);
        }

        public ReadOnlySpan<char> Decoded
        {
            [MethodImpl(Inline)]
            get => AsciCodes.decode(Body);
        }

        public OpCodeIdentifier Zero 
            => Empty;

        
        [MethodImpl(Inline)]
        public string Format()
            => Symbolic.format(Body);

        [MethodImpl(Inline)]
        public bool Equals(OpCodeIdentifier src)
            => Body.Equals(src.Body);
        
        public override string ToString()
            => Format();
        
        public override int GetHashCode()
            => Body.GetHashCode();
        
        public override bool Equals(object src)
            => src is OpCodeIdentifier id && Equals(id);
    }
}