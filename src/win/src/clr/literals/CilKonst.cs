//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;

    public readonly struct CilKonst
    {
        //
        // Use packed bitfield for flags to avoid code bloat
        //
        public const int OperandTypeMask = 0x1F;              // 000000000000000000000000000XXXXX

        public const int FlowControlShift = 5;                // 00000000000000000000000XXXX00000
        
        public const int FlowControlMask = 0x0F;

        public const int OpCodeTypeShift = 9;                 // 00000000000000000000XXX000000000
        
        public const int OpCodeTypeMask = 0x07;

        public const int StackBehaviourPopShift = 12;         // 000000000000000XXXXX000000000000
        
        public const int StackBehaviourPushShift = 17;        // 0000000000XXXXX00000000000000000
        
        public const int StackBehaviourMask = 0x1F;

        public const int SizeShift = 22;                      // 00000000XX0000000000000000000000
        
        public const int SizeMask = 0x03;

        public const int EndsUncondJmpBlkFlag = 0x01000000;   // 0000000X000000000000000000000000

        // unused                                               // 0000XXX0000000000000000000000000

        public const int StackChangeShift = 28;               // XXXX0000000000000000000000000000
    }
}