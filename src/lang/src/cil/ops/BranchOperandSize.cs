// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;

    using static System.Reflection.Metadata.ILOpCode;

    partial struct Cil
    {
        /// <summary>
        /// Calculate the size of the specified branch instruction operand.
        /// </summary>
        /// <param name="opCode">Branch op-code.</param>
        /// <returns>1 if <paramref name="opCode"/> is a short branch or 4 if it is a long branch.</returns>
        /// <exception cref="ArgumentException">Specified <paramref name="opCode"/> is not a branch op-code.</exception>
        [Op]
        public static byte BranchOperandSize(ILOpCode opCode)
        {
            switch (opCode)
            {
                case Br_s:
                case Brfalse_s:
                case Brtrue_s:
                case Beq_s:
                case Bge_s:
                case Bgt_s:
                case Ble_s:
                case Blt_s:
                case Bne_un_s:
                case Bge_un_s:
                case Bgt_un_s:
                case Ble_un_s:
                case Blt_un_s:
                case Leave_s:
                    return 1;

                case Br:
                case Brfalse:
                case Brtrue:
                case Beq:
                case Bge:
                case Bgt:
                case Ble:
                case Blt:
                case Bne_un:
                case Bge_un:
                case Bgt_un:
                case Ble_un:
                case Blt_un:
                case Leave:
                    return 4;
            }

            return 0;
        }
    }
}