//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Typed;
    
    public readonly struct MnemonicExpression : ISymbolic<MnemonicExpression,asci16>
    {
        public asci16 Body {get;}

        [MethodImpl(Inline)]
        public static implicit operator MnemonicExpression(string src)
            => new MnemonicExpression(src);

        [MethodImpl(Inline)]
        public MnemonicExpression(asci16 src)
            => Body = src;

        [MethodImpl(Inline)]
        public MnemonicExpression(string src)
            => Body = asci.encode(n16, src);

        [MethodImpl(Inline)]
        public MnemonicExpression(char[] src)
            => Body = asci.encode(n16, src);

        public MnemonicExpression Zero 
            => Empty;

        /// <summary>
        /// The expression length
        /// </summary>
        public int Length
        {
            [MethodImpl(Inline)]
            get => Body.Length;
        }

        public bool IsEmpty 
        {
            [MethodImpl(Inline)]
            get => Body.IsEmpty;
        }

        public bool IsNonEmpty 
        {
            [MethodImpl(Inline)]
            get => Body.IsNonEmpty;
        }

        [Ignore]
        public ReadOnlySpan<byte> Encoded
        {
            [MethodImpl(Inline)]
            get => Symbolic.bytes(Body);
        }

        [Ignore]
        public ReadOnlySpan<char> Decoded
        {
            [MethodImpl(Inline)]
            get => asci.decode(Body);
        }

        [MethodImpl(Inline)]
        public bool Equals(MnemonicExpression src)
            => src.Body.Equals(Body);
        
        public override bool Equals(object src)
            => src is MnemonicExpression x && Equals(x);
        
        public override int GetHashCode()
            => Body.GetHashCode();        
        public string Format()
            => Body.Format();
        
        public override string ToString()
            => Format();

        public static MnemonicExpression Empty 
            => new MnemonicExpression(asci16.Null);
    }
}