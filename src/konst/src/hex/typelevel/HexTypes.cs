//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface IHexType
    {
        HexKind8 Value {get;}             
    }
    
    public interface IHexType<H> : IHexType
        where H : unmanaged, IHexType<H>
    {        
        Type Reified 
        {
            [MethodImpl(Inline)]
            get => typeof(H);   
        }
    }

    public readonly struct X00 : IHexType<X00>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X00 src) => HexKind8.x00;

        [MethodImpl(Inline)]
        public static implicit operator byte(X00 src) => 0x00;        
        
        public HexKind8 Value => HexKind8.x00;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X01 : IHexType<X01>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X01 src) => HexKind8.x01;

        [MethodImpl(Inline)]
        public static implicit operator byte(X01 src) => 0x01;

        public HexKind8 Value => HexKind8.x01;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X02 : IHexType<X02>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X02 src) => HexKind8.x02;

        [MethodImpl(Inline)]
        public static implicit operator byte(X02 src) => 0x02;

        public HexKind8 Value => HexKind8.x02;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X03 : IHexType<X03>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X03 src) => HexKind8.x03;

        [MethodImpl(Inline)]
        public static implicit operator byte(X03 src) => 0x03;

        public HexKind8 Value => HexKind8.x03;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X04 : IHexType<X04>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X04 src) => HexKind8.x04;

        [MethodImpl(Inline)]
        public static implicit operator byte(X04 src) => 0x04;

        public HexKind8 Value => HexKind8.x04;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X05 : IHexType<X05>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X05 src) => HexKind8.x05;

        [MethodImpl(Inline)]
        public static implicit operator byte(X05 src) => 0x05;

        public HexKind8 Value => HexKind8.x05;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X06 : IHexType<X06>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X06 src) => HexKind8.x06;

        [MethodImpl(Inline)]
        public static implicit operator byte(X06 src) => 0x06;

        public HexKind8 Value => HexKind8.x06;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X07 : IHexType<X07>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X07 src) => HexKind8.x07;

        [MethodImpl(Inline)]
        public static implicit operator byte(X07 src) => 0x07;

        public HexKind8 Value => HexKind8.x07;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X08 : IHexType<X08>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X08 src) => HexKind8.x08;

        [MethodImpl(Inline)]
        public static implicit operator byte(X08 src) => 0x08;

        public HexKind8 Value => HexKind8.x08;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X09 : IHexType<X09>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X09 src) => HexKind8.x09;

        [MethodImpl(Inline)]
        public static implicit operator byte(X09 src) => 0x09;

        public HexKind8 Value => HexKind8.x09;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X0A : IHexType<X0A>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X0A src) => HexKind8.x0a;

        [MethodImpl(Inline)]
        public static implicit operator byte(X0A src) => 0x0a;

        public HexKind8 Value => HexKind8.x0a;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X0B : IHexType<X0B>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X0B src) => HexKind8.x0b;

        [MethodImpl(Inline)]
        public static implicit operator byte(X0B src) => 0x0b;

        public HexKind8 Value => HexKind8.x0b;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X0C : IHexType<X0C>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X0C src) => HexKind8.x0c;

        [MethodImpl(Inline)]
        public static implicit operator byte(X0C src) => 0x0c;

        public HexKind8 Value => HexKind8.x0c;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X0D : IHexType<X0D>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X0D src) => HexKind8.x0d;

        [MethodImpl(Inline)]
        public static implicit operator byte(X0D src) => 0x0d;

        public HexKind8 Value => HexKind8.x0d;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X0E : IHexType<X0E>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X0E src) => HexKind8.x0e;

        [MethodImpl(Inline)]
        public static implicit operator byte(X0E src) => 0x0e;

        public HexKind8 Value => HexKind8.x0e;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X0F : IHexType<X0F>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X0F src) => HexKind8.x0f;

        [MethodImpl(Inline)]
        public static implicit operator byte(X0F src) => 0x0f;

        public HexKind8 Value => HexKind8.x0f;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X10 : IHexType<X10>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X10 src) => HexKind8.x10;

        [MethodImpl(Inline)]
        public static implicit operator byte(X10 src) => 0x10;

        public HexKind8 Value => HexKind8.x10;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X11 : IHexType<X11>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X11 src) => HexKind8.x11;

        [MethodImpl(Inline)]
        public static implicit operator byte(X11 src) => 0x11;

        public HexKind8 Value => HexKind8.x11;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X12 : IHexType<X12>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X12 src) => HexKind8.x12;

        [MethodImpl(Inline)]
        public static implicit operator byte(X12 src) => 0x12;

        public HexKind8 Value => HexKind8.x12;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X13 : IHexType<X13>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X13 src) => HexKind8.x13;

        [MethodImpl(Inline)]
        public static implicit operator byte(X13 src) => 0x13;

        public HexKind8 Value => HexKind8.x13;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X14 : IHexType<X14>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X14 src) => HexKind8.x14;

        [MethodImpl(Inline)]
        public static implicit operator byte(X14 src) => 0x14;

        public HexKind8 Value => HexKind8.x14;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X15 : IHexType<X15>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X15 src) => HexKind8.x15;

        [MethodImpl(Inline)]
        public static implicit operator byte(X15 src) => 0x15;

        public HexKind8 Value => HexKind8.x15;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X16 : IHexType<X16>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X16 src) => HexKind8.x16;

        [MethodImpl(Inline)]
        public static implicit operator byte(X16 src) => 0x16;

        public HexKind8 Value => HexKind8.x16;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X17 : IHexType<X17>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X17 src) => HexKind8.x17;

        [MethodImpl(Inline)]
        public static implicit operator byte(X17 src) => 0x17;

        public HexKind8 Value => HexKind8.x17;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X18 : IHexType<X18>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X18 src) => HexKind8.x18;

        [MethodImpl(Inline)]
        public static implicit operator byte(X18 src) => 0x18;

        public HexKind8 Value => HexKind8.x18;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X19 : IHexType<X19>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X19 src) => HexKind8.x19;

        [MethodImpl(Inline)]
        public static implicit operator byte(X19 src) => 0x19;

        public HexKind8 Value => HexKind8.x19;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X1A : IHexType<X1A>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X1A src) => HexKind8.x1a;

        [MethodImpl(Inline)]
        public static implicit operator byte(X1A src) => 0x1a;

        public HexKind8 Value => HexKind8.x1a;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X1B : IHexType<X1B>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X1B src) => HexKind8.x1b;

        [MethodImpl(Inline)]
        public static implicit operator byte(X1B src) => 0x1b;

        public HexKind8 Value => HexKind8.x1b;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X1C : IHexType<X1C>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X1C src) => HexKind8.x1c;

        [MethodImpl(Inline)]
        public static implicit operator byte(X1C src) => 0x1c;

        public HexKind8 Value => HexKind8.x1c;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X1D : IHexType<X1D>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X1D src) => HexKind8.x1d;

        [MethodImpl(Inline)]
        public static implicit operator byte(X1D src) => 0x1d;

        public HexKind8 Value => HexKind8.x1d;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X1E : IHexType<X1E>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X1E src) => HexKind8.x1e;

        [MethodImpl(Inline)]
        public static implicit operator byte(X1E src) => 0x1e;

        public HexKind8 Value => HexKind8.x1e;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X1F : IHexType<X1F>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X1F src) => HexKind8.x1f;

        [MethodImpl(Inline)]
        public static implicit operator byte(X1F src) => 0x1f;

        public HexKind8 Value => HexKind8.x1f;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X20 : IHexType<X20>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X20 src) => HexKind8.x20;

        [MethodImpl(Inline)]
        public static implicit operator byte(X20 src) => 0x20;

        public HexKind8 Value => HexKind8.x20;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X21 : IHexType<X21>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X21 src) => HexKind8.x21;

        [MethodImpl(Inline)]
        public static implicit operator byte(X21 src) => 0x21;

        public HexKind8 Value => HexKind8.x21;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X22 : IHexType<X22>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X22 src) => HexKind8.x22;

        [MethodImpl(Inline)]
        public static implicit operator byte(X22 src) => 0x22;

        public HexKind8 Value => HexKind8.x22;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X23 : IHexType<X23>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X23 src) => HexKind8.x23;

        [MethodImpl(Inline)]
        public static implicit operator byte(X23 src) => 0x23;

        public HexKind8 Value => HexKind8.x23;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X24 : IHexType<X24>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X24 src) => HexKind8.x24;

        [MethodImpl(Inline)]
        public static implicit operator byte(X24 src) => 0x24;

        public HexKind8 Value => HexKind8.x24;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X25 : IHexType<X25>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X25 src) => HexKind8.x25;

        [MethodImpl(Inline)]
        public static implicit operator byte(X25 src) => 0x25;

        public HexKind8 Value => HexKind8.x25;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X26 : IHexType<X26>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X26 src) => HexKind8.x26;

        [MethodImpl(Inline)]
        public static implicit operator byte(X26 src) => 0x26;

        public HexKind8 Value => HexKind8.x26;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X27 : IHexType<X27>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X27 src) => HexKind8.x27;

        [MethodImpl(Inline)]
        public static implicit operator byte(X27 src) => 0x27;

        public HexKind8 Value => HexKind8.x27;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X28 : IHexType<X28>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X28 src) => HexKind8.x28;

        [MethodImpl(Inline)]
        public static implicit operator byte(X28 src) => 0x28;

        public HexKind8 Value => HexKind8.x28;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X29 : IHexType<X29>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X29 src) => HexKind8.x29;

        [MethodImpl(Inline)]
        public static implicit operator byte(X29 src) => 0x29;

        public HexKind8 Value => HexKind8.x29;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X2A : IHexType<X2A>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X2A src) => HexKind8.x2a;

        [MethodImpl(Inline)]
        public static implicit operator byte(X2A src) => 0x2a;

        public HexKind8 Value => HexKind8.x2a;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X2B : IHexType<X2B>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X2B src) => HexKind8.x2b;

        [MethodImpl(Inline)]
        public static implicit operator byte(X2B src) => 0x2b;

        public HexKind8 Value => HexKind8.x2b;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X2C : IHexType<X2C>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X2C src) => HexKind8.x2c;

        [MethodImpl(Inline)]
        public static implicit operator byte(X2C src) => 0x2c;

        public HexKind8 Value => HexKind8.x2c;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X2D : IHexType<X2D>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X2D src) => HexKind8.x2d;

        [MethodImpl(Inline)]
        public static implicit operator byte(X2D src) => 0x2d;

        public HexKind8 Value => HexKind8.x2d;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X2E : IHexType<X2E>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X2E src) => HexKind8.x2e;

        [MethodImpl(Inline)]
        public static implicit operator byte(X2E src) => 0x2e;

        public HexKind8 Value => HexKind8.x2e;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X2F : IHexType<X2F>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X2F src) => HexKind8.x2f;

        [MethodImpl(Inline)]
        public static implicit operator byte(X2F src) => 0x2f;

        public HexKind8 Value => HexKind8.x2f;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X30 : IHexType<X30>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X30 src) => HexKind8.x30;

        [MethodImpl(Inline)]
        public static implicit operator byte(X30 src) => 0x30;

        public HexKind8 Value => HexKind8.x30;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X31 : IHexType<X31>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X31 src) => HexKind8.x31;

        [MethodImpl(Inline)]
        public static implicit operator byte(X31 src) => 0x31;

        public HexKind8 Value => HexKind8.x31;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X32 : IHexType<X32>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X32 src) => HexKind8.x32;

        [MethodImpl(Inline)]
        public static implicit operator byte(X32 src) => 0x32;

        public HexKind8 Value => HexKind8.x32;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X33 : IHexType<X33>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X33 src) => HexKind8.x33;

        [MethodImpl(Inline)]
        public static implicit operator byte(X33 src) => 0x33;

        public HexKind8 Value => HexKind8.x33;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X34 : IHexType<X34>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X34 src) => HexKind8.x34;

        [MethodImpl(Inline)]
        public static implicit operator byte(X34 src) => 0x34;

        public HexKind8 Value => HexKind8.x34;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X35 : IHexType<X35>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X35 src) => HexKind8.x35;

        [MethodImpl(Inline)]
        public static implicit operator byte(X35 src) => 0x35;

        public HexKind8 Value => HexKind8.x35;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X36 : IHexType<X36>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X36 src) => HexKind8.x36;

        [MethodImpl(Inline)]
        public static implicit operator byte(X36 src) => 0x36;

        public HexKind8 Value => HexKind8.x36;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X37 : IHexType<X37>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X37 src) => HexKind8.x37;

        [MethodImpl(Inline)]
        public static implicit operator byte(X37 src) => 0x37;

        public HexKind8 Value => HexKind8.x37;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X38 : IHexType<X38>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X38 src) => HexKind8.x38;

        [MethodImpl(Inline)]
        public static implicit operator byte(X38 src) => 0x38;

        public HexKind8 Value => HexKind8.x38;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X39 : IHexType<X39>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X39 src) => HexKind8.x39;

        [MethodImpl(Inline)]
        public static implicit operator byte(X39 src) => 0x39;

        public HexKind8 Value => HexKind8.x39;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X3A : IHexType<X3A>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X3A src) => HexKind8.x3a;

        [MethodImpl(Inline)]
        public static implicit operator byte(X3A src) => 0x3a;

        public HexKind8 Value => HexKind8.x3a;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X3B : IHexType<X3B>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X3B src) => HexKind8.x3b;

        [MethodImpl(Inline)]
        public static implicit operator byte(X3B src) => 0x3b;

        public HexKind8 Value => HexKind8.x3b;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X3C : IHexType<X3C>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X3C src) => HexKind8.x3c;

        [MethodImpl(Inline)]
        public static implicit operator byte(X3C src) => 0x3c;

        public HexKind8 Value => HexKind8.x3c;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X3D : IHexType<X3D>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X3D src) => HexKind8.x3d;

        [MethodImpl(Inline)]
        public static implicit operator byte(X3D src) => 0x3d;

        public HexKind8 Value => HexKind8.x3d;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X3E : IHexType<X3E>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X3E src) => HexKind8.x3e;

        [MethodImpl(Inline)]
        public static implicit operator byte(X3E src) => 0x3e;

        public HexKind8 Value => HexKind8.x3e;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X3F : IHexType<X3F>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X3F src) => HexKind8.x3f;

        [MethodImpl(Inline)]
        public static implicit operator byte(X3F src) => 0x3f;

        public HexKind8 Value => HexKind8.x3f;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X40 : IHexType<X40>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X40 src) => HexKind8.x40;

        [MethodImpl(Inline)]
        public static implicit operator byte(X40 src) => 0x40;

        public HexKind8 Value => HexKind8.x40;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X41 : IHexType<X41>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X41 src) => HexKind8.x41;

        [MethodImpl(Inline)]
        public static implicit operator byte(X41 src) => 0x41;

        public HexKind8 Value => HexKind8.x41;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X42 : IHexType<X42>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X42 src) => HexKind8.x42;

        [MethodImpl(Inline)]
        public static implicit operator byte(X42 src) => 0x42;

        public HexKind8 Value => HexKind8.x42;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X43 : IHexType<X43>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X43 src) => HexKind8.x43;

        [MethodImpl(Inline)]
        public static implicit operator byte(X43 src) => 0x43;

        public HexKind8 Value => HexKind8.x43;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X44 : IHexType<X44>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X44 src) => HexKind8.x44;

        [MethodImpl(Inline)]
        public static implicit operator byte(X44 src) => 0x44;

        public HexKind8 Value => HexKind8.x44;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X45 : IHexType<X45>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X45 src) => HexKind8.x45;

        [MethodImpl(Inline)]
        public static implicit operator byte(X45 src) => 0x45;

        public HexKind8 Value => HexKind8.x45;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X46 : IHexType<X46>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X46 src) => HexKind8.x46;

        [MethodImpl(Inline)]
        public static implicit operator byte(X46 src) => 0x46;

        public HexKind8 Value => HexKind8.x46;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X47 : IHexType<X47>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X47 src) => HexKind8.x47;

        [MethodImpl(Inline)]
        public static implicit operator byte(X47 src) => 0x47;

        public HexKind8 Value => HexKind8.x47;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X48 : IHexType<X48>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X48 src) => HexKind8.x48;

        [MethodImpl(Inline)]
        public static implicit operator byte(X48 src) => 0x48;

        public HexKind8 Value => HexKind8.x48;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X49 : IHexType<X49>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X49 src) => HexKind8.x49;

        [MethodImpl(Inline)]
        public static implicit operator byte(X49 src) => 0x49;

        public HexKind8 Value => HexKind8.x49;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X4A : IHexType<X4A>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X4A src) => HexKind8.x4a;

        [MethodImpl(Inline)]
        public static implicit operator byte(X4A src) => 0x4a;

        public HexKind8 Value => HexKind8.x4a;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X4B : IHexType<X4B>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X4B src) => HexKind8.x4b;

        [MethodImpl(Inline)]
        public static implicit operator byte(X4B src) => 0x4b;

        public HexKind8 Value => HexKind8.x4b;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X4C : IHexType<X4C>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X4C src) => HexKind8.x4c;

        [MethodImpl(Inline)]
        public static implicit operator byte(X4C src) => 0x4c;

        public HexKind8 Value => HexKind8.x4c;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X4D : IHexType<X4D>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X4D src) => HexKind8.x4d;

        [MethodImpl(Inline)]
        public static implicit operator byte(X4D src) => 0x4d;

        public HexKind8 Value => HexKind8.x4d;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X4E : IHexType<X4E>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X4E src) => HexKind8.x4e;

        [MethodImpl(Inline)]
        public static implicit operator byte(X4E src) => 0x4e;

        public HexKind8 Value => HexKind8.x4e;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X4F : IHexType<X4F>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X4F src) => HexKind8.x4f;

        [MethodImpl(Inline)]
        public static implicit operator byte(X4F src) => 0x4f;

        public HexKind8 Value => HexKind8.x4f;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X50 : IHexType<X50>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X50 src) => HexKind8.x50;

        [MethodImpl(Inline)]
        public static implicit operator byte(X50 src) => 0x50;

        public HexKind8 Value => HexKind8.x50;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X51 : IHexType<X51>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X51 src) => HexKind8.x51;

        [MethodImpl(Inline)]
        public static implicit operator byte(X51 src) => 0x51;

        public HexKind8 Value => HexKind8.x51;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X52 : IHexType<X52>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X52 src) => HexKind8.x52;

        [MethodImpl(Inline)]
        public static implicit operator byte(X52 src) => 0x52;

        public HexKind8 Value => HexKind8.x52;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X53 : IHexType<X53>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X53 src) => HexKind8.x53;

        [MethodImpl(Inline)]
        public static implicit operator byte(X53 src) => 0x53;

        public HexKind8 Value => HexKind8.x53;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X54 : IHexType<X54>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X54 src) => HexKind8.x54;

        [MethodImpl(Inline)]
        public static implicit operator byte(X54 src) => 0x54;

        public HexKind8 Value => HexKind8.x54;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X55 : IHexType<X55>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X55 src) => HexKind8.x55;

        [MethodImpl(Inline)]
        public static implicit operator byte(X55 src) => 0x55;

        public HexKind8 Value => HexKind8.x55;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X56 : IHexType<X56>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X56 src) => HexKind8.x56;

        [MethodImpl(Inline)]
        public static implicit operator byte(X56 src) => 0x56;

        public HexKind8 Value => HexKind8.x56;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X57 : IHexType<X57>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X57 src) => HexKind8.x57;

        [MethodImpl(Inline)]
        public static implicit operator byte(X57 src) => 0x57;

        public HexKind8 Value => HexKind8.x57;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X58 : IHexType<X58>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X58 src) => HexKind8.x58;

        [MethodImpl(Inline)]
        public static implicit operator byte(X58 src) => 0x58;

        public HexKind8 Value => HexKind8.x58;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X59 : IHexType<X59>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X59 src) => HexKind8.x59;

        [MethodImpl(Inline)]
        public static implicit operator byte(X59 src) => 0x59;

        public HexKind8 Value => HexKind8.x59;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X5A : IHexType<X5A>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X5A src) => HexKind8.x5a;

        [MethodImpl(Inline)]
        public static implicit operator byte(X5A src) => 0x5a;

        public HexKind8 Value => HexKind8.x5a;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X5B : IHexType<X5B>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X5B src) => HexKind8.x5b;

        [MethodImpl(Inline)]
        public static implicit operator byte(X5B src) => 0x5b;

        public HexKind8 Value => HexKind8.x5b;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X5C : IHexType<X5C>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X5C src) => HexKind8.x5c;

        [MethodImpl(Inline)]
        public static implicit operator byte(X5C src) => 0x5c;

        public HexKind8 Value => HexKind8.x5c;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X5D : IHexType<X5D>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X5D src) => HexKind8.x5d;

        [MethodImpl(Inline)]
        public static implicit operator byte(X5D src) => 0x5d;

        public HexKind8 Value => HexKind8.x5d;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X5E : IHexType<X5E>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X5E src) => HexKind8.x5e;

        [MethodImpl(Inline)]
        public static implicit operator byte(X5E src) => 0x5e;

        public HexKind8 Value => HexKind8.x5e;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X5F : IHexType<X5F>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X5F src) => HexKind8.x5f;

        [MethodImpl(Inline)]
        public static implicit operator byte(X5F src) => 0x5f;

        public HexKind8 Value => HexKind8.x5f;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X60 : IHexType<X60>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X60 src) => HexKind8.x60;

        [MethodImpl(Inline)]
        public static implicit operator byte(X60 src) => 0x60;

        public HexKind8 Value => HexKind8.x60;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X61 : IHexType<X61>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X61 src) => HexKind8.x61;

        [MethodImpl(Inline)]
        public static implicit operator byte(X61 src) => 0x61;

        public HexKind8 Value => HexKind8.x61;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X62 : IHexType<X62>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X62 src) => HexKind8.x62;

        [MethodImpl(Inline)]
        public static implicit operator byte(X62 src) => 0x62;

        public HexKind8 Value => HexKind8.x62;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X63 : IHexType<X63>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X63 src) => HexKind8.x63;

        [MethodImpl(Inline)]
        public static implicit operator byte(X63 src) => 0x63;

        public HexKind8 Value => HexKind8.x63;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X64 : IHexType<X64>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X64 src) => HexKind8.x64;

        [MethodImpl(Inline)]
        public static implicit operator byte(X64 src) => 0x64;

        public HexKind8 Value => HexKind8.x64;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X65 : IHexType<X65>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X65 src) => HexKind8.x65;

        [MethodImpl(Inline)]
        public static implicit operator byte(X65 src) => 0x65;

        public HexKind8 Value => HexKind8.x65;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X66 : IHexType<X66>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X66 src) => HexKind8.x66;

        [MethodImpl(Inline)]
        public static implicit operator byte(X66 src) => 0x66;

        public HexKind8 Value => HexKind8.x66;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X67 : IHexType<X67>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X67 src) => HexKind8.x67;

        [MethodImpl(Inline)]
        public static implicit operator byte(X67 src) => 0x67;

        public HexKind8 Value => HexKind8.x67;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X68 : IHexType<X68>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X68 src) => HexKind8.x68;

        [MethodImpl(Inline)]
        public static implicit operator byte(X68 src) => 0x68;

        public HexKind8 Value => HexKind8.x68;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X69 : IHexType<X69>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X69 src) => HexKind8.x69;

        [MethodImpl(Inline)]
        public static implicit operator byte(X69 src) => 0x69;

        public HexKind8 Value => HexKind8.x69;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X6A : IHexType<X6A>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X6A src) => HexKind8.x6a;

        [MethodImpl(Inline)]
        public static implicit operator byte(X6A src) => 0x6a;

        public HexKind8 Value => HexKind8.x6a;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X6B : IHexType<X6B>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X6B src) => HexKind8.x6b;

        [MethodImpl(Inline)]
        public static implicit operator byte(X6B src) => 0x6b;

        public HexKind8 Value => HexKind8.x6b;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X6C : IHexType<X6C>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X6C src) => HexKind8.x6c;

        [MethodImpl(Inline)]
        public static implicit operator byte(X6C src) => 0x6c;

        public HexKind8 Value => HexKind8.x6c;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X6D : IHexType<X6D>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X6D src) => HexKind8.x6d;

        [MethodImpl(Inline)]
        public static implicit operator byte(X6D src) => 0x6d;

        public HexKind8 Value => HexKind8.x6d;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X6E : IHexType<X6E>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X6E src) => HexKind8.x6e;

        [MethodImpl(Inline)]
        public static implicit operator byte(X6E src) => 0x6e;

        public HexKind8 Value => HexKind8.x6e;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X6F : IHexType<X6F>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X6F src) => HexKind8.x6f;

        [MethodImpl(Inline)]
        public static implicit operator byte(X6F src) => 0x6f;

        public HexKind8 Value => HexKind8.x6f;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X70 : IHexType<X70>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X70 src) => HexKind8.x70;

        [MethodImpl(Inline)]
        public static implicit operator byte(X70 src) => 0x70;

        public HexKind8 Value => HexKind8.x70;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X71 : IHexType<X71>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X71 src) => HexKind8.x71;

        [MethodImpl(Inline)]
        public static implicit operator byte(X71 src) => 0x71;

        public HexKind8 Value => HexKind8.x71;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X72 : IHexType<X72>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X72 src) => HexKind8.x72;

        [MethodImpl(Inline)]
        public static implicit operator byte(X72 src) => 0x72;

        public HexKind8 Value => HexKind8.x72;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X73 : IHexType<X73>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X73 src) => HexKind8.x73;

        [MethodImpl(Inline)]
        public static implicit operator byte(X73 src) => 0x73;

        public HexKind8 Value => HexKind8.x73;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X74 : IHexType<X74>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X74 src) => HexKind8.x74;

        [MethodImpl(Inline)]
        public static implicit operator byte(X74 src) => 0x74;

        public HexKind8 Value => HexKind8.x74;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X75 : IHexType<X75>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X75 src) => HexKind8.x75;

        [MethodImpl(Inline)]
        public static implicit operator byte(X75 src) => 0x75;

        public HexKind8 Value => HexKind8.x75;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X76 : IHexType<X76>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X76 src) => HexKind8.x76;

        [MethodImpl(Inline)]
        public static implicit operator byte(X76 src) => 0x76;

        public HexKind8 Value => HexKind8.x76;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X77 : IHexType<X77>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X77 src) => HexKind8.x77;

        [MethodImpl(Inline)]
        public static implicit operator byte(X77 src) => 0x77;

        public HexKind8 Value => HexKind8.x77;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X78 : IHexType<X78>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X78 src) => HexKind8.x78;

        [MethodImpl(Inline)]
        public static implicit operator byte(X78 src) => 0x78;

        public HexKind8 Value => HexKind8.x78;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X79 : IHexType<X79>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X79 src) => HexKind8.x79;

        [MethodImpl(Inline)]
        public static implicit operator byte(X79 src) => 0x79;

        public HexKind8 Value => HexKind8.x79;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X7A : IHexType<X7A>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X7A src) => HexKind8.x7a;

        [MethodImpl(Inline)]
        public static implicit operator byte(X7A src) => 0x7a;

        public HexKind8 Value => HexKind8.x7a;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X7B : IHexType<X7B>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X7B src) => HexKind8.x7b;

        [MethodImpl(Inline)]
        public static implicit operator byte(X7B src) => 0x7b;

        public HexKind8 Value => HexKind8.x7b;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X7C : IHexType<X7C>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X7C src) => HexKind8.x7c;

        [MethodImpl(Inline)]
        public static implicit operator byte(X7C src) => 0x7c;

        public HexKind8 Value => HexKind8.x7c;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X7D : IHexType<X7D>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X7D src) => HexKind8.x7d;

        [MethodImpl(Inline)]
        public static implicit operator byte(X7D src) => 0x7d;

        public HexKind8 Value => HexKind8.x7d;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X7E : IHexType<X7E>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X7E src) => HexKind8.x7e;

        [MethodImpl(Inline)]
        public static implicit operator byte(X7E src) => 0x7e;

        public HexKind8 Value => HexKind8.x7e;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X7F : IHexType<X7F>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X7F src) => HexKind8.x7f;

        [MethodImpl(Inline)]
        public static implicit operator byte(X7F src) => 0x7f;

        public HexKind8 Value => HexKind8.x7f;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X80 : IHexType<X80>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X80 src) => HexKind8.x80;

        [MethodImpl(Inline)]
        public static implicit operator byte(X80 src) => 0x80;

        public HexKind8 Value => HexKind8.x80;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X81 : IHexType<X81>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X81 src) => HexKind8.x81;

        [MethodImpl(Inline)]
        public static implicit operator byte(X81 src) => 0x81;

        public HexKind8 Value => HexKind8.x81;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X82 : IHexType<X82>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X82 src) => HexKind8.x82;

        [MethodImpl(Inline)]
        public static implicit operator byte(X82 src) => 0x82;

        public HexKind8 Value => HexKind8.x82;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X83 : IHexType<X83>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X83 src) => HexKind8.x83;

        [MethodImpl(Inline)]
        public static implicit operator byte(X83 src) => 0x83;

        public HexKind8 Value => HexKind8.x83;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X84 : IHexType<X84>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X84 src) => HexKind8.x84;

        [MethodImpl(Inline)]
        public static implicit operator byte(X84 src) => 0x84;

        public HexKind8 Value => HexKind8.x84;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X85 : IHexType<X85>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X85 src) => HexKind8.x85;

        [MethodImpl(Inline)]
        public static implicit operator byte(X85 src) => 0x85;

        public HexKind8 Value => HexKind8.x85;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X86 : IHexType<X86>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X86 src) => HexKind8.x86;

        [MethodImpl(Inline)]
        public static implicit operator byte(X86 src) => 0x86;

        public HexKind8 Value => HexKind8.x86;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X87 : IHexType<X87>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X87 src) => HexKind8.x87;

        [MethodImpl(Inline)]
        public static implicit operator byte(X87 src) => 0x87;

        public HexKind8 Value => HexKind8.x87;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X88 : IHexType<X88>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X88 src) => HexKind8.x88;

        [MethodImpl(Inline)]
        public static implicit operator byte(X88 src) => 0x88;

        public HexKind8 Value => HexKind8.x88;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X89 : IHexType<X89>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X89 src) => HexKind8.x89;

        [MethodImpl(Inline)]
        public static implicit operator byte(X89 src) => 0x89;

        public HexKind8 Value => HexKind8.x89;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X8A : IHexType<X8A>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X8A src) => HexKind8.x8a;

        [MethodImpl(Inline)]
        public static implicit operator byte(X8A src) => 0x8a;

        public HexKind8 Value => HexKind8.x8a;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X8B : IHexType<X8B>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X8B src) => HexKind8.x8b;

        [MethodImpl(Inline)]
        public static implicit operator byte(X8B src) => 0x8b;

        public HexKind8 Value => HexKind8.x8b;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X8C : IHexType<X8C>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X8C src) => HexKind8.x8c;

        [MethodImpl(Inline)]
        public static implicit operator byte(X8C src) => 0x8c;

        public HexKind8 Value => HexKind8.x8c;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X8D : IHexType<X8D>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X8D src) => HexKind8.x8d;

        [MethodImpl(Inline)]
        public static implicit operator byte(X8D src) => 0x8d;

        public HexKind8 Value => HexKind8.x8d;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X8E : IHexType<X8E>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X8E src) => HexKind8.x8e;

        [MethodImpl(Inline)]
        public static implicit operator byte(X8E src) => 0x8e;

        public HexKind8 Value => HexKind8.x8e;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X8F : IHexType<X8F>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X8F src) => HexKind8.x8f;

        [MethodImpl(Inline)]
        public static implicit operator byte(X8F src) => 0x8f;

        public HexKind8 Value => HexKind8.x8f;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X90 : IHexType<X90>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X90 src) => HexKind8.x90;

        [MethodImpl(Inline)]
        public static implicit operator byte(X90 src) => 0x90;

        public HexKind8 Value => HexKind8.x90;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X91 : IHexType<X91>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X91 src) => HexKind8.x91;

        [MethodImpl(Inline)]
        public static implicit operator byte(X91 src) => 0x91;

        public HexKind8 Value => HexKind8.x91;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X92 : IHexType<X92>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X92 src) => HexKind8.x92;

        [MethodImpl(Inline)]
        public static implicit operator byte(X92 src) => 0x92;

        public HexKind8 Value => HexKind8.x92;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X93 : IHexType<X93>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X93 src) => HexKind8.x93;

        [MethodImpl(Inline)]
        public static implicit operator byte(X93 src) => 0x93;

        public HexKind8 Value => HexKind8.x93;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X94 : IHexType<X94>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X94 src) => HexKind8.x94;

        [MethodImpl(Inline)]
        public static implicit operator byte(X94 src) => 0x94;

        public HexKind8 Value => HexKind8.x94;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X95 : IHexType<X95>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X95 src) => HexKind8.x95;

        [MethodImpl(Inline)]
        public static implicit operator byte(X95 src) => 0x95;

        public HexKind8 Value => HexKind8.x95;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X96 : IHexType<X96>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X96 src) => HexKind8.x96;

        [MethodImpl(Inline)]
        public static implicit operator byte(X96 src) => 0x96;

        public HexKind8 Value => HexKind8.x96;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X97 : IHexType<X97>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X97 src) => HexKind8.x97;

        [MethodImpl(Inline)]
        public static implicit operator byte(X97 src) => 0x97;

        public HexKind8 Value => HexKind8.x97;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X98 : IHexType<X98>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X98 src) => HexKind8.x98;

        [MethodImpl(Inline)]
        public static implicit operator byte(X98 src) => 0x98;

        public HexKind8 Value => HexKind8.x98;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X99 : IHexType<X99>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X99 src) => HexKind8.x99;

        [MethodImpl(Inline)]
        public static implicit operator byte(X99 src) => 0x99;

        public HexKind8 Value => HexKind8.x99;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X9A : IHexType<X9A>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X9A src) => HexKind8.x9a;

        [MethodImpl(Inline)]
        public static implicit operator byte(X9A src) => 0x9a;

        public HexKind8 Value => HexKind8.x9a;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X9B : IHexType<X9B>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X9B src) => HexKind8.x9b;

        [MethodImpl(Inline)]
        public static implicit operator byte(X9B src) => 0x9b;

        public HexKind8 Value => HexKind8.x9b;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X9C : IHexType<X9C>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X9C src) => HexKind8.x9c;

        [MethodImpl(Inline)]
        public static implicit operator byte(X9C src) => 0x9c;

        public HexKind8 Value => HexKind8.x9c;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X9D : IHexType<X9D>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X9D src) => HexKind8.x9d;

        [MethodImpl(Inline)]
        public static implicit operator byte(X9D src) => 0x9d;

        public HexKind8 Value => HexKind8.x9d;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X9E : IHexType<X9E>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X9E src) => HexKind8.x9e;

        [MethodImpl(Inline)]
        public static implicit operator byte(X9E src) => 0x9e;

        public HexKind8 Value => HexKind8.x9e;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct X9F : IHexType<X9F>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(X9F src) => HexKind8.x9f;

        [MethodImpl(Inline)]
        public static implicit operator byte(X9F src) => 0x9f;

        public HexKind8 Value => HexKind8.x9f;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XA0 : IHexType<XA0>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XA0 src) => HexKind8.xa0;

        [MethodImpl(Inline)]
        public static implicit operator byte(XA0 src) => 0xa0;

        public HexKind8 Value => HexKind8.xa0;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XA1 : IHexType<XA1>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XA1 src) => HexKind8.xa1;

        [MethodImpl(Inline)]
        public static implicit operator byte(XA1 src) => 0xa1;

        public HexKind8 Value => HexKind8.xa1;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XA2 : IHexType<XA2>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XA2 src) => HexKind8.xa2;

        [MethodImpl(Inline)]
        public static implicit operator byte(XA2 src) => 0xa2;

        public HexKind8 Value => HexKind8.xa2;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XA3 : IHexType<XA3>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XA3 src) => HexKind8.xa3;

        [MethodImpl(Inline)]
        public static implicit operator byte(XA3 src) => 0xa3;

        public HexKind8 Value => HexKind8.xa3;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XA4 : IHexType<XA4>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XA4 src) => HexKind8.xa4;

        [MethodImpl(Inline)]
        public static implicit operator byte(XA4 src) => 0xa4;

        public HexKind8 Value => HexKind8.xa4;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XA5 : IHexType<XA5>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XA5 src) => HexKind8.xa5;

        [MethodImpl(Inline)]
        public static implicit operator byte(XA5 src) => 0xa5;

        public HexKind8 Value => HexKind8.xa5;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XA6 : IHexType<XA6>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XA6 src) => HexKind8.xa6;

        [MethodImpl(Inline)]
        public static implicit operator byte(XA6 src) => 0xa6;

        public HexKind8 Value => HexKind8.xa6;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XA7 : IHexType<XA7>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XA7 src) => HexKind8.xa7;

        [MethodImpl(Inline)]
        public static implicit operator byte(XA7 src) => 0xa7;

        public HexKind8 Value => HexKind8.xa7;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XA8 : IHexType<XA8>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XA8 src) => HexKind8.xa8;

        [MethodImpl(Inline)]
        public static implicit operator byte(XA8 src) => 0xa8;

        public HexKind8 Value => HexKind8.xa8;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XA9 : IHexType<XA9>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XA9 src) => HexKind8.xa9;

        [MethodImpl(Inline)]
        public static implicit operator byte(XA9 src) => 0xa9;

        public HexKind8 Value => HexKind8.xa9;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XAA : IHexType<XAA>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XAA src) => HexKind8.xaa;

        [MethodImpl(Inline)]
        public static implicit operator byte(XAA src) => 0xaa;

        public HexKind8 Value => HexKind8.xaa;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XAB : IHexType<XAB>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XAB src) => HexKind8.xab;

        [MethodImpl(Inline)]
        public static implicit operator byte(XAB src) => 0xab;

        public HexKind8 Value => HexKind8.xab;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XAC : IHexType<XAC>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XAC src) => HexKind8.xac;

        [MethodImpl(Inline)]
        public static implicit operator byte(XAC src) => 0xac;

        public HexKind8 Value => HexKind8.xac;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XAD : IHexType<XAD>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XAD src) => HexKind8.xad;

        [MethodImpl(Inline)]
        public static implicit operator byte(XAD src) => 0xad;

        public HexKind8 Value => HexKind8.xad;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XAE : IHexType<XAE>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XAE src) => HexKind8.xae;

        [MethodImpl(Inline)]
        public static implicit operator byte(XAE src) => 0xae;

        public HexKind8 Value => HexKind8.xae;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XAF : IHexType<XAF>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XAF src) => HexKind8.xaf;

        [MethodImpl(Inline)]
        public static implicit operator byte(XAF src) => 0xaf;

        public HexKind8 Value => HexKind8.xaf;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XB0 : IHexType<XB0>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XB0 src) => HexKind8.xb0;

        [MethodImpl(Inline)]
        public static implicit operator byte(XB0 src) => 0xb0;

        public HexKind8 Value => HexKind8.xb0;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XB1 : IHexType<XB1>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XB1 src) => HexKind8.xb1;

        [MethodImpl(Inline)]
        public static implicit operator byte(XB1 src) => 0xb1;

        public HexKind8 Value => HexKind8.xb1;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XB2 : IHexType<XB2>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XB2 src) => HexKind8.xb2;

        [MethodImpl(Inline)]
        public static implicit operator byte(XB2 src) => 0xb2;

        public HexKind8 Value => HexKind8.xb2;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XB3 : IHexType<XB3>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XB3 src) => HexKind8.xb3;

        [MethodImpl(Inline)]
        public static implicit operator byte(XB3 src) => 0xb3;

        public HexKind8 Value => HexKind8.xb3;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XB4 : IHexType<XB4>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XB4 src) => HexKind8.xb4;

        [MethodImpl(Inline)]
        public static implicit operator byte(XB4 src) => 0xb4;

        public HexKind8 Value => HexKind8.xb4;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XB5 : IHexType<XB5>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XB5 src) => HexKind8.xb5;

        [MethodImpl(Inline)]
        public static implicit operator byte(XB5 src) => 0xb5;

        public HexKind8 Value => HexKind8.xb5;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XB6 : IHexType<XB6>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XB6 src) => HexKind8.xb6;

        [MethodImpl(Inline)]
        public static implicit operator byte(XB6 src) => 0xb6;

        public HexKind8 Value => HexKind8.xb6;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XB7 : IHexType<XB7>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XB7 src) => HexKind8.xb7;

        [MethodImpl(Inline)]
        public static implicit operator byte(XB7 src) => 0xb7;

        public HexKind8 Value => HexKind8.xb7;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XB8 : IHexType<XB8>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XB8 src) => HexKind8.xb8;

        [MethodImpl(Inline)]
        public static implicit operator byte(XB8 src) => 0xb8;

        public HexKind8 Value => HexKind8.xb8;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XB9 : IHexType<XB9>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XB9 src) => HexKind8.xb9;

        [MethodImpl(Inline)]
        public static implicit operator byte(XB9 src) => 0xb9;

        public HexKind8 Value => HexKind8.xb9;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XBA : IHexType<XBA>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XBA src) => HexKind8.xba;

        [MethodImpl(Inline)]
        public static implicit operator byte(XBA src) => 0xba;

        public HexKind8 Value => HexKind8.xba;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XBB : IHexType<XBB>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XBB src) => HexKind8.xbb;

        [MethodImpl(Inline)]
        public static implicit operator byte(XBB src) => 0xbb;

        public HexKind8 Value => HexKind8.xbb;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XBC : IHexType<XBC>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XBC src) => HexKind8.xbc;

        [MethodImpl(Inline)]
        public static implicit operator byte(XBC src) => 0xbc;

        public HexKind8 Value => HexKind8.xbc;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XBD : IHexType<XBD>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XBD src) => HexKind8.xbd;

        [MethodImpl(Inline)]
        public static implicit operator byte(XBD src) => 0xbd;

        public HexKind8 Value => HexKind8.xbd;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XBE : IHexType<XBE>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XBE src) => HexKind8.xbe;

        [MethodImpl(Inline)]
        public static implicit operator byte(XBE src) => 0xbe;

        public HexKind8 Value => HexKind8.xbe;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XBF : IHexType<XBF>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XBF src) => HexKind8.xbf;

        [MethodImpl(Inline)]
        public static implicit operator byte(XBF src) => 0xbf;

        public HexKind8 Value => HexKind8.xbf;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XC0 : IHexType<XC0>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XC0 src) => HexKind8.xc0;

        [MethodImpl(Inline)]
        public static implicit operator byte(XC0 src) => 0xc0;

        public HexKind8 Value => HexKind8.xc0;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XC1 : IHexType<XC1>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XC1 src) => HexKind8.xc1;

        [MethodImpl(Inline)]
        public static implicit operator byte(XC1 src) => 0xc1;

        public HexKind8 Value => HexKind8.xc1;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XC2 : IHexType<XC2>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XC2 src) => HexKind8.xc2;

        [MethodImpl(Inline)]
        public static implicit operator byte(XC2 src) => 0xc2;

        public HexKind8 Value => HexKind8.xc2;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XC3 : IHexType<XC3>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XC3 src) => HexKind8.xc3;

        [MethodImpl(Inline)]
        public static implicit operator byte(XC3 src) => 0xc3;

        public HexKind8 Value => HexKind8.xc3;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XC4 : IHexType<XC4>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XC4 src) => HexKind8.xc4;

        [MethodImpl(Inline)]
        public static implicit operator byte(XC4 src) => 0xc4;

        public HexKind8 Value => HexKind8.xc4;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XC5 : IHexType<XC5>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XC5 src) => HexKind8.xc5;

        [MethodImpl(Inline)]
        public static implicit operator byte(XC5 src) => 0xc5;

        public HexKind8 Value => HexKind8.xc5;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XC6 : IHexType<XC6>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XC6 src) => HexKind8.xc6;

        [MethodImpl(Inline)]
        public static implicit operator byte(XC6 src) => 0xc6;

        public HexKind8 Value => HexKind8.xc6;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XC7 : IHexType<XC7>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XC7 src) => HexKind8.xc7;

        [MethodImpl(Inline)]
        public static implicit operator byte(XC7 src) => 0xc7;

        public HexKind8 Value => HexKind8.xc7;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XC8 : IHexType<XC8>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XC8 src) => HexKind8.xc8;

        [MethodImpl(Inline)]
        public static implicit operator byte(XC8 src) => 0xc8;

        public HexKind8 Value => HexKind8.xc8;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XC9 : IHexType<XC9>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XC9 src) => HexKind8.xc9;

        [MethodImpl(Inline)]
        public static implicit operator byte(XC9 src) => 0xc9;

        public HexKind8 Value => HexKind8.xc9;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XCA : IHexType<XCA>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XCA src) => HexKind8.xca;

        [MethodImpl(Inline)]
        public static implicit operator byte(XCA src) => 0xca;

        public HexKind8 Value => HexKind8.xca;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XCB : IHexType<XCB>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XCB src) => HexKind8.xcb;

        [MethodImpl(Inline)]
        public static implicit operator byte(XCB src) => 0xcb;

        public HexKind8 Value => HexKind8.xcb;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XCC : IHexType<XCC>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XCC src) => HexKind8.xcc;

        [MethodImpl(Inline)]
        public static implicit operator byte(XCC src) => 0xcc;

        public HexKind8 Value => HexKind8.xcc;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XCD : IHexType<XCD>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XCD src) => HexKind8.xcd;

        [MethodImpl(Inline)]
        public static implicit operator byte(XCD src) => 0xcd;

        public HexKind8 Value => HexKind8.xcd;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XCE : IHexType<XCE>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XCE src) => HexKind8.xce;

        [MethodImpl(Inline)]
        public static implicit operator byte(XCE src) => 0xce;

        public HexKind8 Value => HexKind8.xce;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XCF : IHexType<XCF>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XCF src) => HexKind8.xcf;

        [MethodImpl(Inline)]
        public static implicit operator byte(XCF src) => 0xcf;

        public HexKind8 Value => HexKind8.xcf;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XD0 : IHexType<XD0>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XD0 src) => HexKind8.xd0;

        [MethodImpl(Inline)]
        public static implicit operator byte(XD0 src) => 0xd0;

        public HexKind8 Value => HexKind8.xd0;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XD1 : IHexType<XD1>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XD1 src) => HexKind8.xd1;

        [MethodImpl(Inline)]
        public static implicit operator byte(XD1 src) => 0xd1;

        public HexKind8 Value => HexKind8.xd1;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XD2 : IHexType<XD2>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XD2 src) => HexKind8.xd2;

        [MethodImpl(Inline)]
        public static implicit operator byte(XD2 src) => 0xd2;

        public HexKind8 Value => HexKind8.xd2;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XD3 : IHexType<XD3>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XD3 src) => HexKind8.xd3;

        [MethodImpl(Inline)]
        public static implicit operator byte(XD3 src) => 0xd3;

        public HexKind8 Value => HexKind8.xd3;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XD4 : IHexType<XD4>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XD4 src) => HexKind8.xd4;

        [MethodImpl(Inline)]
        public static implicit operator byte(XD4 src) => 0xd4;

        public HexKind8 Value => HexKind8.xd4;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XD5 : IHexType<XD5>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XD5 src) => HexKind8.xd5;

        [MethodImpl(Inline)]
        public static implicit operator byte(XD5 src) => 0xd5;

        public HexKind8 Value => HexKind8.xd5;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XD6 : IHexType<XD6>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XD6 src) => HexKind8.xd6;

        [MethodImpl(Inline)]
        public static implicit operator byte(XD6 src) => 0xd6;

        public HexKind8 Value => HexKind8.xd6;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XD7 : IHexType<XD7>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XD7 src) => HexKind8.xd7;

        [MethodImpl(Inline)]
        public static implicit operator byte(XD7 src) => 0xd7;

        public HexKind8 Value => HexKind8.xd7;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XD8 : IHexType<XD8>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XD8 src) => HexKind8.xd8;

        [MethodImpl(Inline)]
        public static implicit operator byte(XD8 src) => 0xd8;

        public HexKind8 Value => HexKind8.xd8;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XD9 : IHexType<XD9>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XD9 src) => HexKind8.xd9;

        [MethodImpl(Inline)]
        public static implicit operator byte(XD9 src) => 0xd9;

        public HexKind8 Value => HexKind8.xd9;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XDA : IHexType<XDA>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XDA src) => HexKind8.xda;

        [MethodImpl(Inline)]
        public static implicit operator byte(XDA src) => 0xda;

        public HexKind8 Value => HexKind8.xda;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XDB : IHexType<XDB>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XDB src) => HexKind8.xdb;

        [MethodImpl(Inline)]
        public static implicit operator byte(XDB src) => 0xdb;

        public HexKind8 Value => HexKind8.xdb;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XDC : IHexType<XDC>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XDC src) => HexKind8.xdc;

        [MethodImpl(Inline)]
        public static implicit operator byte(XDC src) => 0xdc;

        public HexKind8 Value => HexKind8.xdc;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XDD : IHexType<XDD>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XDD src) => HexKind8.xdd;

        [MethodImpl(Inline)]
        public static implicit operator byte(XDD src) => 0xdd;

        public HexKind8 Value => HexKind8.xdd;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XDE : IHexType<XDE>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XDE src) => HexKind8.xde;

        [MethodImpl(Inline)]
        public static implicit operator byte(XDE src) => 0xde;

        public HexKind8 Value => HexKind8.xde;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XDF : IHexType<XDF>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XDF src) => HexKind8.xdf;

        [MethodImpl(Inline)]
        public static implicit operator byte(XDF src) => 0xdf;

        public HexKind8 Value => HexKind8.xdf;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XE0 : IHexType<XE0>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XE0 src) => HexKind8.xe0;

        [MethodImpl(Inline)]
        public static implicit operator byte(XE0 src) => 0xe0;

        public HexKind8 Value => HexKind8.xe0;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XE1 : IHexType<XE1>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XE1 src) => HexKind8.xe1;

        [MethodImpl(Inline)]
        public static implicit operator byte(XE1 src) => 0xe1;

        public HexKind8 Value => HexKind8.xe1;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XE2 : IHexType<XE2>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XE2 src) => HexKind8.xe2;

        [MethodImpl(Inline)]
        public static implicit operator byte(XE2 src) => 0xe2;

        public HexKind8 Value => HexKind8.xe2;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XE3 : IHexType<XE3>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XE3 src) => HexKind8.xe3;

        [MethodImpl(Inline)]
        public static implicit operator byte(XE3 src) => 0xe3;

        public HexKind8 Value => HexKind8.xe3;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XE4 : IHexType<XE4>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XE4 src) => HexKind8.xe4;

        [MethodImpl(Inline)]
        public static implicit operator byte(XE4 src) => 0xe4;

        public HexKind8 Value => HexKind8.xe4;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XE5 : IHexType<XE5>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XE5 src) => HexKind8.xe5;

        [MethodImpl(Inline)]
        public static implicit operator byte(XE5 src) => 0xe5;

        public HexKind8 Value => HexKind8.xe5;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XE6 : IHexType<XE6>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XE6 src) => HexKind8.xe6;

        [MethodImpl(Inline)]
        public static implicit operator byte(XE6 src) => 0xe6;

        public HexKind8 Value => HexKind8.xe6;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XE7 : IHexType<XE7>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XE7 src) => HexKind8.xe7;

        [MethodImpl(Inline)]
        public static implicit operator byte(XE7 src) => 0xe7;

        public HexKind8 Value => HexKind8.xe7;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XE8 : IHexType<XE8>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XE8 src) => HexKind8.xe8;

        [MethodImpl(Inline)]
        public static implicit operator byte(XE8 src) => 0xe8;

        public HexKind8 Value => HexKind8.xe8;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XE9 : IHexType<XE9>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XE9 src) => HexKind8.xe9;

        [MethodImpl(Inline)]
        public static implicit operator byte(XE9 src) => 0xe9;

        public HexKind8 Value => HexKind8.xe9;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XEA : IHexType<XEA>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XEA src) => HexKind8.xea;

        [MethodImpl(Inline)]
        public static implicit operator byte(XEA src) => 0xea;

        public HexKind8 Value => HexKind8.xea;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XEB : IHexType<XEB>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XEB src) => HexKind8.xeb;

        [MethodImpl(Inline)]
        public static implicit operator byte(XEB src) => 0xeb;

        public HexKind8 Value => HexKind8.xeb;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XEC : IHexType<XEC>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XEC src) => HexKind8.xec;

        [MethodImpl(Inline)]
        public static implicit operator byte(XEC src) => 0xec;

        public HexKind8 Value => HexKind8.xec;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XED : IHexType<XED>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XED src) => HexKind8.xed;

        [MethodImpl(Inline)]
        public static implicit operator byte(XED src) => 0xed;

        public HexKind8 Value => HexKind8.xed;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XEE : IHexType<XEE>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XEE src) => HexKind8.xee;

        [MethodImpl(Inline)]
        public static implicit operator byte(XEE src) => 0xee;

        public HexKind8 Value => HexKind8.xee;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XEF : IHexType<XEF>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XEF src) => HexKind8.xef;

        [MethodImpl(Inline)]
        public static implicit operator byte(XEF src) => 0xef;

        public HexKind8 Value => HexKind8.xef;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XF0 : IHexType<XF0>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XF0 src) => HexKind8.xf0;

        [MethodImpl(Inline)]
        public static implicit operator byte(XF0 src) => 0xf0;

        public HexKind8 Value => HexKind8.xf0;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XF1 : IHexType<XF1>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XF1 src) => HexKind8.xf1;

        [MethodImpl(Inline)]
        public static implicit operator byte(XF1 src) => 0xf1;

        public HexKind8 Value => HexKind8.xf1;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XF2 : IHexType<XF2>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XF2 src) => HexKind8.xf2;

        [MethodImpl(Inline)]
        public static implicit operator byte(XF2 src) => 0xf2;

        public HexKind8 Value => HexKind8.xf2;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XF3 : IHexType<XF3>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XF3 src) => HexKind8.xf3;

        [MethodImpl(Inline)]
        public static implicit operator byte(XF3 src) => 0xf3;

        public HexKind8 Value => HexKind8.xf3;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XF4 : IHexType<XF4>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XF4 src) => HexKind8.xf4;

        [MethodImpl(Inline)]
        public static implicit operator byte(XF4 src) => 0xf4;

        public HexKind8 Value => HexKind8.xf4;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XF5 : IHexType<XF5>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XF5 src) => HexKind8.xf5;

        [MethodImpl(Inline)]
        public static implicit operator byte(XF5 src) => 0xf5;

        public HexKind8 Value => HexKind8.xf5;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XF6 : IHexType<XF6>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XF6 src) => HexKind8.xf6;

        [MethodImpl(Inline)]
        public static implicit operator byte(XF6 src) => 0xf6;

        public HexKind8 Value => HexKind8.xf6;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XF7 : IHexType<XF7>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XF7 src) => HexKind8.xf7;

        [MethodImpl(Inline)]
        public static implicit operator byte(XF7 src) => 0xf7;

        public HexKind8 Value => HexKind8.xf7;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XF8 : IHexType<XF8>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XF8 src) => HexKind8.xf8;

        [MethodImpl(Inline)]
        public static implicit operator byte(XF8 src) => 0xf8;

        public HexKind8 Value => HexKind8.xf8;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XF9 : IHexType<XF9>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XF9 src) => HexKind8.xf9;

        [MethodImpl(Inline)]
        public static implicit operator byte(XF9 src) => 0xf9;

        public HexKind8 Value => HexKind8.xf9;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XFA : IHexType<XFA>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XFA src) => HexKind8.xfa;

        [MethodImpl(Inline)]
        public static implicit operator byte(XFA src) => 0xfa;

        public HexKind8 Value => HexKind8.xfa;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XFB : IHexType<XFB>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XFB src) => HexKind8.xfb;

        [MethodImpl(Inline)]
        public static implicit operator byte(XFB src) => 0xfb;

        public HexKind8 Value => HexKind8.xfb;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XFC : IHexType<XFC>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XFC src) => HexKind8.xfc;

        [MethodImpl(Inline)]
        public static implicit operator byte(XFC src) => 0xfc;

        public HexKind8 Value => HexKind8.xfc;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XFD : IHexType<XFD>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XFD src) => HexKind8.xfd;

        [MethodImpl(Inline)]
        public static implicit operator byte(XFD src) => 0xfd;

        public HexKind8 Value => HexKind8.xfd;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XFE : IHexType<XFE>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XFE src) => HexKind8.xfe;

        [MethodImpl(Inline)]
        public static implicit operator byte(XFE src) => 0xfe;

        public HexKind8 Value => HexKind8.xfe;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }

    public readonly struct XFF : IHexType<XFF>, ITextual
    {
        [MethodImpl(Inline)]
        public static implicit operator HexKind8(XFF src) => HexKind8.xff;

        [MethodImpl(Inline)]
        public static implicit operator byte(XFF src) => 0xff;

        public HexKind8 Value => HexKind8.xff;

        public string Format() => $"{Value}";

        public override string ToString() => Format();
    }
}