//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using N = N1;
    using C = AsciSymbol;

    /// <summary>
    /// Lifts an asci code to a structural type
    /// </summary>
    [ApiHost]
    public readonly struct AsciSymbol : IBytes<C,N>
    {
        readonly AsciCharCode Code;

        [MethodImpl(Inline), Op]
        public AsciSymbol(AsciCharCode code)
            => Code = code;

        public string Text
        {
            [MethodImpl(Inline), Op]
            get => asci.@string(Code);
        }

        public ReadOnlySpan<byte> Encoded
        {
            [MethodImpl(Inline), Op]
            get => z.bytes(this);
        }

        public ReadOnlySpan<char> Decoded
        {
            [MethodImpl(Inline), Op]
            get => asci.decode(this);
        }

        public C Zero
        {
            [MethodImpl(Inline), Op]
            get => Empty;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline), Op]
            get => Code == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline), Op]
            get => Code != 0;
        }

        [MethodImpl(Inline)]
        public bool Equals(C src)
            => Code == src.Code;

        [MethodImpl(Inline)]
        public string Format()
            => Text;

        [MethodImpl(Inline)]
        public static implicit operator C(AsciCharCode src)
            => new AsciSymbol(src);

        [MethodImpl(Inline)]
        public static implicit operator AsciCharCode(C src)
            => src.Code;

        [MethodImpl(Inline)]
        public static implicit operator C(char src)
            => new AsciSymbol((AsciCharCode)src);

        [MethodImpl(Inline)]
        public static implicit operator char(C src)
            => (char)src.Code;

        [MethodImpl(Inline)]
        public static implicit operator C(AsciChar src)
            => new AsciSymbol((AsciCharCode)src);

        [MethodImpl(Inline)]
        public static implicit operator AsciChar(C src)
            => (AsciChar)src.Code;

        [MethodImpl(Inline)]
        public static implicit operator C(byte src)
            => new AsciSymbol((AsciCharCode)src);

        [MethodImpl(Inline)]
        public static implicit operator byte(C src)
            => (byte)src.Code;

        [MethodImpl(Inline)]
        public static explicit operator uint(C src)
            => (uint)src.Code;

        [MethodImpl(Inline)]
        public static explicit operator ushort(C src)
            => (ushort)src.Code;

        [MethodImpl(Inline)]
        public static explicit operator ulong(C src)
            => (ulong)src.Code;

        public override int GetHashCode()
            => (int)Code;

        public override bool Equals(object src)
            => src is C c && Equals(c);

        public override string ToString()
            => Text;

        ReadOnlySpan<byte> IByteSeq.View
            => z.bytes(this);

        bool INullity.IsEmpty
            => IsEmpty;

        bool INullity.IsNonEmpty
            => IsNonEmpty;

        int IByteSeq.Length
            => 1;

        bool IEquatable<C>.Equals(C src)
            => Code == src.Code;

        C INullary<C>.Zero
            => Empty;

        string ITextual.Format()
            => Text;

        public static C Empty
            => new C(AsciCharCode.Null);
    }
}