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
    using static AsmTypes;

    partial class AsmTypes
    {
        public readonly struct scalar8 : scalar<scalar8,W8,byte>
        {
            [MethodImpl(Inline)]
            public scalar8(byte src)
            {
                this.Value = src;
            }

            public byte Value {get;}
        }

        public readonly struct scalar16 : scalar<scalar16,W16,ushort>
        {
            [MethodImpl(Inline)]
            public scalar16(ushort src)
            {
                this.Value = src;
            }

            public ushort Value {get;}
        }

        public readonly struct scalar32: scalar<scalar32,W32,uint>
        {
            [MethodImpl(Inline)]
            public scalar32(uint src)
            {
                this.Value = src;
            }

            public uint Value {get;}
        }

        public readonly struct scalar64: scalar<scalar64,W64,ulong>
        {
            [MethodImpl(Inline)]
            public scalar64(ulong src)
            {
                this.Value = src;
            }

            public ulong Value {get;}
        }        
    }
}