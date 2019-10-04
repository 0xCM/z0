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
    /// Represents 4 bits with 4 8-bit values that may range over {0,1}
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Size=4)]
    public struct BitBlock4 : IBitBlock
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


        [MethodImpl(Inline)]        
        public uint ToUInt32()
            => BitBlock.AsSpan(ref this).TakeUInt32(); 

        [MethodImpl(Inline)]
        public byte GetPart(int i)
            => Unsafe.Add(ref Unsafe.As<BitBlock4, byte>(ref this), i);

        [MethodImpl(Inline)]
        public void SetPart(int i, byte value)
            => Unsafe.Add(ref Unsafe.As<BitBlock4, byte>(ref this), i) = value;
        
        [MethodImpl(Inline)]
        public byte Compress()
        {
            uint dst = Bit0;
            dst |= ((uint)Bit1 << 1);
            dst |= ((uint)Bit2 << 2);
            dst |= ((uint)Bit3 << 3);
            return (byte)dst;
        }

        public byte this [int i]
        {
            [MethodImpl(Inline)]
            get => GetPart(i);
            
            [MethodImpl(Inline)]
            set => SetPart(i,value);
        }


    }

}