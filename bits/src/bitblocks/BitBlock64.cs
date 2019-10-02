//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using System.Threading;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;


    /// <summary>
    /// Represents 64 bits with 64 8-bit values for which the domain is restricted to {0,1}
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size=64)]
    public struct BitBlock64 : IBitBlock
    {
        [MethodImpl(Inline)]
        public static BitBlock64 FromSpan(Span<byte> src)
            => MemoryMarshal.AsRef<BitBlock64>(src);

        [MethodImpl(Inline)]
        public static BitBlock64 Alloc()
            => default;

        /// <summary>
        ///  Bit 0
        /// </summary>
        [FieldOffset(0)]
        public byte Bit0;

        /// <summary>
        ///  Bit 1
        /// </summary>
        [FieldOffset(1)]
        public byte Bit1;

        /// <summary>
        ///  Bit 2
        /// </summary>
        [FieldOffset(2)]
        public byte Bit2;

        /// <summary>
        ///  Bit 2
        /// </summary>
        [FieldOffset(3)]
        public byte Bit3;
        
        /// <summary>
        ///  Bit 4
        /// </summary>
        [FieldOffset(4)]
        public byte Bit4;

        /// <summary>
        ///  Bit 5
        /// </summary>
        [FieldOffset(5)]
        public byte Bit5;

        /// <summary>
        ///  Bit 6
        /// </summary>
        [FieldOffset(6)]
        public byte Bit6;

        /// <summary>
        ///  Bit 7
        /// </summary>
        [FieldOffset(7)]
        public byte Bit7;

        /// <summary>
        ///  Bit 8
        /// </summary>
        [FieldOffset(8)]
        public byte Bit8;

        /// <summary>
        ///  Bit 9
        /// </summary>
        [FieldOffset(9)]
        public byte Bit9;

        /// <summary>
        ///  Bit 10
        /// </summary>
        [FieldOffset(10)]
        public byte Bit10;

        /// <summary>
        ///  Bit 11
        /// </summary>
        [FieldOffset(11)]
        public byte Bit11;

        /// <summary>
        ///  Bit 12
        /// </summary>
        [FieldOffset(12)]
        public byte Bit12;

        /// <summary>
        ///  Bit 13
        /// </summary>
        [FieldOffset(13)]
        public byte Bit13;

        /// <summary>
        ///  Bit 14
        /// </summary>
        [FieldOffset(14)]
        public byte Bit14;

        /// <summary>
        ///  Bit 15
        /// </summary>
        [FieldOffset(15)]
        public byte Bit15;

        /// <summary>
        ///  Bit 16
        /// </summary>
        [FieldOffset(16)]
        public byte Bit16;

        /// <summary>
        ///  Bit 17
        /// </summary>
        [FieldOffset(17)]
        public byte Bit17;

        /// <summary>
        ///  Bit 18
        /// </summary>
        [FieldOffset(18)]
        public byte Bit18;

        /// <summary>
        ///  Bit 19
        /// </summary>
        [FieldOffset(19)]
        public byte Bit19;

        /// <summary>
        ///  Bit 20
        /// </summary>
        [FieldOffset(20)]
        public byte Bit20;

        /// <summary>
        ///  Bit 21
        /// </summary>
        [FieldOffset(21)]
        public byte Bit21;

        /// <summary>
        ///  Bit 22
        /// </summary>
        [FieldOffset(22)]
        public byte Bit22;

        /// <summary>
        ///  Bit 23
        /// </summary>
        [FieldOffset(23)]
        public byte Bit23;

        /// <summary>
        ///  Bit 24
        /// </summary>
        [FieldOffset(24)]
        public byte Bit24;

        /// <summary>
        ///  Bit 25
        /// </summary>
        [FieldOffset(25)]
        public byte Bit25;

        /// <summary>
        ///  Bit 26
        /// </summary>
        [FieldOffset(26)]
        public byte Bit26;

        /// <summary>
        ///  Bit 27
        /// </summary>
        [FieldOffset(27)]
        public byte Bit27;

        /// <summary>
        ///  Bit 28
        /// </summary>
        [FieldOffset(28)]
        public byte Bit28;

        /// <summary>
        ///  Bit 29
        /// </summary>
        [FieldOffset(29)]
        public byte Bit29;

        /// <summary>
        ///  Bit 30
        /// </summary>
        [FieldOffset(30)]
        public byte Bit30;

        /// <summary>
        ///  Bit 31
        /// </summary>
        [FieldOffset(31)]
        public byte Bit31;

       /// <summary>
        ///  Bit 32
        /// </summary>
        [FieldOffset(32)]
        public byte Bit32;

        /// <summary>
        ///  Bit 33
        /// </summary>
        [FieldOffset(33)]
        public byte Bit33;

        /// <summary>
        ///  Bit 34
        /// </summary>
        [FieldOffset(34)]
        public byte Bit34;

        /// <summary>
        ///  Bit 35
        /// </summary>
        [FieldOffset(35)]
        public byte Bit35;
        
        /// <summary>
        ///  Bit 37
        /// </summary>
        [FieldOffset(36)]
        public byte Bit36;

        /// <summary>
        ///  Bit 37
        /// </summary>
        [FieldOffset(37)]
        public byte Bit37;

        /// <summary>
        ///  Bit 38
        /// </summary>
        [FieldOffset(38)]
        public byte Bit38;

        /// <summary>
        ///  Bit 39
        /// </summary>
        [FieldOffset(39)]
        public byte Bit39;

        /// <summary>
        ///  Bit 40
        /// </summary>
        [FieldOffset(40)]
        public byte Bit40;

        /// <summary>
        ///  Bit 41
        /// </summary>
        [FieldOffset(41)]
        public byte Bit41;

        /// <summary>
        ///  Bit 42
        /// </summary>
        [FieldOffset(42)]
        public byte Bit42;

        /// <summary>
        ///  Bit 43
        /// </summary>
        [FieldOffset(43)]
        public byte Bit43;

        /// <summary>
        ///  Bit 44
        /// </summary>
        [FieldOffset(44)]
        public byte Bit44;

        /// <summary>
        ///  Bit 45
        /// </summary>
        [FieldOffset(45)]
        public byte Bit45;

        /// <summary>
        ///  Bit 46
        /// </summary>
        [FieldOffset(46)]
        public byte Bit46;

        /// <summary>
        ///  Bit 47
        /// </summary>
        [FieldOffset(47)]
        public byte Bit47;

        /// <summary>
        ///  Bit 48
        /// </summary>
        [FieldOffset(48)]
        public byte Bit48;

        /// <summary>
        ///  Bit 49
        /// </summary>
        [FieldOffset(49)]
        public byte Bit49;

        /// <summary>
        ///  Bit 50
        /// </summary>
        [FieldOffset(50)]
        public byte Bit50;

        /// <summary>
        ///  Bit 51
        /// </summary>
        [FieldOffset(51)]
        public byte Bit51;

        /// <summary>
        ///  Bit 52
        /// </summary>
        [FieldOffset(52)]
        public byte Bit52;

        /// <summary>
        ///  Bit 53
        /// </summary>
        [FieldOffset(53)]
        public byte Bit53;

        /// <summary>
        ///  Bit 54
        /// </summary>
        [FieldOffset(54)]
        public byte Bit54;

        /// <summary>
        ///  Bit 55
        /// </summary>
        [FieldOffset(55)]
        public byte Bit55;

        /// <summary>
        ///  Bit 56
        /// </summary>
        [FieldOffset(56)]
        public byte Bit56;

        /// <summary>
        ///  Bit 57
        /// </summary>
        [FieldOffset(57)]
        public byte Bit57;

        /// <summary>
        ///  Bit 58
        /// </summary>
        [FieldOffset(58)]
        public byte Bit58;

        /// <summary>
        ///  Bit 59
        /// </summary>
        [FieldOffset(59)]
        public byte Bit59;

        /// <summary>
        ///  Bit 60
        /// </summary>
        [FieldOffset(60)]
        public byte Bit60;

        /// <summary>
        ///  Bit 61
        /// </summary>
        [FieldOffset(61)]
        public byte Bit61;

        /// <summary>
        ///  Bit 62
        /// </summary>
        [FieldOffset(62)]
        public byte Bit62;

        /// <summary>
        ///  Bit 63
        /// </summary>
        [FieldOffset(63)]
        public byte Bit63;

         /// <summary>
        /// Block 0 of width 2
        /// </summary>
        [FieldOffset(0)]
        public BitBlock2 Block2x0;

        /// <summary>
        /// Block 1 of width 2
        /// </summary>
        [FieldOffset(2)]
        public BitBlock2 Block2x1;    

        /// <summary>
        /// Block 2 of width 2
        /// </summary>
        [FieldOffset(4)]
        public BitBlock2 Block2x2;    

        /// <summary>
        /// Block 3 of width 2
        /// </summary>
        [FieldOffset(6)]
        public BitBlock2 Block2x3;    

        /// <summary>
        /// Block 4 of width 2
        /// </summary>
        [FieldOffset(8)]
        public BitBlock2 Block2x4;    

        /// <summary>
        /// Block 5 of width 2
        /// </summary>
        [FieldOffset(10)]
        public BitBlock2 Block2x5;    

        /// <summary>
        /// Block 6 of width 2
        /// </summary>
        [FieldOffset(12)]
        public BitBlock2 Block2x6;    

        /// <summary>
        /// Block 7 of width 2
        /// </summary>
        [FieldOffset(14)]
        public BitBlock2 Block2x7;    

        /// <summary>
        /// Block 8 of width 2
        /// </summary>
        [FieldOffset(16)]
        public BitBlock2 Bloc2x8;    

        /// <summary>
        /// Block 9 of width 2
        /// </summary>
        [FieldOffset(18)]
        public BitBlock2 Block2x9;    

        /// <summary>
        /// Block 10 of width 2
        /// </summary>
        [FieldOffset(20)]
        public BitBlock2 Block2x10;    

        /// <summary>
        /// Block 11 of width 2
        /// </summary>
        [FieldOffset(22)]
        public BitBlock2 Block2x11;    

        /// <summary>
        /// Block 12 of width 2
        /// </summary>
        [FieldOffset(24)]
        public BitBlock2 Block2x12;    

        /// <summary>
        /// Block 13 of width 2
        /// </summary>
        [FieldOffset(26)]
        public BitBlock2 Block2x13;    

        /// <summary>
        /// Block 14 of width 2
        /// </summary>
        [FieldOffset(28)]
        public BitBlock2 Block2x14;    

        /// <summary>
        /// Block 15 of width 2
        /// </summary>
        [FieldOffset(30)]
        public BitBlock2 Block2x15;

         /// <summary>
        /// Block 16 of width 2
        /// </summary>
        [FieldOffset(32)]
        public BitBlock2 Block2x16;

        /// <summary>
        /// Block 17 of width 2
        /// </summary>
        [FieldOffset(34)]
        public BitBlock2 Block2x17;    

        /// <summary>
        /// Block 18 of width 2
        /// </summary>
        [FieldOffset(36)]
        public BitBlock2 Block2x18;    

        /// <summary>
        /// Block 19 of width 2
        /// </summary>
        [FieldOffset(38)]
        public BitBlock2 Block2x19;    

        /// <summary>
        /// Block 20 of width 2
        /// </summary>
        [FieldOffset(40)]
        public BitBlock2 Block2x20;    

        /// <summary>
        /// Block 21 of width 2
        /// </summary>
        [FieldOffset(42)]
        public BitBlock2 Block2x21;    

        /// <summary>
        /// Block 22 of width 2
        /// </summary>
        [FieldOffset(44)]
        public BitBlock2 Block2x22;    

        /// <summary>
        /// Block 23 of width 2
        /// </summary>
        [FieldOffset(46)]
        public BitBlock2 Block2x23;    

        /// <summary>
        /// Block 24 of width 2
        /// </summary>
        [FieldOffset(48)]
        public BitBlock2 Bloc2x24;    

        /// <summary>
        /// Block 25 of width 2
        /// </summary>
        [FieldOffset(50)]
        public BitBlock2 Block2x25;    

        /// <summary>
        /// Block 26 of width 2
        /// </summary>
        [FieldOffset(52)]
        public BitBlock2 Block2x26;    

        /// <summary>
        /// Block 27 of width 2
        /// </summary>
        [FieldOffset(54)]
        public BitBlock2 Block2x27;    

        /// <summary>
        /// Block 28 of width 2
        /// </summary>
        [FieldOffset(56)]
        public BitBlock2 Block2x28;    

        /// <summary>
        /// Block 29 of width 2
        /// </summary>
        [FieldOffset(58)]
        public BitBlock2 Block2x29;    

        /// <summary>
        /// Block 30 of width 2
        /// </summary>
        [FieldOffset(60)]
        public BitBlock2 Block2x30;    

        /// <summary>
        /// Block 31 of width 2
        /// </summary>
        [FieldOffset(62)]
        public BitBlock2 Block2x31;

        /// <summary>
        /// Block 0 of width 4
        /// </summary>
        [FieldOffset(0)]
        public BitBlock4 Block4x0;

        /// <summary>
        /// Block 1 of width 4
        /// </summary>
        [FieldOffset(4)]
        public BitBlock4 Block4x1;

        /// <summary>
        /// Block 2 of width 4
        /// </summary>
        [FieldOffset(8)]
        public BitBlock4 Block4x2;

        /// <summary>
        /// Block 3 of width 4
        /// </summary>
        [FieldOffset(12)]
        public BitBlock4 Block4x3;

        /// <summary>
        /// Block 4 of width 4
        /// </summary>
        [FieldOffset(16)]
        public BitBlock4 Block4x4;

        /// <summary>
        /// Block 5 of width 4
        /// </summary>
        [FieldOffset(20)]
        public BitBlock4 Block4x5;

        /// <summary>
        /// Block 6 of width 4
        /// </summary>
        [FieldOffset(24)]
        public BitBlock4 Block4x6;

        /// <summary>
        /// Block 7 of width 4
        /// </summary>
        [FieldOffset(28)]
        public BitBlock4 Block4x7;

        /// <summary>
        /// Block 8 of width 4
        /// </summary>
        [FieldOffset(32)]
        public BitBlock4 Block4x8;

        /// <summary>
        /// Block 9 of width 4
        /// </summary>
        [FieldOffset(36)]
        public BitBlock4 Block4x9;

        /// <summary>
        /// Block 10 of width 4
        /// </summary>
        [FieldOffset(40)]
        public BitBlock4 Block4x10;

        /// <summary>
        /// Block 11 of width 4
        /// </summary>
        [FieldOffset(44)]
        public BitBlock4 Block4x11;

        /// <summary>
        /// Block 12 of width 4
        /// </summary>
        [FieldOffset(48)]
        public BitBlock4 Block4x12;

        /// <summary>
        /// Block 13 of width 4
        /// </summary>
        [FieldOffset(52)]
        public BitBlock4 Block4x13;

        /// <summary>
        /// Block 14 of width 4
        /// </summary>
        [FieldOffset(56)]
        public BitBlock4 Block4x14;

        /// <summary>
        /// Block 15 of width 4
        /// </summary>
        [FieldOffset(60)]
        public BitBlock4 Block4x15;

        /// <summary>
        /// Block 0 of width 8
        /// </summary>
        [FieldOffset(0)]
        public BitBlock8 Block8x0;

        /// <summary>
        /// Block 1 of width 8
        /// </summary>
        [FieldOffset(8)]
        public BitBlock8 Block8x1;

        /// <summary>
        /// Block 2 of width 8
        /// </summary>
        [FieldOffset(16)]
        public BitBlock8 Block8x2;

        /// <summary>
        /// Block 3 of width 8
        /// </summary>
        [FieldOffset(24)]
        public BitBlock8 Block8x3;

        /// <summary>
        /// Block 0 of width 8
        /// </summary>
        [FieldOffset(32)]
        public BitBlock8 Block8x4;

        /// <summary>
        /// Block 1 of width 8
        /// </summary>
        [FieldOffset(40)]
        public BitBlock8 Block8x5;

        /// <summary>
        /// Block 2 of width 8
        /// </summary>
        [FieldOffset(48)]
        public BitBlock8 Block8x6;

        /// <summary>
        /// Block 3 of width 8
        /// </summary>
        [FieldOffset(56)]
        public BitBlock8 Block8x7;

        /// <summary>
        /// Block 0 of width 16
        /// </summary>
        [FieldOffset(0)]
        public BitBlock16 Block16x0;
         
        /// <summary>
        /// Block 1 of width 16
        /// </summary>
        [FieldOffset(16)]
        public BitBlock16 Block16x1;

        /// <summary>
        /// Block 2 of width 16
        /// </summary>
        [FieldOffset(32)]
        public BitBlock16 Block16x2;
         
        /// <summary>
        /// Block 3 of width 16
        /// </summary>
        [FieldOffset(48)]
        public BitBlock16 Block16x3;

        /// <summary>
        /// Block 0 of width 32
        /// </summary>
        [FieldOffset(0)]
        public BitBlock32 Block32x0;

        /// <summary>
        /// Block 1 of width 32
        /// </summary>
        [FieldOffset(32)]
        public BitBlock32 Block32x1;

        [MethodImpl(Inline)]
        public Span<byte> AsSpan()
            => Spans.AsSpan(ref this);

        [MethodImpl(Inline)]
        public Span<T> AsSpan<T>()
            where T : unmanaged
            => Spans.AsSpan<BitBlock64, T>(ref this);

        [MethodImpl(Inline)]
        public byte GetPart(int i)
            => Unmanaged.Part(ref this, i);

        [MethodImpl(Inline)]
        public T GetPart<T>(int i)
            where T : unmanaged
                => Unmanaged.Part<BitBlock64,T>(ref this, i);

        [MethodImpl(Inline)]
        public void SetPart(int i, byte value)
            => Unmanaged.Part(ref this, i) = value;

        [MethodImpl(Inline)]
        public T SetPart<T>(int i, T value)
            where T : unmanaged
                => Unmanaged.Part<BitBlock64,T>(ref this, i) = value;

        public byte this [int i]
        {
            [MethodImpl(Inline)]
            get => GetPart(i);
            
            [MethodImpl(Inline)]
            set => SetPart(i,value);
        }

        public string Format()
            => this.AsGeneric().Format(); 

        public override string ToString() 
            => Format();
    }

}