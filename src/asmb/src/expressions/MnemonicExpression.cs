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
    
    public readonly struct MnemonicExpression : ISymbolic<MnemonicExpression,AsciCode16>
    {
        public AsciCode16 Data {get;}

        public static MnemonicExpression Empty 
            => new MnemonicExpression(new char[0]{});

        [MethodImpl(Inline)]
        public static implicit operator MnemonicExpression(string src)
            => new MnemonicExpression(src);

        [MethodImpl(Inline)]
        public static implicit operator MnemonicExpression(char[] src)
            => new MnemonicExpression(src);

        [MethodImpl(Inline)]
        public MnemonicExpression(string src)
            => Data = Symbolic.encode(src, ASCI, n16);

        [MethodImpl(Inline)]
        public MnemonicExpression(char[] src)
            => Data = Symbolic.encode(src, ASCI, n16);

        public MnemonicExpression Zero 
            => Empty;

        /// <summary>
        /// The expression length
        /// </summary>
        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public bool IsEmpty 
        {
            [MethodImpl(Inline)]
            get => Data.IsEmpty;
        }

        public bool IsNonEmpty 
        {
            [MethodImpl(Inline)]
            get => Data.IsNonEmpty;
        }

        [MethodImpl(Inline)]
        public bool Equals(MnemonicExpression src)
            => src.Data.Equals(Data);
        
        public override bool Equals(object src)
            => src is MnemonicExpression x && Equals(x);
        
        public override int GetHashCode()
            => Data.GetHashCode();        
        public string Format()
            => Data.Format();
        
        public override string ToString()
            => Format();
    }
}