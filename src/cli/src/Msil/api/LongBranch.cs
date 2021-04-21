// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;

    using static System.Reflection.Metadata.ILOpCode;

    partial struct MsilApi
    {
        /// <summary>
        /// Get a long form of the specified branch op-code.
        /// </summary>
        /// <param name="opCode">Branch op-code.</param>
        /// <returns>Long form of the branch op-code.</returns>
        /// <exception cref="ArgumentException">Specified <paramref name="opCode"/> is not a branch op-code.</exception>
        [Op]
        public static ILOpCode LongBranch(ILOpCode opCode)
        {
            switch (opCode)
            {
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
                    return opCode;

                case Br_s:
                    return Br;

                case Brfalse_s:
                    return Brfalse;

                case Brtrue_s:
                    return Brtrue;

                case Beq_s:
                    return Beq;

                case Bge_s:
                    return Bge;

                case Bgt_s:
                    return Bgt;

                case Ble_s:
                    return Ble;

                case Blt_s:
                    return Blt;

                case Bne_un_s:
                    return Bne_un;

                case Bge_un_s:
                    return Bge_un;

                case Bgt_un_s:
                    return Bgt_un;

                case Ble_un_s:
                    return Ble_un;

                case Blt_un_s:
                    return Blt_un;

                case Leave_s:
                    return Leave;
            }

            return 0;
        }
    }
}