//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Control;
    
    using N = N1;
    using C = AsciCode;
    using API = AsciCodes;

    /// <summary>
    /// Defines an asci code sequence of length 1
    /// </summary>
    public readonly struct AsciCode : IAsciSequence<C,N>
    {
        public static C Empty => new C(AsciCharCode.Null);
        
        public const int Length = 1;
        
        internal readonly AsciCharCode Code;
        
        [MethodImpl(Inline), Op]
        public static ref readonly AsciCode define(in byte src)
            => ref view<byte,AsciCode>(src);

        [MethodImpl(Inline), Op]
        public static Symbol<AsciChar,byte> symbol(AsciCode src)
            => Symbolic.symbol<AsciChar,byte>(src);

        [MethodImpl(Inline), Op]
        public static string format(AsciCode src)
            => new string(new char[Length]{(char)src.Code});

        [MethodImpl(Inline), Op]
        public static char @char(AsciCode src)
            => (char)src;

        public C Zero
        {
            [MethodImpl(Inline)]
            get => Empty;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Code == AsciCharCode.Null;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Code != AsciCharCode.Null;
        }

        [MethodImpl(Inline)]
        public bool Equals(C src)
            => Code == src.Code;

        public override int GetHashCode()
            => Code.GetHashCode();

        public override bool Equals(object src)
            => src is C c && Equals(c);

        [MethodImpl(Inline)]
        public string Format()
            => format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator C(AsciCharCode src)
            => new AsciCode(src);

        [MethodImpl(Inline)]
        public static implicit operator AsciCharCode(C src)
            => src.Code;

        [MethodImpl(Inline)]
        public static implicit operator C(char src)
            => new AsciCode((AsciCharCode)src);

        [MethodImpl(Inline)]
        public static implicit operator char(C src)
            => (char)src.Code;

        [MethodImpl(Inline)]
        public static implicit operator C(AsciChar src)
            => new AsciCode((AsciCharCode)src);

        [MethodImpl(Inline)]
        public static implicit operator AsciChar(C src)
            => (AsciChar)src.Code;

        [MethodImpl(Inline)]
        public static implicit operator C(byte src)
            => new AsciCode((AsciCharCode)src);

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

        [MethodImpl(Inline)]
        public AsciCode(AsciCharCode code)
        {
            this.Code = code;
        }
    }
}