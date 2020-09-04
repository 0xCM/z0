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

    using Z0.MS;

    using static Konst;

    public static class ClrQueries
    {
        [MethodImpl(Inline), Op]
        public static EventDefinitionHandle @event(uint id)
        {
            var dst = default(EventDefinitionHandle);
            z.seek<EventDefinitionHandle,uint>(dst,0) = id;
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<HexCodeLo> digits(EventDefinitionHandle src)
        {
            return Structures.digits(src, LowerCase);
        }

        [MethodImpl(Inline), Op]
        public static string format(EventDefinitionHandle src)
            => Structures.format(src);

        [MethodImpl(Inline), Op]
        public static bool primitive(ClrTypeCode src)
        {
            return src >= ClrTypeCode.Bool8 && src <= ClrTypeCode.Float64
                || src == ClrTypeCode.IntI || src == ClrTypeCode.IntU
                || src == ClrTypeCode.Ptr || src == ClrTypeCode.PtrFx;
        }

        [MethodImpl(Inline), Op]
        public static bool valuetype(ClrTypeCode src)
            => src == ClrTypeCode.Struct;

        [MethodImpl(Inline), Op]
        public static bool objref(ClrTypeCode src)
        {
            return src == ClrTypeCode.String || src == ClrTypeCode.Class
                || src == ClrTypeCode.Array || src == ClrTypeCode.Cells
                || src == ClrTypeCode.Object;
        }

        [MethodImpl(Inline), Op]
        public static string name(ClrRootKind kind)
            => kind switch
        {
            ClrRootKind.None => "none",
            ClrRootKind.FinalizerQueue => "finalization root",
            ClrRootKind.StrongHandle => "strong handle",
            ClrRootKind.PinnedHandle => "pinned handle",
            ClrRootKind.Stack => "stack root",
            ClrRootKind.RefCountedHandle => "ref counted handle",
            ClrRootKind.AsyncPinnedHandle => "async pinned handle",
            ClrRootKind.SizedRefHandle => "sized ref handle",
            _ => "unknown root"
        };

        [Op]
        public static string name(ClrHandleKind kind) => kind switch
        {
            ClrHandleKind.WeakShort => "weak short handle",
            ClrHandleKind.WeakLong => "weak long handle",
            ClrHandleKind.Strong => "strong handle",
            ClrHandleKind.Pinned => "pinned handle",
            ClrHandleKind.RefCounted => "ref counted handle",
            ClrHandleKind.Dependent => "dependent handle",
            ClrHandleKind.AsyncPinned => "async pinned handle",
            ClrHandleKind.SizedRef => "sized ref handle",
            ClrHandleKind.WeakWinRT => "weak WinRT handle",
            _ => "unknown handle"
        };

        /// <summary>
        /// Gets the <see cref='System.Type' /> represented by the <see cref='ClrTypeCode'/>
        /// </summary>
        /// <param name="src">The model element type</param>
        [Op]
        public static Type represented(ClrTypeCode src)
        {
            switch (src)
            {
                case ClrTypeCode.Bool8:
                    return typeof(bool);

                case ClrTypeCode.Char16:
                    return typeof(char);

                case ClrTypeCode.Float64:
                    return typeof(double);

                case ClrTypeCode.Float32:
                    return typeof(float);

                case ClrTypeCode.Ptr:
                case ClrTypeCode.IntI:
                case ClrTypeCode.PtrFx:
                    return typeof(IntPtr);

                case ClrTypeCode.IntU:
                    return typeof(UIntPtr);

                case ClrTypeCode.Int16i:
                    return typeof(short);

                case ClrTypeCode.Int32i:
                    return typeof(int);

                case ClrTypeCode.Int64i:
                    return typeof(long);

                case ClrTypeCode.Int8i:
                    return typeof(sbyte);

                case ClrTypeCode.Int16u:
                    return typeof(ushort);

                case ClrTypeCode.Int32u:
                    return typeof(uint);

                case ClrTypeCode.Int64u:
                    return typeof(ulong);

                case ClrTypeCode.Int8u:
                    return typeof(byte);

                default:
                    return null;
            }
        }

        /// <summary>
        /// Returns true of the specified op-code is a branch to a label.
        /// </summary>
        [Op]
        public static bool branch(ILOpCode opCode)
        {
            switch (opCode)
            {
                case ILOpCode.Br:
                case ILOpCode.Br_s:
                case ILOpCode.Brtrue:
                case ILOpCode.Brtrue_s:
                case ILOpCode.Brfalse:
                case ILOpCode.Brfalse_s:
                case ILOpCode.Beq:
                case ILOpCode.Beq_s:
                case ILOpCode.Bne_un:
                case ILOpCode.Bne_un_s:
                case ILOpCode.Bge:
                case ILOpCode.Bge_s:
                case ILOpCode.Bge_un:
                case ILOpCode.Bge_un_s:
                case ILOpCode.Bgt:
                case ILOpCode.Bgt_s:
                case ILOpCode.Bgt_un:
                case ILOpCode.Bgt_un_s:
                case ILOpCode.Ble:
                case ILOpCode.Ble_s:
                case ILOpCode.Ble_un:
                case ILOpCode.Ble_un_s:
                case ILOpCode.Blt:
                case ILOpCode.Blt_s:
                case ILOpCode.Blt_un:
                case ILOpCode.Blt_un_s:
                case ILOpCode.Leave:
                case ILOpCode.Leave_s:
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
        public static ILOpCode longBranch(ILOpCode opCode)
        {
            switch (opCode)
            {
                case ILOpCode.Br:
                case ILOpCode.Brfalse:
                case ILOpCode.Brtrue:
                case ILOpCode.Beq:
                case ILOpCode.Bge:
                case ILOpCode.Bgt:
                case ILOpCode.Ble:
                case ILOpCode.Blt:
                case ILOpCode.Bne_un:
                case ILOpCode.Bge_un:
                case ILOpCode.Bgt_un:
                case ILOpCode.Ble_un:
                case ILOpCode.Blt_un:
                case ILOpCode.Leave:
                    return opCode;

                case ILOpCode.Br_s:
                    return ILOpCode.Br;

                case ILOpCode.Brfalse_s:
                    return ILOpCode.Brfalse;

                case ILOpCode.Brtrue_s:
                    return ILOpCode.Brtrue;

                case ILOpCode.Beq_s:
                    return ILOpCode.Beq;

                case ILOpCode.Bge_s:
                    return ILOpCode.Bge;

                case ILOpCode.Bgt_s:
                    return ILOpCode.Bgt;

                case ILOpCode.Ble_s:
                    return ILOpCode.Ble;

                case ILOpCode.Blt_s:
                    return ILOpCode.Blt;

                case ILOpCode.Bne_un_s:
                    return ILOpCode.Bne_un;

                case ILOpCode.Bge_un_s:
                    return ILOpCode.Bge_un;

                case ILOpCode.Bgt_un_s:
                    return ILOpCode.Bgt_un;

                case ILOpCode.Ble_un_s:
                    return ILOpCode.Ble_un;

                case ILOpCode.Blt_un_s:
                    return ILOpCode.Blt_un;

                case ILOpCode.Leave_s:
                    return ILOpCode.Leave;
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
        public static ILOpCode shortbranch(ILOpCode opCode)
        {
            switch (opCode)
            {
                case ILOpCode.Br_s:
                case ILOpCode.Brfalse_s:
                case ILOpCode.Brtrue_s:
                case ILOpCode.Beq_s:
                case ILOpCode.Bge_s:
                case ILOpCode.Bgt_s:
                case ILOpCode.Ble_s:
                case ILOpCode.Blt_s:
                case ILOpCode.Bne_un_s:
                case ILOpCode.Bge_un_s:
                case ILOpCode.Bgt_un_s:
                case ILOpCode.Ble_un_s:
                case ILOpCode.Blt_un_s:
                case ILOpCode.Leave_s:
                    return opCode;

                case ILOpCode.Br:
                    return ILOpCode.Br_s;

                case ILOpCode.Brfalse:
                    return ILOpCode.Brfalse_s;

                case ILOpCode.Brtrue:
                    return ILOpCode.Brtrue_s;

                case ILOpCode.Beq:
                    return ILOpCode.Beq_s;

                case ILOpCode.Bge:
                    return ILOpCode.Bge_s;

                case ILOpCode.Bgt:
                    return ILOpCode.Bgt_s;

                case ILOpCode.Ble:
                    return ILOpCode.Ble_s;

                case ILOpCode.Blt:
                    return ILOpCode.Blt_s;

                case ILOpCode.Bne_un:
                    return ILOpCode.Bne_un_s;

                case ILOpCode.Bge_un:
                    return ILOpCode.Bge_un_s;

                case ILOpCode.Bgt_un:
                    return ILOpCode.Bgt_un_s;

                case ILOpCode.Ble_un:
                    return ILOpCode.Ble_un_s;

                case ILOpCode.Blt_un:
                    return ILOpCode.Blt_un_s;

                case ILOpCode.Leave:
                    return ILOpCode.Leave_s;
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
        public static int branchOpSize(ILOpCode opCode)
        {
            switch (opCode)
            {
                case ILOpCode.Br_s:
                case ILOpCode.Brfalse_s:
                case ILOpCode.Brtrue_s:
                case ILOpCode.Beq_s:
                case ILOpCode.Bge_s:
                case ILOpCode.Bgt_s:
                case ILOpCode.Ble_s:
                case ILOpCode.Blt_s:
                case ILOpCode.Bne_un_s:
                case ILOpCode.Bge_un_s:
                case ILOpCode.Bgt_un_s:
                case ILOpCode.Ble_un_s:
                case ILOpCode.Blt_un_s:
                case ILOpCode.Leave_s:
                    return 1;

                case ILOpCode.Br:
                case ILOpCode.Brfalse:
                case ILOpCode.Brtrue:
                case ILOpCode.Beq:
                case ILOpCode.Bge:
                case ILOpCode.Bgt:
                case ILOpCode.Ble:
                case ILOpCode.Blt:
                case ILOpCode.Bne_un:
                case ILOpCode.Bge_un:
                case ILOpCode.Bgt_un:
                case ILOpCode.Ble_un:
                case ILOpCode.Blt_un:
                case ILOpCode.Leave:
                    return 4;
            }

            return -1;
        }
    }
}