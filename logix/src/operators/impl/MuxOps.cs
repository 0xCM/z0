//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public static class Mux
    {
        [MethodImpl(Inline)]
        public static bit mux(bit c0, bit i0, bit i1)
            => !c0 ? i0 : i1;

        [MethodImpl(Inline)]
        public static bit mux(bit c0, bit c1, bit i0, bit i1, bit i2, bit i3)
        {
            if(!c0 && !c1)
                return i0;
            else if(c0 && !c1)
                return i1;
            else if(!c0 && c1)
                return i2;
            else
                return i3;
        }

        /*
        0 | 0 | 0 => selects input 0 = log2(0) [00000001]
        0 | 0 | 1 => selects input 1 = log2(1) [00000010]
        0 | 1 | 0 => selects input 2 = log2(2) [00000100]
        0 | 1 | 1 => selects input 3 = log2(3) [00001000]
        1 | 0 | 0 => selects input 4 = log2(4) [00010000]
        1 | 0 | 1 => selects input 5 = log2(5) [00100000]
        1 | 1 | 0 => selects input 6 = log2(6) [01000000]
        1 | 1 | 1 => selects input 7 = log2(7) [10000000]
        */
        /// <summary>
        /// Uses the first three bits of the control operand to select one of 8 bits from the input operand
        /// </summary>
        /// <param name="control">Specifies the output selection</param>
        /// <param name="input">The input from which a bit will be selected</param>
        [MethodImpl(Inline)]
        public static bit mux(BitVector4 control, BitVector8 input)
            => input[control.Scalar];

        /// <summary>
        /// Uses the four bits of the control operand to select one of 16 bits from the input operand
        /// </summary>
        /// <param name="control">Specifies the output selection</param>
        /// <param name="input">The input from which a bit will be selected</param>
        [MethodImpl(Inline)]
        public static bit mux(BitVector4 control, BitVector16 input)
            => input[control.Scalar];

        /// <summary>
        /// Uses the first 5 bits of the control operand to select one of 32 bits from the input operand
        /// </summary>
        /// <param name="control">Specifies the output selection</param>
        /// <param name="input">The input from which a bit will be selected</param>
        [MethodImpl(Inline)]
        public static bit mux(BitVector8 control, BitVector32 input)
            => input[control.Scalar];

        /// <summary>
        /// Uses the first 6 bits of the control operand to select one of 64 bits from the input operand
        /// </summary>
        /// <param name="control">Specifies the output selection</param>
        /// <param name="input">The input from which a bit will be selected</param>
        [MethodImpl(Inline)]
        public static bit mux(BitVector8 control, BitVector64 input)
            => input[control.Scalar];


        [MethodImpl(Inline)]
        public static bit mux(Mux8Control control, BitVector8 input)
            => input[control.Scalar];    
    }


    /// <summary>
    /// Defines a valid mux8 control bitset by construction
    /// </summary>
    public readonly struct Mux8Control
    {
        [MethodImpl(Inline)]
        public static Mux8Control Define(bit c0, bit c1, bit c2)
            => new Mux8Control(c0,c1,c2);

        [MethodImpl(Inline)]
        public static Mux8Control Define(BitVector4 selector)
            => new Mux8Control(selector);

        [MethodImpl(Inline)]
        Mux8Control(bit c0, bit c1, bit c2)
            => Selector = BitVector4.FromBits(c0,c1,c2,bit.Off);
        
        [MethodImpl(Inline)]
        Mux8Control(BitVector4 src)        
            => this.Selector = src[0..2];
        
        public readonly BitVector4 Selector;

        public byte Scalar
        {
            [MethodImpl(Inline)]
            get => Selector.Scalar;
        }

        public bit C0
            => Selector[0];

        public bit C1
            => Selector[1];

        public bit C2
            => Selector[2];

    }

}