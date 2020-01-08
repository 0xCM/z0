//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using System.Runtime.InteropServices;
    using System.Security;

    using static zfunc;
    using static NatMath;

    class ExperimentalScenarios : Deconstructable<ExperimentalScenarios>
    {

        public ExperimentalScenarios()
            : base(callerfile())
        {

        }

        public byte opA_8u(byte dl, byte r8b, byte r9b, byte rsp28)
        {
            byte al = (byte)(dl * r8b);
            al = (byte)(al ^ r9b) ;
            byte dl0 = (byte)(al | rsp28);
            return dl0;
        }

        public ushort opA_16u(ushort dx, ushort r8w, ushort r9w, ushort rsp28)
        {
            ushort ax = (ushort)(dx * r8w);
            ushort b = (ushort)(ax ^ r9w) ;
            ushort ax0 = (ushort)(b | rsp28);
            return ax0;
        }

        public uint opA_32u(uint edx, uint r8d, uint r9d, uint rsp28)
        {
            uint edx0 = edx * r8d;
            uint b = edx0 ^ r9d ;
            uint c = b | rsp28;
            return c;
        }

        public ulong opA_64u(ulong rdx, ulong r8, ulong r9, ulong rsp28)
        {
            ulong rdx0 = rdx * r8;
            ulong b = rdx0 ^ r9 ;
            ulong c = b | rsp28;
            return c;
        }

        public byte opB_8u(byte dl, byte r8b, byte r9b, byte rsp28, byte rsp30)
        {
            byte al = (byte)(dl * r8b);
            al = (byte)(al ^ r9b) ;
            byte a = (byte)(al | rsp28);
            byte b = (byte)(a & rsp30);
            return b;
        }


        public byte opC_8u(byte dl, byte r8b, byte r9b, byte rsp28, byte rsp30, byte rsp38)
        {
            byte al = (byte)(dl * r8b);
            al = (byte)(al ^ r9b) ;
            byte a = (byte)(al | rsp28);
            byte b = (byte)(a & rsp30);
            byte c = (byte)(b ^ rsp38);
            return c;
        }

        public void opD_8u(byte dl, byte r8b, out byte r9, out byte rdx)
        {            
            r9 = (byte)(dl ^ 5);
            rdx = (byte)(r8b | 7);
        }

        public void opD_64u(ulong rdx, ulong r8, out ulong r9, out ulong rax)
        {            
            r9 = rdx ^ 5;
            rax = r8 | 7;
        }

        public void opE_64u(ulong rdx, out ulong r8, out ulong r9)
        {            
            r8 = rdx ^ 5;
            r9 = rdx | 7;
        }

        public void opF_64u(ulong rdx, out ulong r8, out ulong r9, out ulong rax)
        {            
            r8 = rdx ^ 5;
            r9 = rdx | 7;
            rax = rdx & 13;
        }

    }

}