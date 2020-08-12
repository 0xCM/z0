//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit)]
    public struct VectorRegisterArea
    {
        public const int VectorRegisterSize = 26;

        [FieldOffset(0x0)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = VectorRegisterSize)]
        public M128A[] VectorRegister;

        [FieldOffset(0x1a0)]
        public ulong VectorControl;

        public VectorRegisterArea(VectorRegisterArea other) : this()
        {
            for (int i = 0; i < VectorRegisterSize; ++i)
                VectorRegister[i] = other.VectorRegister[i];

            VectorControl = other.VectorControl;
        }

        public void Clear()
        {
            for (int i = 0; i < VectorRegisterSize; ++i)
                VectorRegister[i].Clear();

            VectorControl = 0;
        }
    }
 
}