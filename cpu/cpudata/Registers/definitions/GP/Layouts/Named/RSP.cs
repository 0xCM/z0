//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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

        /// <summary>
        /// Holds a stack pointer that references the topmost element in the stack
        /// </summary>
        [StructLayout(LayoutKind.Explicit)]
        public struct RSP : IGpReg64<RSP>
        {
            [FieldOffset(0)]
            ulong content;

            [FieldOffset(0)]
            ESP esp;

            [FieldOffset(0)]
            SP sp;

            [FieldOffset(0)]
            SPL spl;

            public const GpRegId Id = GpRegId.rsp;

            [MethodImpl(Inline)]
            public static ulong operator !(RSP r)
                => r.content;

            [MethodImpl(Inline)]
            public static implicit operator RSP(ulong src)
                => new RSP(src);

            [MethodImpl(Inline)]
            public RSP(ulong src)
                : this()
            {
                content = src;
            }

            public GpRegId64 RegKind 
                => GpRegId64.rsp;

            byte IGpReg64<RSP>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => !spl; 
 
                [MethodImpl(Inline)]
                set => spl = value;
            }
            
            ushort IGpReg64<RSP>.Lo16 
            { 
                [MethodImpl(Inline)]
                get => !sp; 
 
                [MethodImpl(Inline)]
                set => sp = value;
            }

            uint IGpReg64<RSP>.Lo32
            { 
                [MethodImpl(Inline)]
                get => !esp; 
 
                [MethodImpl(Inline)]
                set => esp = value;
            }

            GpRegId IGpReg.Id 
                => Id;

        }
    }
}