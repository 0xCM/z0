//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using C = System.Reflection.Metadata.ILOpCode;

    [ApiHost]
    public readonly struct CilQueries
    {
        /// <summary>
        /// Returns true of the specified op-code is a branch to a label.
        /// </summary>
        [Op]
        public static bool IsBranch(C opCode)
        {
            switch (opCode)
            {
                case C.Br:
                case C.Br_s:
                case C.Brtrue:
                case C.Brtrue_s:
                case C.Brfalse:
                case C.Brfalse_s:
                case C.Beq:
                case C.Beq_s:
                case C.Bne_un:
                case C.Bne_un_s:
                case C.Bge:
                case C.Bge_s:
                case C.Bge_un:
                case C.Bge_un_s:
                case C.Bgt:
                case C.Bgt_s:
                case C.Bgt_un:
                case C.Bgt_un_s:
                case C.Ble:
                case C.Ble_s:
                case C.Ble_un:
                case C.Ble_un_s:
                case C.Blt:
                case C.Blt_s:
                case C.Blt_un:
                case C.Blt_un_s:
                case C.Leave:
                case C.Leave_s:
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Get a long form of the specified branch op-code.
        /// </summary>
        /// <param name="opCode">Branch op-code.</param>
        /// <returns>Long form of the branch op-code.</returns>
        /// <exception cref="ArgumentException">Specified <paramref name="opCode"/> is not a branch op-code.</exception>
        [Op]
        public static C LongBranch(C opCode)
        {
            switch (opCode)
            {
                case C.Br:
                case C.Brfalse:
                case C.Brtrue:
                case C.Beq:
                case C.Bge:
                case C.Bgt:
                case C.Ble:
                case C.Blt:
                case C.Bne_un:
                case C.Bge_un:
                case C.Bgt_un:
                case C.Ble_un:
                case C.Blt_un:
                case C.Leave:
                    return opCode;

                case C.Br_s:
                    return C.Br;

                case C.Brfalse_s:
                    return C.Brfalse;

                case C.Brtrue_s:
                    return C.Brtrue;

                case C.Beq_s:
                    return C.Beq;

                case C.Bge_s:
                    return C.Bge;

                case C.Bgt_s:
                    return C.Bgt;

                case C.Ble_s:
                    return C.Ble;

                case C.Blt_s:
                    return C.Blt;

                case C.Bne_un_s:
                    return C.Bne_un;

                case C.Bge_un_s:
                    return C.Bge_un;

                case C.Bgt_un_s:
                    return C.Bgt_un;

                case C.Ble_un_s:
                    return C.Ble_un;

                case C.Blt_un_s:
                    return C.Blt_un;

                case C.Leave_s:
                    return C.Leave;
            }

            return 0;
        }

        /// <summary>
        /// Get a short form of the specified branch op-code.
        /// </summary>
        /// <param name="opCode">Branch op-code.</param>
        /// <returns>Short form of the branch op-code.</returns>
        /// <exception cref="ArgumentException">Specified <paramref name="opCode"/> is not a branch op-code.</exception>
        [Op]
        public static C ShortBranch(C opCode)
        {
            switch (opCode)
            {
                case C.Br_s:
                case C.Brfalse_s:
                case C.Brtrue_s:
                case C.Beq_s:
                case C.Bge_s:
                case C.Bgt_s:
                case C.Ble_s:
                case C.Blt_s:
                case C.Bne_un_s:
                case C.Bge_un_s:
                case C.Bgt_un_s:
                case C.Ble_un_s:
                case C.Blt_un_s:
                case C.Leave_s:
                    return opCode;

                case C.Br:
                    return C.Br_s;

                case C.Brfalse:
                    return C.Brfalse_s;

                case C.Brtrue:
                    return C.Brtrue_s;

                case C.Beq:
                    return C.Beq_s;

                case C.Bge:
                    return C.Bge_s;

                case C.Bgt:
                    return C.Bgt_s;

                case C.Ble:
                    return C.Ble_s;

                case C.Blt:
                    return C.Blt_s;

                case C.Bne_un:
                    return C.Bne_un_s;

                case C.Bge_un:
                    return C.Bge_un_s;

                case C.Bgt_un:
                    return C.Bgt_un_s;

                case C.Ble_un:
                    return C.Ble_un_s;

                case C.Blt_un:
                    return C.Blt_un_s;

                case C.Leave:
                    return C.Leave_s;
            }

            return 0;
        }


        /// <summary>
        /// Calculate the size of the specified branch instruction operand.
        /// </summary>
        /// <param name="opCode">Branch op-code.</param>
        /// <returns>1 if <paramref name="opCode"/> is a short branch or 4 if it is a long branch.</returns>
        /// <exception cref="ArgumentException">Specified <paramref name="opCode"/> is not a branch op-code.</exception>
        [Op]
        public static int BranchOperandSize(C opCode)
        {
            switch (opCode)
            {
                case C.Br_s:
                case C.Brfalse_s:
                case C.Brtrue_s:
                case C.Beq_s:
                case C.Bge_s:
                case C.Bgt_s:
                case C.Ble_s:
                case C.Blt_s:
                case C.Bne_un_s:
                case C.Bge_un_s:
                case C.Bgt_un_s:
                case C.Ble_un_s:
                case C.Blt_un_s:
                case C.Leave_s:
                    return 1;

                case C.Br:
                case C.Brfalse:
                case C.Brtrue:
                case C.Beq:
                case C.Bge:
                case C.Bgt:
                case C.Ble:
                case C.Blt:
                case C.Bne_un:
                case C.Bge_un:
                case C.Bgt_un:
                case C.Ble_un:
                case C.Blt_un:
                case C.Leave:
                    return 4;
            }

            return -1;
        }
    }
}