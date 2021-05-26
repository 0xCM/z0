//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using static RegFacets;

    [Datatype]
    public readonly struct Register : IDataTypeEquatable<Register>
    {

        /// <summary>
        /// Combines a <see cref='RegIndex'/>, a <see cref='RegClass'/> and a <see cref='RegWidth'/> to produce a <see cref='RegKind'/>
        /// </summary>
        /// <param name="i">The register index</param>
        /// <param name="k">The register class</param>
        /// <param name="w">The register width</param>
        [MethodImpl(Inline), Op]
        public static RegKind kind(RegIndex i, RegClass k, RegWidth w)
            => (RegKind)((uint)i  << IndexField | (uint)k << ClassField | (uint)w << WidthField);

        /// <summary>
        /// Determines the register code from the kind
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline), Op]
        public static RegIndex index(RegKind src)
            => (RegIndex)Bits.bitslice((uint)src, (byte)FieldIndex.C, (byte)FieldWidth.C);

        /// <summary>
        /// Determines the register class from the kind
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline), Op]
        public static RegClass @class(RegKind src)
            => (RegClass)Bits.bitslice((uint)src, (byte)FieldIndex.K, (byte)FieldWidth.K);

        /// <summary>
        /// Determines the register width from the kind
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline), Op]
        public static RegWidth width(RegKind src)
            => (RegWidth)Bits.bitslice((uint)src, (byte)FieldIndex.W, (byte)FieldWidth.W);



        public RegKind Kind {get;}

        [MethodImpl(Inline)]
        public Register(RegKind kind)
            => Kind = kind;

        [MethodImpl(Inline)]
        public Register(RegIndex c, RegClass k, RegWidth w)
            => Kind = kind(c,k,w);

        public RegIndex Code
            => index(Kind);

        public RegClass Class
            => @class(Kind);

        public RegWidth Width
            => width(Kind);

        public Identifier Name
            => Kind.ToString();

        [MethodImpl(Inline)]
        public bool Equals(Register src)
            => src.Kind == Kind;

        public override int GetHashCode()
            => (int)Kind;

        public override bool Equals(object obj)
            => obj is Register x && Equals(x);

        public string Format()
            => "<not-implemented>";

        // public string Format()
        //     => api.format(this);

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
            => @enum.e32u(src.Kind);

        [MethodImpl(Inline)]
        public static implicit operator Register(@enum<RegKind,uint> src)
            => new Register(src.Literal);

        public static Register Empty
            => RegKind.None;
    }
}