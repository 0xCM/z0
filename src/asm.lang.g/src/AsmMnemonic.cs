//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct AsmMnemonic
    {
        public string Name {get;}

        [MethodImpl(Inline)]
        public AsmMnemonic(string src)
        {
            Name = src;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Name?.Length ?? 0;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Length == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Length != 0;
        }

        public override int GetHashCode()
            => Name.GetHashCode();

        [MethodImpl(Inline)]
        public string Format()
            => Name;

        [MethodImpl(Inline)]
        public string Format(AsmMnemonicCase @case)
        {
            if(IsEmpty)
                return EmptyString;

            var data = Name;
            switch(@case)
            {
                case AsmMnemonicCase.Captialized:
                    return string.Format("{0}{1}",Char.ToUpperInvariant(Name[0]), data.ToLowerInvariant().Substring(1));
                case AsmMnemonicCase.Lowercase:
                    return data.ToLowerInvariant();
                case AsmMnemonicCase.Uppercase:
                    return data.ToUpperInvariant();
            }
            return data;
        }

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public bool Equals(AsmMnemonic src)
            => Name.Equals(src.Name);

        public override bool Equals(object src)
            => src is AsmMnemonic x && Equals(x);

        [MethodImpl(Inline)]
        public static implicit operator AsmMnemonic(string src)
            => new AsmMnemonic(src);

        [MethodImpl(Inline)]
        public static bool operator ==(AsmMnemonic a, AsmMnemonic b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(AsmMnemonic a, AsmMnemonic b)
            => !a.Equals(b);

        public static AsmMnemonic Empty
        {
            [MethodImpl(Inline)]
            get => new AsmMnemonic(EmptyString);
        }
    }
}