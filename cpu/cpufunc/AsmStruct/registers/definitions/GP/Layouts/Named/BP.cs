//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    
    

    using static zfunc;

    partial class Registers
    {
        [StructLayout(LayoutKind.Explicit)]
        public struct BP : IGpReg16<BP>
        {
            [FieldOffset(0)]
            ushort content;

            [FieldOffset(0)]
            BPL bpl;

            public const GpRegId Id = GpRegId.bp;

            [MethodImpl(Inline)]
            public static ushort operator !(BP r)
                => r.content;

            [MethodImpl(Inline)]
            public static implicit operator BP(ushort src)
                => new BP(src);

            [MethodImpl(Inline)]
            public BP(ushort src)
                : this()
            {
                content = src;
            }

            byte IGpReg16<BP>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => !bpl; 
 
                [MethodImpl(Inline)]
                set => bpl = value;
            }
            
            GpRegId IGpReg.Id 
                => Id;
        }
    }
}