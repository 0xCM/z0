//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;
    using System.Runtime.CompilerServices;    

    using static Konst;
    using static CilOpCodeKind;

    [ApiHost]
    public readonly struct CilQueries
    {
        /// <summary>
        /// Calculate the size of the specified branch instruction operand.
        /// </summary>
        /// <param name="opCode">Branch op-code.</param>
        /// <returns>1 if <paramref name="opCode"/> is a short branch, 4 if it is a long branch, <see cref='ushort.MaxValue'/> otherwise.</returns>
        [Op]
        public static ushort branchOpSize(CilOpCodeKind opCode)
        {
            switch (opCode)
            {
                case Br_S:
                case Brfalse_S:
                case Brtrue_S:
                case Beq_S:
                case Bge_S:
                case Bgt_S:
                case Ble_S:
                case Blt_S:
                case Bne_Un_S:
                case Bge_Un_S:
                case Bgt_Un_S:
                case Ble_Un_S:
                case Blt_Un_S:
                case Leave_S:
                    return 1;

                case Br:
                case Brfalse:
                case Brtrue:
                case Beq:
                case Bge:
                case Bgt:
                case Ble:
                case Blt:
                case Bne_Un:
                case Bge_Un:
                case Bgt_Un:
                case Ble_Un:
                case Blt_Un:
                case Leave:
                    return 4;
            }

            return ushort.MaxValue;
        }
    }
}