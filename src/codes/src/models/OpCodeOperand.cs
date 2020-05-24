//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;
 
    public readonly struct OpCodeOperand : IOpCodeComponent<OpCodeOperand,ushort>
    {
        internal readonly ushort Data;        

        public static OpCodeOperand Empty => new OpCodeOperand(0);
                
        [MethodImpl(Inline)]
        public OpCodeOperand(ushort data)
        {
            this.Data = data;
        }       

        public ushort Content
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Data == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Data != 0;
        }

        public OpCodeOperand Zero
        {
            [MethodImpl(Inline)]
            get => Empty;
        }

        [MethodImpl(Inline)]
        public bool Equals(OpCodeOperand src)
            => Data == src.Data;

        public string Format()
            =>  Data.ToString();

        public override string ToString()
            => Format();
    }
}