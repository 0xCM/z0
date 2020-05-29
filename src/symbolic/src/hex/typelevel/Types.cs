//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct X00 : IHexCode<X00>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X00 src) => HexKind.x00;

        [MethodImpl(Inline)]
        public static implicit operator byte(X00 src) => 0x00;
        
        public HexKind Kind => HexKind.x00;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X01 : IHexCode<X01>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X01 src) => HexKind.x01;

        [MethodImpl(Inline)]
        public static implicit operator byte(X01 src) => 0x01;

        public HexKind Kind => HexKind.x01;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X02 : IHexCode<X02>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X02 src) => HexKind.x02;

        [MethodImpl(Inline)]
        public static implicit operator byte(X02 src) => 0x02;

        public HexKind Kind => HexKind.x02;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X03 : IHexCode<X03>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X03 src) => HexKind.x03;

        [MethodImpl(Inline)]
        public static implicit operator byte(X03 src) => 0x03;

        public HexKind Kind => HexKind.x03;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X04 : IHexCode<X04>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X04 src) => HexKind.x04;

        [MethodImpl(Inline)]
        public static implicit operator byte(X04 src) => 0x04;

        public HexKind Kind => HexKind.x04;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X05 : IHexCode<X05>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X05 src) => HexKind.x05;

        [MethodImpl(Inline)]
        public static implicit operator byte(X05 src) => 0x05;

        public HexKind Kind => HexKind.x05;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X06 : IHexCode<X06>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X06 src) => HexKind.x06;

        [MethodImpl(Inline)]
        public static implicit operator byte(X06 src) => 0x06;

        public HexKind Kind => HexKind.x06;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X07 : IHexCode<X07>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X07 src) => HexKind.x07;

        [MethodImpl(Inline)]
        public static implicit operator byte(X07 src) => 0x07;

        public HexKind Kind => HexKind.x07;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X08 : IHexCode<X08>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X08 src) => HexKind.x08;

        [MethodImpl(Inline)]
        public static implicit operator byte(X08 src) => 0x08;

        public HexKind Kind => HexKind.x08;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X09 : IHexCode<X09>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X09 src) => HexKind.x09;

        [MethodImpl(Inline)]
        public static implicit operator byte(X09 src) => 0x09;

        public HexKind Kind => HexKind.x09;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X0A : IHexCode<X0A>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X0A src) => HexKind.x0a;

        [MethodImpl(Inline)]
        public static implicit operator byte(X0A src) => 0x0a;

        public HexKind Kind => HexKind.x0a;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X0B : IHexCode<X0B>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X0B src) => HexKind.x0b;

        [MethodImpl(Inline)]
        public static implicit operator byte(X0B src) => 0x0b;

        public HexKind Kind => HexKind.x0b;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X0C : IHexCode<X0C>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X0C src) => HexKind.x0c;

        [MethodImpl(Inline)]
        public static implicit operator byte(X0C src) => 0x0c;

        public HexKind Kind => HexKind.x0c;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X0D : IHexCode<X0D>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X0D src) => HexKind.x0d;

        [MethodImpl(Inline)]
        public static implicit operator byte(X0D src) => 0x0d;

        public HexKind Kind => HexKind.x0d;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X0E : IHexCode<X0E>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X0E src) => HexKind.x0e;

        [MethodImpl(Inline)]
        public static implicit operator byte(X0E src) => 0x0e;

        public HexKind Kind => HexKind.x0e;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X0F : IHexCode<X0F>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X0F src) => HexKind.x0f;

        [MethodImpl(Inline)]
        public static implicit operator byte(X0F src) => 0x0f;

        public HexKind Kind => HexKind.x0f;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X10 : IHexCode<X10>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X10 src) => HexKind.x10;

        [MethodImpl(Inline)]
        public static implicit operator byte(X10 src) => 0x10;

        public HexKind Kind => HexKind.x10;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X11 : IHexCode<X11>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X11 src) => HexKind.x11;

        [MethodImpl(Inline)]
        public static implicit operator byte(X11 src) => 0x11;

        public HexKind Kind => HexKind.x11;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X12 : IHexCode<X12>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X12 src) => HexKind.x12;

        [MethodImpl(Inline)]
        public static implicit operator byte(X12 src) => 0x12;

        public HexKind Kind => HexKind.x12;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X13 : IHexCode<X13>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X13 src) => HexKind.x13;

        [MethodImpl(Inline)]
        public static implicit operator byte(X13 src) => 0x13;

        public HexKind Kind => HexKind.x13;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X14 : IHexCode<X14>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X14 src) => HexKind.x14;

        [MethodImpl(Inline)]
        public static implicit operator byte(X14 src) => 0x14;

        public HexKind Kind => HexKind.x14;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X15 : IHexCode<X15>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X15 src) => HexKind.x15;

        [MethodImpl(Inline)]
        public static implicit operator byte(X15 src) => 0x15;

        public HexKind Kind => HexKind.x15;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X16 : IHexCode<X16>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X16 src) => HexKind.x16;

        [MethodImpl(Inline)]
        public static implicit operator byte(X16 src) => 0x16;

        public HexKind Kind => HexKind.x16;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X17 : IHexCode<X17>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X17 src) => HexKind.x17;

        [MethodImpl(Inline)]
        public static implicit operator byte(X17 src) => 0x17;

        public HexKind Kind => HexKind.x17;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X18 : IHexCode<X18>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X18 src) => HexKind.x18;

        [MethodImpl(Inline)]
        public static implicit operator byte(X18 src) => 0x18;

        public HexKind Kind => HexKind.x18;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X19 : IHexCode<X19>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X19 src) => HexKind.x19;

        [MethodImpl(Inline)]
        public static implicit operator byte(X19 src) => 0x19;

        public HexKind Kind => HexKind.x19;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X1A : IHexCode<X1A>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X1A src) => HexKind.x1a;

        [MethodImpl(Inline)]
        public static implicit operator byte(X1A src) => 0x1a;

        public HexKind Kind => HexKind.x1a;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X1B : IHexCode<X1B>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X1B src) => HexKind.x1b;

        [MethodImpl(Inline)]
        public static implicit operator byte(X1B src) => 0x1b;

        public HexKind Kind => HexKind.x1b;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X1C : IHexCode<X1C>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X1C src) => HexKind.x1c;

        [MethodImpl(Inline)]
        public static implicit operator byte(X1C src) => 0x1c;

        public HexKind Kind => HexKind.x1c;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X1D : IHexCode<X1D>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X1D src) => HexKind.x1d;

        [MethodImpl(Inline)]
        public static implicit operator byte(X1D src) => 0x1d;

        public HexKind Kind => HexKind.x1d;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X1E : IHexCode<X1E>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X1E src) => HexKind.x1e;

        [MethodImpl(Inline)]
        public static implicit operator byte(X1E src) => 0x1e;

        public HexKind Kind => HexKind.x1e;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X1F : IHexCode<X1F>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X1F src) => HexKind.x1f;

        [MethodImpl(Inline)]
        public static implicit operator byte(X1F src) => 0x1f;

        public HexKind Kind => HexKind.x1f;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X20 : IHexCode<X20>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X20 src) => HexKind.x20;

        [MethodImpl(Inline)]
        public static implicit operator byte(X20 src) => 0x20;

        public HexKind Kind => HexKind.x20;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X21 : IHexCode<X21>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X21 src) => HexKind.x21;

        [MethodImpl(Inline)]
        public static implicit operator byte(X21 src) => 0x21;

        public HexKind Kind => HexKind.x21;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X22 : IHexCode<X22>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X22 src) => HexKind.x22;

        [MethodImpl(Inline)]
        public static implicit operator byte(X22 src) => 0x22;

        public HexKind Kind => HexKind.x22;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X23 : IHexCode<X23>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X23 src) => HexKind.x23;

        [MethodImpl(Inline)]
        public static implicit operator byte(X23 src) => 0x23;

        public HexKind Kind => HexKind.x23;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X24 : IHexCode<X24>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X24 src) => HexKind.x24;

        [MethodImpl(Inline)]
        public static implicit operator byte(X24 src) => 0x24;

        public HexKind Kind => HexKind.x24;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X25 : IHexCode<X25>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X25 src) => HexKind.x25;

        [MethodImpl(Inline)]
        public static implicit operator byte(X25 src) => 0x25;

        public HexKind Kind => HexKind.x25;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X26 : IHexCode<X26>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X26 src) => HexKind.x26;

        [MethodImpl(Inline)]
        public static implicit operator byte(X26 src) => 0x26;

        public HexKind Kind => HexKind.x26;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X27 : IHexCode<X27>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X27 src) => HexKind.x27;

        [MethodImpl(Inline)]
        public static implicit operator byte(X27 src) => 0x27;

        public HexKind Kind => HexKind.x27;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X28 : IHexCode<X28>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X28 src) => HexKind.x28;

        [MethodImpl(Inline)]
        public static implicit operator byte(X28 src) => 0x28;

        public HexKind Kind => HexKind.x28;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X29 : IHexCode<X29>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X29 src) => HexKind.x29;

        [MethodImpl(Inline)]
        public static implicit operator byte(X29 src) => 0x29;

        public HexKind Kind => HexKind.x29;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X2A : IHexCode<X2A>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X2A src) => HexKind.x2a;

        [MethodImpl(Inline)]
        public static implicit operator byte(X2A src) => 0x2a;

        public HexKind Kind => HexKind.x2a;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X2B : IHexCode<X2B>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X2B src) => HexKind.x2b;

        [MethodImpl(Inline)]
        public static implicit operator byte(X2B src) => 0x2b;

        public HexKind Kind => HexKind.x2b;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X2C : IHexCode<X2C>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X2C src) => HexKind.x2c;

        [MethodImpl(Inline)]
        public static implicit operator byte(X2C src) => 0x2c;

        public HexKind Kind => HexKind.x2c;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X2D : IHexCode<X2D>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X2D src) => HexKind.x2d;

        [MethodImpl(Inline)]
        public static implicit operator byte(X2D src) => 0x2d;

        public HexKind Kind => HexKind.x2d;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X2E : IHexCode<X2E>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X2E src) => HexKind.x2e;

        [MethodImpl(Inline)]
        public static implicit operator byte(X2E src) => 0x2e;

        public HexKind Kind => HexKind.x2e;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X2F : IHexCode<X2F>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X2F src) => HexKind.x2f;

        [MethodImpl(Inline)]
        public static implicit operator byte(X2F src) => 0x2f;

        public HexKind Kind => HexKind.x2f;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X30 : IHexCode<X30>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X30 src) => HexKind.x30;

        [MethodImpl(Inline)]
        public static implicit operator byte(X30 src) => 0x30;

        public HexKind Kind => HexKind.x30;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X31 : IHexCode<X31>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X31 src) => HexKind.x31;

        [MethodImpl(Inline)]
        public static implicit operator byte(X31 src) => 0x31;

        public HexKind Kind => HexKind.x31;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X32 : IHexCode<X32>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X32 src) => HexKind.x32;

        [MethodImpl(Inline)]
        public static implicit operator byte(X32 src) => 0x32;

        public HexKind Kind => HexKind.x32;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X33 : IHexCode<X33>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X33 src) => HexKind.x33;

        [MethodImpl(Inline)]
        public static implicit operator byte(X33 src) => 0x33;

        public HexKind Kind => HexKind.x33;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X34 : IHexCode<X34>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X34 src) => HexKind.x34;

        [MethodImpl(Inline)]
        public static implicit operator byte(X34 src) => 0x34;

        public HexKind Kind => HexKind.x34;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X35 : IHexCode<X35>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X35 src) => HexKind.x35;

        [MethodImpl(Inline)]
        public static implicit operator byte(X35 src) => 0x35;

        public HexKind Kind => HexKind.x35;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X36 : IHexCode<X36>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X36 src) => HexKind.x36;

        [MethodImpl(Inline)]
        public static implicit operator byte(X36 src) => 0x36;

        public HexKind Kind => HexKind.x36;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X37 : IHexCode<X37>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X37 src) => HexKind.x37;

        [MethodImpl(Inline)]
        public static implicit operator byte(X37 src) => 0x37;

        public HexKind Kind => HexKind.x37;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X38 : IHexCode<X38>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X38 src) => HexKind.x38;

        [MethodImpl(Inline)]
        public static implicit operator byte(X38 src) => 0x38;

        public HexKind Kind => HexKind.x38;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X39 : IHexCode<X39>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X39 src) => HexKind.x39;

        [MethodImpl(Inline)]
        public static implicit operator byte(X39 src) => 0x39;

        public HexKind Kind => HexKind.x39;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X3A : IHexCode<X3A>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X3A src) => HexKind.x3a;

        [MethodImpl(Inline)]
        public static implicit operator byte(X3A src) => 0x3a;

        public HexKind Kind => HexKind.x3a;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X3B : IHexCode<X3B>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X3B src) => HexKind.x3b;

        [MethodImpl(Inline)]
        public static implicit operator byte(X3B src) => 0x3b;

        public HexKind Kind => HexKind.x3b;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X3C : IHexCode<X3C>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X3C src) => HexKind.x3c;

        [MethodImpl(Inline)]
        public static implicit operator byte(X3C src) => 0x3c;

        public HexKind Kind => HexKind.x3c;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X3D : IHexCode<X3D>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X3D src) => HexKind.x3d;

        [MethodImpl(Inline)]
        public static implicit operator byte(X3D src) => 0x3d;

        public HexKind Kind => HexKind.x3d;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X3E : IHexCode<X3E>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X3E src) => HexKind.x3e;

        [MethodImpl(Inline)]
        public static implicit operator byte(X3E src) => 0x3e;

        public HexKind Kind => HexKind.x3e;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X3F : IHexCode<X3F>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X3F src) => HexKind.x3f;

        [MethodImpl(Inline)]
        public static implicit operator byte(X3F src) => 0x3f;

        public HexKind Kind => HexKind.x3f;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X40 : IHexCode<X40>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X40 src) => HexKind.x40;

        [MethodImpl(Inline)]
        public static implicit operator byte(X40 src) => 0x40;

        public HexKind Kind => HexKind.x40;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X41 : IHexCode<X41>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X41 src) => HexKind.x41;

        [MethodImpl(Inline)]
        public static implicit operator byte(X41 src) => 0x41;

        public HexKind Kind => HexKind.x41;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X42 : IHexCode<X42>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X42 src) => HexKind.x42;

        [MethodImpl(Inline)]
        public static implicit operator byte(X42 src) => 0x42;

        public HexKind Kind => HexKind.x42;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X43 : IHexCode<X43>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X43 src) => HexKind.x43;

        [MethodImpl(Inline)]
        public static implicit operator byte(X43 src) => 0x43;

        public HexKind Kind => HexKind.x43;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X44 : IHexCode<X44>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X44 src) => HexKind.x44;

        [MethodImpl(Inline)]
        public static implicit operator byte(X44 src) => 0x44;

        public HexKind Kind => HexKind.x44;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X45 : IHexCode<X45>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X45 src) => HexKind.x45;

        [MethodImpl(Inline)]
        public static implicit operator byte(X45 src) => 0x45;

        public HexKind Kind => HexKind.x45;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X46 : IHexCode<X46>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X46 src) => HexKind.x46;

        [MethodImpl(Inline)]
        public static implicit operator byte(X46 src) => 0x46;

        public HexKind Kind => HexKind.x46;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X47 : IHexCode<X47>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X47 src) => HexKind.x47;

        [MethodImpl(Inline)]
        public static implicit operator byte(X47 src) => 0x47;

        public HexKind Kind => HexKind.x47;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X48 : IHexCode<X48>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X48 src) => HexKind.x48;

        [MethodImpl(Inline)]
        public static implicit operator byte(X48 src) => 0x48;

        public HexKind Kind => HexKind.x48;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X49 : IHexCode<X49>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X49 src) => HexKind.x49;

        [MethodImpl(Inline)]
        public static implicit operator byte(X49 src) => 0x49;

        public HexKind Kind => HexKind.x49;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X4A : IHexCode<X4A>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X4A src) => HexKind.x4a;

        [MethodImpl(Inline)]
        public static implicit operator byte(X4A src) => 0x4a;

        public HexKind Kind => HexKind.x4a;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X4B : IHexCode<X4B>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X4B src) => HexKind.x4b;

        [MethodImpl(Inline)]
        public static implicit operator byte(X4B src) => 0x4b;

        public HexKind Kind => HexKind.x4b;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X4C : IHexCode<X4C>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X4C src) => HexKind.x4c;

        [MethodImpl(Inline)]
        public static implicit operator byte(X4C src) => 0x4c;

        public HexKind Kind => HexKind.x4c;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X4D : IHexCode<X4D>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X4D src) => HexKind.x4d;

        [MethodImpl(Inline)]
        public static implicit operator byte(X4D src) => 0x4d;

        public HexKind Kind => HexKind.x4d;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X4E : IHexCode<X4E>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X4E src) => HexKind.x4e;

        [MethodImpl(Inline)]
        public static implicit operator byte(X4E src) => 0x4e;

        public HexKind Kind => HexKind.x4e;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X4F : IHexCode<X4F>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X4F src) => HexKind.x4f;

        [MethodImpl(Inline)]
        public static implicit operator byte(X4F src) => 0x4f;

        public HexKind Kind => HexKind.x4f;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X50 : IHexCode<X50>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X50 src) => HexKind.x50;

        [MethodImpl(Inline)]
        public static implicit operator byte(X50 src) => 0x50;

        public HexKind Kind => HexKind.x50;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X51 : IHexCode<X51>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X51 src) => HexKind.x51;

        [MethodImpl(Inline)]
        public static implicit operator byte(X51 src) => 0x51;

        public HexKind Kind => HexKind.x51;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X52 : IHexCode<X52>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X52 src) => HexKind.x52;

        [MethodImpl(Inline)]
        public static implicit operator byte(X52 src) => 0x52;

        public HexKind Kind => HexKind.x52;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X53 : IHexCode<X53>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X53 src) => HexKind.x53;

        [MethodImpl(Inline)]
        public static implicit operator byte(X53 src) => 0x53;

        public HexKind Kind => HexKind.x53;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X54 : IHexCode<X54>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X54 src) => HexKind.x54;

        [MethodImpl(Inline)]
        public static implicit operator byte(X54 src) => 0x54;

        public HexKind Kind => HexKind.x54;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X55 : IHexCode<X55>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X55 src) => HexKind.x55;

        [MethodImpl(Inline)]
        public static implicit operator byte(X55 src) => 0x55;

        public HexKind Kind => HexKind.x55;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X56 : IHexCode<X56>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X56 src) => HexKind.x56;

        [MethodImpl(Inline)]
        public static implicit operator byte(X56 src) => 0x56;

        public HexKind Kind => HexKind.x56;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X57 : IHexCode<X57>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X57 src) => HexKind.x57;

        [MethodImpl(Inline)]
        public static implicit operator byte(X57 src) => 0x57;

        public HexKind Kind => HexKind.x57;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X58 : IHexCode<X58>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X58 src) => HexKind.x58;

        [MethodImpl(Inline)]
        public static implicit operator byte(X58 src) => 0x58;

        public HexKind Kind => HexKind.x58;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X59 : IHexCode<X59>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X59 src) => HexKind.x59;

        [MethodImpl(Inline)]
        public static implicit operator byte(X59 src) => 0x59;

        public HexKind Kind => HexKind.x59;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X5A : IHexCode<X5A>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X5A src) => HexKind.x5a;

        [MethodImpl(Inline)]
        public static implicit operator byte(X5A src) => 0x5a;

        public HexKind Kind => HexKind.x5a;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X5B : IHexCode<X5B>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X5B src) => HexKind.x5b;

        [MethodImpl(Inline)]
        public static implicit operator byte(X5B src) => 0x5b;

        public HexKind Kind => HexKind.x5b;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X5C : IHexCode<X5C>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X5C src) => HexKind.x5c;

        [MethodImpl(Inline)]
        public static implicit operator byte(X5C src) => 0x5c;

        public HexKind Kind => HexKind.x5c;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X5D : IHexCode<X5D>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X5D src) => HexKind.x5d;

        [MethodImpl(Inline)]
        public static implicit operator byte(X5D src) => 0x5d;

        public HexKind Kind => HexKind.x5d;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X5E : IHexCode<X5E>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X5E src) => HexKind.x5e;

        [MethodImpl(Inline)]
        public static implicit operator byte(X5E src) => 0x5e;

        public HexKind Kind => HexKind.x5e;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X5F : IHexCode<X5F>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X5F src) => HexKind.x5f;

        [MethodImpl(Inline)]
        public static implicit operator byte(X5F src) => 0x5f;

        public HexKind Kind => HexKind.x5f;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X60 : IHexCode<X60>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X60 src) => HexKind.x60;

        [MethodImpl(Inline)]
        public static implicit operator byte(X60 src) => 0x60;

        public HexKind Kind => HexKind.x60;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X61 : IHexCode<X61>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X61 src) => HexKind.x61;

        [MethodImpl(Inline)]
        public static implicit operator byte(X61 src) => 0x61;

        public HexKind Kind => HexKind.x61;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X62 : IHexCode<X62>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X62 src) => HexKind.x62;

        [MethodImpl(Inline)]
        public static implicit operator byte(X62 src) => 0x62;

        public HexKind Kind => HexKind.x62;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X63 : IHexCode<X63>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X63 src) => HexKind.x63;

        [MethodImpl(Inline)]
        public static implicit operator byte(X63 src) => 0x63;

        public HexKind Kind => HexKind.x63;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X64 : IHexCode<X64>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X64 src) => HexKind.x64;

        [MethodImpl(Inline)]
        public static implicit operator byte(X64 src) => 0x64;

        public HexKind Kind => HexKind.x64;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X65 : IHexCode<X65>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X65 src) => HexKind.x65;

        [MethodImpl(Inline)]
        public static implicit operator byte(X65 src) => 0x65;

        public HexKind Kind => HexKind.x65;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X66 : IHexCode<X66>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X66 src) => HexKind.x66;

        [MethodImpl(Inline)]
        public static implicit operator byte(X66 src) => 0x66;

        public HexKind Kind => HexKind.x66;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X67 : IHexCode<X67>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X67 src) => HexKind.x67;

        [MethodImpl(Inline)]
        public static implicit operator byte(X67 src) => 0x67;

        public HexKind Kind => HexKind.x67;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X68 : IHexCode<X68>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X68 src) => HexKind.x68;

        [MethodImpl(Inline)]
        public static implicit operator byte(X68 src) => 0x68;

        public HexKind Kind => HexKind.x68;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X69 : IHexCode<X69>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X69 src) => HexKind.x69;

        [MethodImpl(Inline)]
        public static implicit operator byte(X69 src) => 0x69;

        public HexKind Kind => HexKind.x69;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X6A : IHexCode<X6A>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X6A src) => HexKind.x6a;

        [MethodImpl(Inline)]
        public static implicit operator byte(X6A src) => 0x6a;

        public HexKind Kind => HexKind.x6a;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X6B : IHexCode<X6B>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X6B src) => HexKind.x6b;

        [MethodImpl(Inline)]
        public static implicit operator byte(X6B src) => 0x6b;

        public HexKind Kind => HexKind.x6b;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X6C : IHexCode<X6C>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X6C src) => HexKind.x6c;

        [MethodImpl(Inline)]
        public static implicit operator byte(X6C src) => 0x6c;

        public HexKind Kind => HexKind.x6c;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X6D : IHexCode<X6D>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X6D src) => HexKind.x6d;

        [MethodImpl(Inline)]
        public static implicit operator byte(X6D src) => 0x6d;

        public HexKind Kind => HexKind.x6d;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X6E : IHexCode<X6E>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X6E src) => HexKind.x6e;

        [MethodImpl(Inline)]
        public static implicit operator byte(X6E src) => 0x6e;

        public HexKind Kind => HexKind.x6e;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X6F : IHexCode<X6F>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X6F src) => HexKind.x6f;

        [MethodImpl(Inline)]
        public static implicit operator byte(X6F src) => 0x6f;

        public HexKind Kind => HexKind.x6f;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X70 : IHexCode<X70>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X70 src) => HexKind.x70;

        [MethodImpl(Inline)]
        public static implicit operator byte(X70 src) => 0x70;

        public HexKind Kind => HexKind.x70;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X71 : IHexCode<X71>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X71 src) => HexKind.x71;

        [MethodImpl(Inline)]
        public static implicit operator byte(X71 src) => 0x71;

        public HexKind Kind => HexKind.x71;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X72 : IHexCode<X72>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X72 src) => HexKind.x72;

        [MethodImpl(Inline)]
        public static implicit operator byte(X72 src) => 0x72;

        public HexKind Kind => HexKind.x72;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X73 : IHexCode<X73>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X73 src) => HexKind.x73;

        [MethodImpl(Inline)]
        public static implicit operator byte(X73 src) => 0x73;

        public HexKind Kind => HexKind.x73;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X74 : IHexCode<X74>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X74 src) => HexKind.x74;

        [MethodImpl(Inline)]
        public static implicit operator byte(X74 src) => 0x74;

        public HexKind Kind => HexKind.x74;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X75 : IHexCode<X75>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X75 src) => HexKind.x75;

        [MethodImpl(Inline)]
        public static implicit operator byte(X75 src) => 0x75;

        public HexKind Kind => HexKind.x75;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X76 : IHexCode<X76>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X76 src) => HexKind.x76;

        [MethodImpl(Inline)]
        public static implicit operator byte(X76 src) => 0x76;

        public HexKind Kind => HexKind.x76;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X77 : IHexCode<X77>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X77 src) => HexKind.x77;

        [MethodImpl(Inline)]
        public static implicit operator byte(X77 src) => 0x77;

        public HexKind Kind => HexKind.x77;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X78 : IHexCode<X78>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X78 src) => HexKind.x78;

        [MethodImpl(Inline)]
        public static implicit operator byte(X78 src) => 0x78;

        public HexKind Kind => HexKind.x78;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X79 : IHexCode<X79>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X79 src) => HexKind.x79;

        [MethodImpl(Inline)]
        public static implicit operator byte(X79 src) => 0x79;

        public HexKind Kind => HexKind.x79;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X7A : IHexCode<X7A>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X7A src) => HexKind.x7a;

        [MethodImpl(Inline)]
        public static implicit operator byte(X7A src) => 0x7a;

        public HexKind Kind => HexKind.x7a;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X7B : IHexCode<X7B>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X7B src) => HexKind.x7b;

        [MethodImpl(Inline)]
        public static implicit operator byte(X7B src) => 0x7b;

        public HexKind Kind => HexKind.x7b;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X7C : IHexCode<X7C>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X7C src) => HexKind.x7c;

        [MethodImpl(Inline)]
        public static implicit operator byte(X7C src) => 0x7c;

        public HexKind Kind => HexKind.x7c;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X7D : IHexCode<X7D>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X7D src) => HexKind.x7d;

        [MethodImpl(Inline)]
        public static implicit operator byte(X7D src) => 0x7d;

        public HexKind Kind => HexKind.x7d;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X7E : IHexCode<X7E>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X7E src) => HexKind.x7e;

        [MethodImpl(Inline)]
        public static implicit operator byte(X7E src) => 0x7e;

        public HexKind Kind => HexKind.x7e;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X7F : IHexCode<X7F>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X7F src) => HexKind.x7f;

        [MethodImpl(Inline)]
        public static implicit operator byte(X7F src) => 0x7f;

        public HexKind Kind => HexKind.x7f;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X80 : IHexCode<X80>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X80 src) => HexKind.x80;

        [MethodImpl(Inline)]
        public static implicit operator byte(X80 src) => 0x80;

        public HexKind Kind => HexKind.x80;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X81 : IHexCode<X81>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X81 src) => HexKind.x81;

        [MethodImpl(Inline)]
        public static implicit operator byte(X81 src) => 0x81;

        public HexKind Kind => HexKind.x81;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X82 : IHexCode<X82>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X82 src) => HexKind.x82;

        [MethodImpl(Inline)]
        public static implicit operator byte(X82 src) => 0x82;

        public HexKind Kind => HexKind.x82;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X83 : IHexCode<X83>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X83 src) => HexKind.x83;

        [MethodImpl(Inline)]
        public static implicit operator byte(X83 src) => 0x83;

        public HexKind Kind => HexKind.x83;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X84 : IHexCode<X84>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X84 src) => HexKind.x84;

        [MethodImpl(Inline)]
        public static implicit operator byte(X84 src) => 0x84;

        public HexKind Kind => HexKind.x84;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X85 : IHexCode<X85>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X85 src) => HexKind.x85;

        [MethodImpl(Inline)]
        public static implicit operator byte(X85 src) => 0x85;

        public HexKind Kind => HexKind.x85;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X86 : IHexCode<X86>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X86 src) => HexKind.x86;

        [MethodImpl(Inline)]
        public static implicit operator byte(X86 src) => 0x86;

        public HexKind Kind => HexKind.x86;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X87 : IHexCode<X87>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X87 src) => HexKind.x87;

        [MethodImpl(Inline)]
        public static implicit operator byte(X87 src) => 0x87;

        public HexKind Kind => HexKind.x87;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X88 : IHexCode<X88>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X88 src) => HexKind.x88;

        [MethodImpl(Inline)]
        public static implicit operator byte(X88 src) => 0x88;

        public HexKind Kind => HexKind.x88;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X89 : IHexCode<X89>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X89 src) => HexKind.x89;

        [MethodImpl(Inline)]
        public static implicit operator byte(X89 src) => 0x89;

        public HexKind Kind => HexKind.x89;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X8A : IHexCode<X8A>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X8A src) => HexKind.x8a;

        [MethodImpl(Inline)]
        public static implicit operator byte(X8A src) => 0x8a;

        public HexKind Kind => HexKind.x8a;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X8B : IHexCode<X8B>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X8B src) => HexKind.x8b;

        [MethodImpl(Inline)]
        public static implicit operator byte(X8B src) => 0x8b;

        public HexKind Kind => HexKind.x8b;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X8C : IHexCode<X8C>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X8C src) => HexKind.x8c;

        [MethodImpl(Inline)]
        public static implicit operator byte(X8C src) => 0x8c;

        public HexKind Kind => HexKind.x8c;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X8D : IHexCode<X8D>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X8D src) => HexKind.x8d;

        [MethodImpl(Inline)]
        public static implicit operator byte(X8D src) => 0x8d;

        public HexKind Kind => HexKind.x8d;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X8E : IHexCode<X8E>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X8E src) => HexKind.x8e;

        [MethodImpl(Inline)]
        public static implicit operator byte(X8E src) => 0x8e;

        public HexKind Kind => HexKind.x8e;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X8F : IHexCode<X8F>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X8F src) => HexKind.x8f;

        [MethodImpl(Inline)]
        public static implicit operator byte(X8F src) => 0x8f;

        public HexKind Kind => HexKind.x8f;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X90 : IHexCode<X90>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X90 src) => HexKind.x90;

        [MethodImpl(Inline)]
        public static implicit operator byte(X90 src) => 0x90;

        public HexKind Kind => HexKind.x90;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X91 : IHexCode<X91>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X91 src) => HexKind.x91;

        [MethodImpl(Inline)]
        public static implicit operator byte(X91 src) => 0x91;

        public HexKind Kind => HexKind.x91;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X92 : IHexCode<X92>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X92 src) => HexKind.x92;

        [MethodImpl(Inline)]
        public static implicit operator byte(X92 src) => 0x92;

        public HexKind Kind => HexKind.x92;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X93 : IHexCode<X93>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X93 src) => HexKind.x93;

        [MethodImpl(Inline)]
        public static implicit operator byte(X93 src) => 0x93;

        public HexKind Kind => HexKind.x93;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X94 : IHexCode<X94>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X94 src) => HexKind.x94;

        [MethodImpl(Inline)]
        public static implicit operator byte(X94 src) => 0x94;

        public HexKind Kind => HexKind.x94;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X95 : IHexCode<X95>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X95 src) => HexKind.x95;

        [MethodImpl(Inline)]
        public static implicit operator byte(X95 src) => 0x95;

        public HexKind Kind => HexKind.x95;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X96 : IHexCode<X96>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X96 src) => HexKind.x96;

        [MethodImpl(Inline)]
        public static implicit operator byte(X96 src) => 0x96;

        public HexKind Kind => HexKind.x96;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X97 : IHexCode<X97>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X97 src) => HexKind.x97;

        [MethodImpl(Inline)]
        public static implicit operator byte(X97 src) => 0x97;

        public HexKind Kind => HexKind.x97;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X98 : IHexCode<X98>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X98 src) => HexKind.x98;

        [MethodImpl(Inline)]
        public static implicit operator byte(X98 src) => 0x98;

        public HexKind Kind => HexKind.x98;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X99 : IHexCode<X99>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X99 src) => HexKind.x99;

        [MethodImpl(Inline)]
        public static implicit operator byte(X99 src) => 0x99;

        public HexKind Kind => HexKind.x99;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X9A : IHexCode<X9A>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X9A src) => HexKind.x9a;

        [MethodImpl(Inline)]
        public static implicit operator byte(X9A src) => 0x9a;

        public HexKind Kind => HexKind.x9a;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X9B : IHexCode<X9B>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X9B src) => HexKind.x9b;

        [MethodImpl(Inline)]
        public static implicit operator byte(X9B src) => 0x9b;

        public HexKind Kind => HexKind.x9b;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X9C : IHexCode<X9C>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X9C src) => HexKind.x9c;

        [MethodImpl(Inline)]
        public static implicit operator byte(X9C src) => 0x9c;

        public HexKind Kind => HexKind.x9c;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X9D : IHexCode<X9D>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X9D src) => HexKind.x9d;

        [MethodImpl(Inline)]
        public static implicit operator byte(X9D src) => 0x9d;

        public HexKind Kind => HexKind.x9d;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X9E : IHexCode<X9E>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X9E src) => HexKind.x9e;

        [MethodImpl(Inline)]
        public static implicit operator byte(X9E src) => 0x9e;

        public HexKind Kind => HexKind.x9e;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct X9F : IHexCode<X9F>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(X9F src) => HexKind.x9f;

        [MethodImpl(Inline)]
        public static implicit operator byte(X9F src) => 0x9f;

        public HexKind Kind => HexKind.x9f;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XA0 : IHexCode<XA0>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XA0 src) => HexKind.xa0;

        [MethodImpl(Inline)]
        public static implicit operator byte(XA0 src) => 0xa0;

        public HexKind Kind => HexKind.xa0;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XA1 : IHexCode<XA1>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XA1 src) => HexKind.xa1;

        [MethodImpl(Inline)]
        public static implicit operator byte(XA1 src) => 0xa1;

        public HexKind Kind => HexKind.xa1;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XA2 : IHexCode<XA2>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XA2 src) => HexKind.xa2;

        [MethodImpl(Inline)]
        public static implicit operator byte(XA2 src) => 0xa2;

        public HexKind Kind => HexKind.xa2;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XA3 : IHexCode<XA3>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XA3 src) => HexKind.xa3;

        [MethodImpl(Inline)]
        public static implicit operator byte(XA3 src) => 0xa3;

        public HexKind Kind => HexKind.xa3;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XA4 : IHexCode<XA4>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XA4 src) => HexKind.xa4;

        [MethodImpl(Inline)]
        public static implicit operator byte(XA4 src) => 0xa4;

        public HexKind Kind => HexKind.xa4;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XA5 : IHexCode<XA5>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XA5 src) => HexKind.xa5;

        [MethodImpl(Inline)]
        public static implicit operator byte(XA5 src) => 0xa5;

        public HexKind Kind => HexKind.xa5;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XA6 : IHexCode<XA6>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XA6 src) => HexKind.xa6;

        [MethodImpl(Inline)]
        public static implicit operator byte(XA6 src) => 0xa6;

        public HexKind Kind => HexKind.xa6;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XA7 : IHexCode<XA7>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XA7 src) => HexKind.xa7;

        [MethodImpl(Inline)]
        public static implicit operator byte(XA7 src) => 0xa7;

        public HexKind Kind => HexKind.xa7;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XA8 : IHexCode<XA8>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XA8 src) => HexKind.xa8;

        [MethodImpl(Inline)]
        public static implicit operator byte(XA8 src) => 0xa8;

        public HexKind Kind => HexKind.xa8;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XA9 : IHexCode<XA9>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XA9 src) => HexKind.xa9;

        [MethodImpl(Inline)]
        public static implicit operator byte(XA9 src) => 0xa9;

        public HexKind Kind => HexKind.xa9;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XAA : IHexCode<XAA>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XAA src) => HexKind.xaa;

        [MethodImpl(Inline)]
        public static implicit operator byte(XAA src) => 0xaa;

        public HexKind Kind => HexKind.xaa;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XAB : IHexCode<XAB>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XAB src) => HexKind.xab;

        [MethodImpl(Inline)]
        public static implicit operator byte(XAB src) => 0xab;

        public HexKind Kind => HexKind.xab;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XAC : IHexCode<XAC>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XAC src) => HexKind.xac;

        [MethodImpl(Inline)]
        public static implicit operator byte(XAC src) => 0xac;

        public HexKind Kind => HexKind.xac;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XAD : IHexCode<XAD>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XAD src) => HexKind.xad;

        [MethodImpl(Inline)]
        public static implicit operator byte(XAD src) => 0xad;

        public HexKind Kind => HexKind.xad;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XAE : IHexCode<XAE>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XAE src) => HexKind.xae;

        [MethodImpl(Inline)]
        public static implicit operator byte(XAE src) => 0xae;

        public HexKind Kind => HexKind.xae;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XAF : IHexCode<XAF>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XAF src) => HexKind.xaf;

        [MethodImpl(Inline)]
        public static implicit operator byte(XAF src) => 0xaf;

        public HexKind Kind => HexKind.xaf;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XB0 : IHexCode<XB0>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XB0 src) => HexKind.xb0;

        [MethodImpl(Inline)]
        public static implicit operator byte(XB0 src) => 0xb0;

        public HexKind Kind => HexKind.xb0;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XB1 : IHexCode<XB1>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XB1 src) => HexKind.xb1;

        [MethodImpl(Inline)]
        public static implicit operator byte(XB1 src) => 0xb1;

        public HexKind Kind => HexKind.xb1;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XB2 : IHexCode<XB2>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XB2 src) => HexKind.xb2;

        [MethodImpl(Inline)]
        public static implicit operator byte(XB2 src) => 0xb2;

        public HexKind Kind => HexKind.xb2;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XB3 : IHexCode<XB3>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XB3 src) => HexKind.xb3;

        [MethodImpl(Inline)]
        public static implicit operator byte(XB3 src) => 0xb3;

        public HexKind Kind => HexKind.xb3;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XB4 : IHexCode<XB4>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XB4 src) => HexKind.xb4;

        [MethodImpl(Inline)]
        public static implicit operator byte(XB4 src) => 0xb4;

        public HexKind Kind => HexKind.xb4;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XB5 : IHexCode<XB5>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XB5 src) => HexKind.xb5;

        [MethodImpl(Inline)]
        public static implicit operator byte(XB5 src) => 0xb5;

        public HexKind Kind => HexKind.xb5;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XB6 : IHexCode<XB6>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XB6 src) => HexKind.xb6;

        [MethodImpl(Inline)]
        public static implicit operator byte(XB6 src) => 0xb6;

        public HexKind Kind => HexKind.xb6;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XB7 : IHexCode<XB7>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XB7 src) => HexKind.xb7;

        [MethodImpl(Inline)]
        public static implicit operator byte(XB7 src) => 0xb7;

        public HexKind Kind => HexKind.xb7;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XB8 : IHexCode<XB8>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XB8 src) => HexKind.xb8;

        [MethodImpl(Inline)]
        public static implicit operator byte(XB8 src) => 0xb8;

        public HexKind Kind => HexKind.xb8;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XB9 : IHexCode<XB9>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XB9 src) => HexKind.xb9;

        [MethodImpl(Inline)]
        public static implicit operator byte(XB9 src) => 0xb9;

        public HexKind Kind => HexKind.xb9;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XBA : IHexCode<XBA>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XBA src) => HexKind.xba;

        [MethodImpl(Inline)]
        public static implicit operator byte(XBA src) => 0xba;

        public HexKind Kind => HexKind.xba;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XBB : IHexCode<XBB>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XBB src) => HexKind.xbb;

        [MethodImpl(Inline)]
        public static implicit operator byte(XBB src) => 0xbb;

        public HexKind Kind => HexKind.xbb;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XBC : IHexCode<XBC>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XBC src) => HexKind.xbc;

        [MethodImpl(Inline)]
        public static implicit operator byte(XBC src) => 0xbc;

        public HexKind Kind => HexKind.xbc;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XBD : IHexCode<XBD>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XBD src) => HexKind.xbd;

        [MethodImpl(Inline)]
        public static implicit operator byte(XBD src) => 0xbd;

        public HexKind Kind => HexKind.xbd;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XBE : IHexCode<XBE>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XBE src) => HexKind.xbe;

        [MethodImpl(Inline)]
        public static implicit operator byte(XBE src) => 0xbe;

        public HexKind Kind => HexKind.xbe;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XBF : IHexCode<XBF>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XBF src) => HexKind.xbf;

        [MethodImpl(Inline)]
        public static implicit operator byte(XBF src) => 0xbf;

        public HexKind Kind => HexKind.xbf;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XC0 : IHexCode<XC0>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XC0 src) => HexKind.xc0;

        [MethodImpl(Inline)]
        public static implicit operator byte(XC0 src) => 0xc0;

        public HexKind Kind => HexKind.xc0;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XC1 : IHexCode<XC1>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XC1 src) => HexKind.xc1;

        [MethodImpl(Inline)]
        public static implicit operator byte(XC1 src) => 0xc1;

        public HexKind Kind => HexKind.xc1;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XC2 : IHexCode<XC2>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XC2 src) => HexKind.xc2;

        [MethodImpl(Inline)]
        public static implicit operator byte(XC2 src) => 0xc2;

        public HexKind Kind => HexKind.xc2;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XC3 : IHexCode<XC3>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XC3 src) => HexKind.xc3;

        [MethodImpl(Inline)]
        public static implicit operator byte(XC3 src) => 0xc3;

        public HexKind Kind => HexKind.xc3;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XC4 : IHexCode<XC4>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XC4 src) => HexKind.xc4;

        [MethodImpl(Inline)]
        public static implicit operator byte(XC4 src) => 0xc4;

        public HexKind Kind => HexKind.xc4;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XC5 : IHexCode<XC5>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XC5 src) => HexKind.xc5;

        [MethodImpl(Inline)]
        public static implicit operator byte(XC5 src) => 0xc5;

        public HexKind Kind => HexKind.xc5;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XC6 : IHexCode<XC6>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XC6 src) => HexKind.xc6;

        [MethodImpl(Inline)]
        public static implicit operator byte(XC6 src) => 0xc6;

        public HexKind Kind => HexKind.xc6;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XC7 : IHexCode<XC7>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XC7 src) => HexKind.xc7;

        [MethodImpl(Inline)]
        public static implicit operator byte(XC7 src) => 0xc7;

        public HexKind Kind => HexKind.xc7;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XC8 : IHexCode<XC8>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XC8 src) => HexKind.xc8;

        [MethodImpl(Inline)]
        public static implicit operator byte(XC8 src) => 0xc8;

        public HexKind Kind => HexKind.xc8;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XC9 : IHexCode<XC9>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XC9 src) => HexKind.xc9;

        [MethodImpl(Inline)]
        public static implicit operator byte(XC9 src) => 0xc9;

        public HexKind Kind => HexKind.xc9;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XCA : IHexCode<XCA>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XCA src) => HexKind.xca;

        [MethodImpl(Inline)]
        public static implicit operator byte(XCA src) => 0xca;

        public HexKind Kind => HexKind.xca;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XCB : IHexCode<XCB>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XCB src) => HexKind.xcb;

        [MethodImpl(Inline)]
        public static implicit operator byte(XCB src) => 0xcb;

        public HexKind Kind => HexKind.xcb;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XCC : IHexCode<XCC>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XCC src) => HexKind.xcc;

        [MethodImpl(Inline)]
        public static implicit operator byte(XCC src) => 0xcc;

        public HexKind Kind => HexKind.xcc;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XCD : IHexCode<XCD>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XCD src) => HexKind.xcd;

        [MethodImpl(Inline)]
        public static implicit operator byte(XCD src) => 0xcd;

        public HexKind Kind => HexKind.xcd;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XCE : IHexCode<XCE>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XCE src) => HexKind.xce;

        [MethodImpl(Inline)]
        public static implicit operator byte(XCE src) => 0xce;

        public HexKind Kind => HexKind.xce;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XCF : IHexCode<XCF>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XCF src) => HexKind.xcf;

        [MethodImpl(Inline)]
        public static implicit operator byte(XCF src) => 0xcf;

        public HexKind Kind => HexKind.xcf;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XD0 : IHexCode<XD0>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XD0 src) => HexKind.xd0;

        [MethodImpl(Inline)]
        public static implicit operator byte(XD0 src) => 0xd0;

        public HexKind Kind => HexKind.xd0;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XD1 : IHexCode<XD1>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XD1 src) => HexKind.xd1;

        [MethodImpl(Inline)]
        public static implicit operator byte(XD1 src) => 0xd1;

        public HexKind Kind => HexKind.xd1;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XD2 : IHexCode<XD2>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XD2 src) => HexKind.xd2;

        [MethodImpl(Inline)]
        public static implicit operator byte(XD2 src) => 0xd2;

        public HexKind Kind => HexKind.xd2;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XD3 : IHexCode<XD3>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XD3 src) => HexKind.xd3;

        [MethodImpl(Inline)]
        public static implicit operator byte(XD3 src) => 0xd3;

        public HexKind Kind => HexKind.xd3;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XD4 : IHexCode<XD4>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XD4 src) => HexKind.xd4;

        [MethodImpl(Inline)]
        public static implicit operator byte(XD4 src) => 0xd4;

        public HexKind Kind => HexKind.xd4;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XD5 : IHexCode<XD5>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XD5 src) => HexKind.xd5;

        [MethodImpl(Inline)]
        public static implicit operator byte(XD5 src) => 0xd5;

        public HexKind Kind => HexKind.xd5;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XD6 : IHexCode<XD6>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XD6 src) => HexKind.xd6;

        [MethodImpl(Inline)]
        public static implicit operator byte(XD6 src) => 0xd6;

        public HexKind Kind => HexKind.xd6;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XD7 : IHexCode<XD7>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XD7 src) => HexKind.xd7;

        [MethodImpl(Inline)]
        public static implicit operator byte(XD7 src) => 0xd7;

        public HexKind Kind => HexKind.xd7;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XD8 : IHexCode<XD8>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XD8 src) => HexKind.xd8;

        [MethodImpl(Inline)]
        public static implicit operator byte(XD8 src) => 0xd8;

        public HexKind Kind => HexKind.xd8;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XD9 : IHexCode<XD9>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XD9 src) => HexKind.xd9;

        [MethodImpl(Inline)]
        public static implicit operator byte(XD9 src) => 0xd9;

        public HexKind Kind => HexKind.xd9;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XDA : IHexCode<XDA>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XDA src) => HexKind.xda;

        [MethodImpl(Inline)]
        public static implicit operator byte(XDA src) => 0xda;

        public HexKind Kind => HexKind.xda;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XDB : IHexCode<XDB>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XDB src) => HexKind.xdb;

        [MethodImpl(Inline)]
        public static implicit operator byte(XDB src) => 0xdb;

        public HexKind Kind => HexKind.xdb;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XDC : IHexCode<XDC>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XDC src) => HexKind.xdc;

        [MethodImpl(Inline)]
        public static implicit operator byte(XDC src) => 0xdc;

        public HexKind Kind => HexKind.xdc;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XDD : IHexCode<XDD>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XDD src) => HexKind.xdd;

        [MethodImpl(Inline)]
        public static implicit operator byte(XDD src) => 0xdd;

        public HexKind Kind => HexKind.xdd;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XDE : IHexCode<XDE>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XDE src) => HexKind.xde;

        [MethodImpl(Inline)]
        public static implicit operator byte(XDE src) => 0xde;

        public HexKind Kind => HexKind.xde;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XDF : IHexCode<XDF>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XDF src) => HexKind.xdf;

        [MethodImpl(Inline)]
        public static implicit operator byte(XDF src) => 0xdf;

        public HexKind Kind => HexKind.xdf;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XE0 : IHexCode<XE0>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XE0 src) => HexKind.xe0;

        [MethodImpl(Inline)]
        public static implicit operator byte(XE0 src) => 0xe0;

        public HexKind Kind => HexKind.xe0;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XE1 : IHexCode<XE1>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XE1 src) => HexKind.xe1;

        [MethodImpl(Inline)]
        public static implicit operator byte(XE1 src) => 0xe1;

        public HexKind Kind => HexKind.xe1;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XE2 : IHexCode<XE2>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XE2 src) => HexKind.xe2;

        [MethodImpl(Inline)]
        public static implicit operator byte(XE2 src) => 0xe2;

        public HexKind Kind => HexKind.xe2;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XE3 : IHexCode<XE3>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XE3 src) => HexKind.xe3;

        [MethodImpl(Inline)]
        public static implicit operator byte(XE3 src) => 0xe3;

        public HexKind Kind => HexKind.xe3;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XE4 : IHexCode<XE4>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XE4 src) => HexKind.xe4;

        [MethodImpl(Inline)]
        public static implicit operator byte(XE4 src) => 0xe4;

        public HexKind Kind => HexKind.xe4;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XE5 : IHexCode<XE5>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XE5 src) => HexKind.xe5;

        [MethodImpl(Inline)]
        public static implicit operator byte(XE5 src) => 0xe5;

        public HexKind Kind => HexKind.xe5;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XE6 : IHexCode<XE6>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XE6 src) => HexKind.xe6;

        [MethodImpl(Inline)]
        public static implicit operator byte(XE6 src) => 0xe6;

        public HexKind Kind => HexKind.xe6;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XE7 : IHexCode<XE7>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XE7 src) => HexKind.xe7;

        [MethodImpl(Inline)]
        public static implicit operator byte(XE7 src) => 0xe7;

        public HexKind Kind => HexKind.xe7;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XE8 : IHexCode<XE8>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XE8 src) => HexKind.xe8;

        [MethodImpl(Inline)]
        public static implicit operator byte(XE8 src) => 0xe8;

        public HexKind Kind => HexKind.xe8;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XE9 : IHexCode<XE9>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XE9 src) => HexKind.xe9;

        [MethodImpl(Inline)]
        public static implicit operator byte(XE9 src) => 0xe9;

        public HexKind Kind => HexKind.xe9;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XEA : IHexCode<XEA>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XEA src) => HexKind.xea;

        [MethodImpl(Inline)]
        public static implicit operator byte(XEA src) => 0xea;

        public HexKind Kind => HexKind.xea;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XEB : IHexCode<XEB>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XEB src) => HexKind.xeb;

        [MethodImpl(Inline)]
        public static implicit operator byte(XEB src) => 0xeb;

        public HexKind Kind => HexKind.xeb;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XEC : IHexCode<XEC>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XEC src) => HexKind.xec;

        [MethodImpl(Inline)]
        public static implicit operator byte(XEC src) => 0xec;

        public HexKind Kind => HexKind.xec;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XED : IHexCode<XED>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XED src) => HexKind.xed;

        [MethodImpl(Inline)]
        public static implicit operator byte(XED src) => 0xed;

        public HexKind Kind => HexKind.xed;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XEE : IHexCode<XEE>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XEE src) => HexKind.xee;

        [MethodImpl(Inline)]
        public static implicit operator byte(XEE src) => 0xee;

        public HexKind Kind => HexKind.xee;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XEF : IHexCode<XEF>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XEF src) => HexKind.xef;

        [MethodImpl(Inline)]
        public static implicit operator byte(XEF src) => 0xef;

        public HexKind Kind => HexKind.xef;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XF0 : IHexCode<XF0>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XF0 src) => HexKind.xf0;

        [MethodImpl(Inline)]
        public static implicit operator byte(XF0 src) => 0xf0;

        public HexKind Kind => HexKind.xf0;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XF1 : IHexCode<XF1>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XF1 src) => HexKind.xf1;

        [MethodImpl(Inline)]
        public static implicit operator byte(XF1 src) => 0xf1;

        public HexKind Kind => HexKind.xf1;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XF2 : IHexCode<XF2>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XF2 src) => HexKind.xf2;

        [MethodImpl(Inline)]
        public static implicit operator byte(XF2 src) => 0xf2;

        public HexKind Kind => HexKind.xf2;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XF3 : IHexCode<XF3>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XF3 src) => HexKind.xf3;

        [MethodImpl(Inline)]
        public static implicit operator byte(XF3 src) => 0xf3;

        public HexKind Kind => HexKind.xf3;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XF4 : IHexCode<XF4>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XF4 src) => HexKind.xf4;

        [MethodImpl(Inline)]
        public static implicit operator byte(XF4 src) => 0xf4;

        public HexKind Kind => HexKind.xf4;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XF5 : IHexCode<XF5>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XF5 src) => HexKind.xf5;

        [MethodImpl(Inline)]
        public static implicit operator byte(XF5 src) => 0xf5;

        public HexKind Kind => HexKind.xf5;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XF6 : IHexCode<XF6>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XF6 src) => HexKind.xf6;

        [MethodImpl(Inline)]
        public static implicit operator byte(XF6 src) => 0xf6;

        public HexKind Kind => HexKind.xf6;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XF7 : IHexCode<XF7>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XF7 src) => HexKind.xf7;

        [MethodImpl(Inline)]
        public static implicit operator byte(XF7 src) => 0xf7;

        public HexKind Kind => HexKind.xf7;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XF8 : IHexCode<XF8>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XF8 src) => HexKind.xf8;

        [MethodImpl(Inline)]
        public static implicit operator byte(XF8 src) => 0xf8;

        public HexKind Kind => HexKind.xf8;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XF9 : IHexCode<XF9>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XF9 src) => HexKind.xf9;

        [MethodImpl(Inline)]
        public static implicit operator byte(XF9 src) => 0xf9;

        public HexKind Kind => HexKind.xf9;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XFA : IHexCode<XFA>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XFA src) => HexKind.xfa;

        [MethodImpl(Inline)]
        public static implicit operator byte(XFA src) => 0xfa;

        public HexKind Kind => HexKind.xfa;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XFB : IHexCode<XFB>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XFB src) => HexKind.xfb;

        [MethodImpl(Inline)]
        public static implicit operator byte(XFB src) => 0xfb;

        public HexKind Kind => HexKind.xfb;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XFC : IHexCode<XFC>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XFC src) => HexKind.xfc;

        [MethodImpl(Inline)]
        public static implicit operator byte(XFC src) => 0xfc;

        public HexKind Kind => HexKind.xfc;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XFD : IHexCode<XFD>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XFD src) => HexKind.xfd;

        [MethodImpl(Inline)]
        public static implicit operator byte(XFD src) => 0xfd;

        public HexKind Kind => HexKind.xfd;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XFE : IHexCode<XFE>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XFE src) => HexKind.xfe;

        [MethodImpl(Inline)]
        public static implicit operator byte(XFE src) => 0xfe;

        public HexKind Kind => HexKind.xfe;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }

    public readonly struct XFF : IHexCode<XFF>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind(XFF src) => HexKind.xff;

        [MethodImpl(Inline)]
        public static implicit operator byte(XFF src) => 0xff;

        public HexKind Kind => HexKind.xff;

        public string Format() => Kind.Format();

        public override string ToString() => Format();
    }


}