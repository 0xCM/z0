//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 210210
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;
    using static Registers;

    public readonly struct XmmRegs
    {
        public static XmmRegs Index => default;
        
        public readonly XMM0 xmm0;

        public readonly XMM1 xmm1;

        public readonly XMM2 xmm2;

        public readonly XMM3 xmm3;

        public readonly XMM4 xmm4;

        public readonly XMM5 xmm5;

        public readonly XMM6 xmm6;

        public readonly XMM7 xmm7;

        public ReadOnlySpan<ulong> Locations
        {
            [MethodImpl(Inline)]
            get => new ulong[8]{L0,L1,L2,L3,L4,L5,L6,L7};
        }

        public ReadOnlySpan<byte> Data
        {        
            [MethodImpl(Inline)]
            get => Bytes.from(this);
        }       

        public ReadOnlySpan<IRegOp> Operations
        {
            [MethodImpl(Inline)]
            get => new IRegOp[8]{xmm0,xmm1,xmm2,xmm3,xmm4,xmm5,xmm6,xmm7};
        }

        ulong L0
        {
            [MethodImpl(Inline)]
            get => Location(0);
        }

        ulong L1
        {
            [MethodImpl(Inline)]
            get => Location(1);
        }

        ulong L2
        {
            [MethodImpl(Inline)]
            get => Location(2);
        }

        ulong L3
        {
            [MethodImpl(Inline)]
            get => Location(3);
        }

        ulong L4
        {
            [MethodImpl(Inline)]
            get => Location(4);
        }

        ulong L5
        {
            [MethodImpl(Inline)]
            get => Location(5);
        }

        ulong L6
        {
            [MethodImpl(Inline)]
            get => Location(6);
        }

        ulong L7
        {
            [MethodImpl(Inline)]
            get => Location(7);
        }


        [MethodImpl(Inline)]
        unsafe ulong Location(int index)
            => (ulong)ptr(ref edit(skip(Data,index)));
    }
}