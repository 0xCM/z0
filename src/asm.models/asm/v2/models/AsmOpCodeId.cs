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
    public readonly struct AsmOpCodeId
    {                
        public readonly asci32 Value;

        [MethodImpl(Inline)]
        public static implicit operator string(AsmOpCodeId src)
            => src.Format();

        [MethodImpl(Inline)]
        public static implicit operator AsmOpCodeId(string src)
            => new AsmOpCodeId(src);

        [MethodImpl(Inline)]
        public static implicit operator asci32(AsmOpCodeId src)
            => src.Value;

        [MethodImpl(Inline)]
        public static implicit operator AsmOpCodeId(asci32 src)
            => new AsmOpCodeId(src);

        [MethodImpl(Inline)]
        public static bool operator ==(AsmOpCodeId d1, AsmOpCodeId d2)
            => d1.Equals(d2);

        [MethodImpl(Inline)]
        public static bool operator !=(AsmOpCodeId d1, AsmOpCodeId d2)
            => !d1.Equals(d2);

        [MethodImpl(Inline)]
        public AsmOpCodeId(asci32 src)
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

        public AsmOpCodeId Zero 
            => Empty;
        
        [MethodImpl(Inline)]
        public string Format()
            => asci.format(Value);

        [MethodImpl(Inline)]
        public bool Equals(AsmOpCodeId src)
            => Value.Equals(src.Value);
        
        public override string ToString()
            => Format();
        
        public override int GetHashCode()
            => Value.GetHashCode();
        
        public override bool Equals(object src)
            => src is AsmOpCodeId id && Equals(id);

        public static AsmOpCodeId Empty 
            => new AsmOpCodeId(asci.Null);
    }
}