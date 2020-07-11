//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Represents an opcode identifier
    /// </summary>
    public readonly struct OpCodeIdentifier
    {                
        public readonly asci32 Value;

        [MethodImpl(Inline)]
        public static implicit operator string(OpCodeIdentifier src)
            => src.Format();

        [MethodImpl(Inline)]
        public static implicit operator OpCodeIdentifier(string src)
            => new OpCodeIdentifier(src);

        [MethodImpl(Inline)]
        public static implicit operator asci32(OpCodeIdentifier src)
            => src.Value;

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
            Value = src;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Value.IsEmpty;
        }

        public ReadOnlySpan<byte> Encoded
        {
            [MethodImpl(Inline)]
            get => asci.bytes(Value);
        }

        public ReadOnlySpan<char> Decoded
        {
            [MethodImpl(Inline)]
            get => asci.decode(Value);
        }

        public OpCodeIdentifier Zero 
            => Empty;
        
        [MethodImpl(Inline)]
        public string Format()
            => asci.format(Value);

        [MethodImpl(Inline)]
        public bool Equals(OpCodeIdentifier src)
            => Value.Equals(src.Value);
        
        public override string ToString()
            => Format();
        
        public override int GetHashCode()
            => Value.GetHashCode();
        
        public override bool Equals(object src)
            => src is OpCodeIdentifier id && Equals(id);

        public static OpCodeIdentifier Empty 
            => new OpCodeIdentifier(asci.Null);
    }
}