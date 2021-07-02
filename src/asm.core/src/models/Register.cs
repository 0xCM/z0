//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using api = AsmRegs;

    [DataType]
    public readonly struct Register : IDataTypeEquatable<Register>
    {
        [Op]
        public static string describe(Register src)
        {
            const string Sep = " | ";
            const string Pattern = "[{0,-12} | {1,-8} | {2}]";
            var index = Bitfields.format<RegIndexCode,byte>(src.Code, src.Name, 5);
            var @class = Bitfields.format<RegClassCode,byte>(src.Class, src.Class.ToString(), 4);
            var width = Enums.field<RegWidthCode,ushort>(src.Width, base10, "Width");
            return string.Format(Pattern, index, @class, width);
        }

        public RegKind Kind {get;}

        [MethodImpl(Inline)]
        public Register(RegKind kind)
            => Kind = kind;

        [MethodImpl(Inline)]
        public Register(RegIndexCode c, RegClassCode k, RegWidthCode w)
            => Kind = api.kind(c, k, w);

        public RegIndexCode Code
        {
            [MethodImpl(Inline)]
            get => api.index(Kind);
        }

        public RegClassCode Class
        {
            [MethodImpl(Inline)]
            get => api.@class(Kind);
        }

        public RegWidthCode Width
        {
            [MethodImpl(Inline)]
            get => api.width(Kind);
        }

        public Identifier Name
            => Kind.ToString();

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Kind == RegKind.None;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Kind != RegKind.None;
        }

        [MethodImpl(Inline)]
        public bool Equals(Register src)
            => src.Kind == Kind;

        public override int GetHashCode()
            => (int)Kind;

        public override bool Equals(object obj)
            => obj is Register x && Equals(x);

        public string Format()
            => Kind.ToString();


        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator Register(RegKind src)
            => new Register(src);

        [MethodImpl(Inline)]
        public static implicit operator RegKind(Register src)
            => src.Kind;

        [MethodImpl(Inline)]
        public static implicit operator @enum<RegKind,uint>(Register src)
            => emath.e32u(src.Kind);

        [MethodImpl(Inline)]
        public static implicit operator Register(@enum<RegKind,uint> src)
            => new Register(src.Literal);

        public static Register Empty
            => RegKind.None;
    }
}