//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// Represents an opcode identifier
    /// </summary>
    public readonly struct OpCodeIdentifier : IIdentification<OpCodeIdentifier>
    {        
        public static OpCodeIdentifier Empty => new OpCodeIdentifier(string.Empty);
        
        public string IdentityText {get;}
        
        string Denullified
        {
            [MethodImpl(Inline)]
            get => IdentityText;
        }

        [MethodImpl(Inline)]
        public static implicit operator string(OpCodeIdentifier src)
            => src.Denullified;

        [MethodImpl(Inline)]
        public static implicit operator OpCodeIdentifier(string src)
            => new OpCodeIdentifier(src);

        [MethodImpl(Inline)]
        public static bool operator ==(OpCodeIdentifier d1, OpCodeIdentifier d2)
            => d1.Equals(d2);

        [MethodImpl(Inline)]
        public static bool operator !=(OpCodeIdentifier d1, OpCodeIdentifier d2)
            => !d1.Equals(d2);

        [MethodImpl(Inline)]
        public OpCodeIdentifier(string src)
        {
            IdentityText = src ?? string.Empty;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => text.empty(IdentityText);
        }

        /// <summary>
        /// Formats the dimension in canonical form
        /// </summary>
        public string Format()
            => Denullified;

        [MethodImpl(Inline)]
        public bool Equals(OpCodeIdentifier src)
            => string.Equals(IdentityText, src.IdentityText, NoCase);
        
        public override string ToString()
            => Format();
        
        public override int GetHashCode()
            => Denullified.GetHashCode();
        
        public override bool Equals(object src)
            => src is OpCodeIdentifier id && Equals(id);
    }
}