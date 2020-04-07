//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;    
    using static AsmSpecs;

    partial class AsmTypes
    {
        public readonly struct address8 : address<address8,W8,byte>
        {
            [MethodImpl(Inline)]
            public address8(byte src)
            {
                this.Location = src;
            }

            public byte Location {get;}
        }

        public readonly struct address16 : address<address16,W16,ushort>
        {
            [MethodImpl(Inline)]
            public address16(ushort src)
            {
                this.Location = src;
            }

            public ushort Location {get;}
        }

        public readonly struct address32 : address<address32,W32,uint>
        {
            [MethodImpl(Inline)]
            public address32(uint src)
            {
                this.Location = src;
            }

            public uint Location {get;}
        }

        public readonly struct address64 : address<address64,W64,ulong>
        {
            [MethodImpl(Inline)]
            public address64(ulong src)
            {
                this.Location = src;
            }

            public ulong Location {get;}
        }    
    }
}