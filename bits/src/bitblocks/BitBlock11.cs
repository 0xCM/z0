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
    /// Represents 11 bits with 11 8-bit values that may range over {0,1}
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Size=11)]
    public struct BitBlock11 : IBitBlock
    {
        /// <summary>
        ///  Bit 0
        /// </summary>
        public byte Bit0;

        /// <summary>
        ///  Bit 1
        /// </summary>
        public byte Bit1;

        /// <summary>
        ///  Bit 2
        /// </summary>
        public byte Bit2;

        /// <summary>
        ///  Bit 2
        /// </summary>
        public byte Bit3;
        
        /// <summary>
        ///  Bit 4
        /// </summary>
        public byte Bit4;

        /// <summary>
        ///  Bit 5
        /// </summary>
        public byte Bit5;

        /// <summary>
        ///  Bit 6
        /// </summary>
        public byte Bit6;

        /// <summary>
        ///  Bit 7
        /// </summary>
        public byte Bit7;

        /// <summary>
        ///  Bit 8
        /// </summary>
        public byte Bit8;

        /// <summary>
        ///  Bit 9
        /// </summary>
        public byte Bit9;

         /// <summary>
        ///  Bit 9
        /// </summary>
        public byte Bit10;


        [MethodImpl(Inline)]
        public byte GetPart(int i)
            => Unsafe.Add(ref Unsafe.As<BitBlock11, byte>(ref this), i);

        [MethodImpl(Inline)]
        public void SetPart(int i, byte value)
            => Unsafe.Add(ref Unsafe.As<BitBlock11, byte>(ref this), i) = value;

        [MethodImpl(Inline)]
        public ushort Compress()
        {
           uint dst = (uint)Unsafe.As<BitBlock11, BitBlock10>(ref this).Compress();
           dst |= ((uint)Bit10 << 10);
           return (ushort)dst;
        }

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