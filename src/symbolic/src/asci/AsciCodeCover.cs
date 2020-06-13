//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Control;
    
    using N = N1;
    using C = AsciCodeCover;

    /// <summary>
    /// Covers an asci code sequence of length 1
    /// </summary>
    public readonly struct AsciCodeCover : IAsciSequence<C,N>
    {
        public static C Empty => new C(AsciCharCode.Null);
        
        public const int Length = 1;
        
        internal readonly AsciCharCode Covered;
        
        [MethodImpl(Inline), Op]
        public static ref readonly AsciCodeCover define(in byte src)
            => ref view<byte,AsciCodeCover>(src);

        [MethodImpl(Inline), Op]
        public static string format(AsciCodeCover src)
            => new string(new char[Length]{(char)src.Covered});

        [MethodImpl(Inline), Op]
        public static char @char(AsciCodeCover src)
            => (char)src;

        public string Text
        {
            [MethodImpl(Inline)]
            get => new string((char)Covered,1);
        }

        public C Zero
        {
            [MethodImpl(Inline)]
            get => Empty;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Covered == AsciCharCode.Null;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Covered != AsciCharCode.Null;
        }

        [MethodImpl(Inline)]
        public bool Equals(C src)
            => Covered == src.Covered;

        public override int GetHashCode()
            => Covered.GetHashCode();

        public override bool Equals(object src)
            => src is C c && Equals(c);

        [MethodImpl(Inline)]
        public string Format()
            => Text;

        public override string ToString()
            => Text;

        [MethodImpl(Inline)]
        public static implicit operator C(AsciCharCode src)
            => new AsciCodeCover(src);

        [MethodImpl(Inline)]
        public static implicit operator AsciCharCode(C src)
            => src.Covered;

        [MethodImpl(Inline)]
        public static implicit operator C(char src)
            => new AsciCodeCover((AsciCharCode)src);

        [MethodImpl(Inline)]
        public static implicit operator char(C src)
            => (char)src.Covered;

        [MethodImpl(Inline)]
        public static implicit operator C(AsciChar src)
            => new AsciCodeCover((AsciCharCode)src);

        [MethodImpl(Inline)]
        public static implicit operator AsciChar(C src)
            => (AsciChar)src.Covered;

        [MethodImpl(Inline)]
        public static implicit operator C(byte src)
            => new AsciCodeCover((AsciCharCode)src);

        [MethodImpl(Inline)]
        public static implicit operator byte(C src)
            => (byte)src.Covered;

        [MethodImpl(Inline)]
        public static explicit operator uint(C src)
            => (uint)src.Covered;

        [MethodImpl(Inline)]
        public static explicit operator ushort(C src)
            => (ushort)src.Covered;

        [MethodImpl(Inline)]
        public static explicit operator ulong(C src)
            => (ulong)src.Covered;

        [MethodImpl(Inline)]
        public AsciCodeCover(AsciCharCode code)
        {
            Covered = code;
        }
    }
}