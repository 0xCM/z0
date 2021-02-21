// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;

    using static Part;
    using static System.Reflection.Metadata.ILOpCode;

    partial struct Cil
    {
        [MethodImpl(Inline), Op]
        public static bool IsBranch(OpCode src)
            => IsBranch((ILOpCode)src.Value);

        [MethodImpl(Inline), Op]
        public static bool IsBranch(OpCodeValue src)
            => IsBranch((ILOpCode)src);

        /// <summary>
        /// Returns true of the specified op-code is a branch to a label.
        /// </summary>
        [Op]
        public static bool IsBranch(ILOpCode opCode)
        {
            switch (opCode)
            {
                case Br:
                case Br_s:
                case Brtrue:
                case Brtrue_s:
                case Brfalse:
                case Brfalse_s:
                case Beq:
                case Beq_s:
                case Bne_un:
                case Bne_un_s:
                case Bge:
                case Bge_s:
                case Bge_un:
                case Bge_un_s:
                case Bgt:
                case Bgt_s:
                case Bgt_un:
                case Bgt_un_s:
                case Ble:
                case Ble_s:
                case Ble_un:
                case Ble_un_s:
                case Blt:
                case Blt_s:
                case Blt_un:
                case Blt_un_s:
                case Leave:
                case Leave_s:
                    return true;
            }

            return false;
        }
    }
}