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
        /// Get a short form of the specified branch op-code.
        /// </summary>
        /// <param name="opCode">Branch op-code.</param>
        /// <returns>Short form of the branch op-code.</returns>
        /// <exception cref="ArgumentException">Specified <paramref name="opCode"/> is not a branch op-code.</exception>
        [Op]
        public static ILOpCode ShortBranch(ILOpCode opCode)
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
                    return opCode;

                case Br:
                    return Br_s;

                case Brfalse:
                    return Brfalse_s;

                case Brtrue:
                    return Brtrue_s;

                case Beq:
                    return Beq_s;

                case Bge:
                    return Bge_s;

                case Bgt:
                    return Bgt_s;

                case Ble:
                    return Ble_s;

                case Blt:
                    return Blt_s;

                case Bne_un:
                    return Bne_un_s;

                case Bge_un:
                    return Bge_un_s;

                case Bgt_un:
                    return Bgt_un_s;

                case Ble_un:
                    return Ble_un_s;

                case Blt_un:
                    return Blt_un_s;

                case Leave:
                    return Leave_s;
            }

            return 0;
        }
    }
}