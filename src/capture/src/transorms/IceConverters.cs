//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using Iced = Iced.Intel;

    [ApiHost]
    public readonly struct IceConverters
    {
        public static IceConverters Service => default(IceConverters);

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline), Op]
        public static MemoryOperand Thaw(Iced.MemoryOperand src)
            => new MemoryOperand(
                    (IceRegister)src.Base,
                    (IceRegister)src.Index,
                    src.Scale,
                    src.Displacement,
                    src.DisplSize,
                    src.IsBroadcast,
                    (IceRegister)src.SegmentPrefix
                    );

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [Op]
        public InstructionInfo Thaw(Iced.InstructionInfo src)
        {
            return new InstructionInfo
            {
                Encoding = Thaw(src.Encoding),
                FlowControl = Thaw(src.FlowControl),
                IsProtectedMode = src.IsProtectedMode,
                IsPrivileged = src.IsPrivileged,
                IsSaveRestoreInstruction = src.IsSaveRestoreInstruction,
                IsStackInstruction = src.IsStackInstruction,
                RflagsCleared = Thaw(src.RflagsCleared),
                RflagsRead = Thaw(src.RflagsRead),
                RflagsWritten = Thaw(src.RflagsWritten),
                RflagsModified = Thaw(src.RflagsModified),
                RflagsSet = Thaw(src.RflagsSet),
                RflagsUndefined = Thaw(src.RflagsUndefined),
                UsedMemory =  IceExtractors.UsedMemory(src),
                UsedRegisters = IceExtractors.UsedRegisters(src),
                CpuidFeatures = src.CpuidFeatures.Map(Thaw),
                Access = IceExtractors.access(src)
            };
        }

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline), Op]
        public UsedMemory Thaw(Iced.UsedMemory src)
            => new UsedMemory(
                Access : Thaw(src.Access),
                Base  : Thaw(src.Base),
                Displacement : src.Displacement,
                Index : Thaw(src.Index),
                MemorySize : Thaw(src.MemorySize),
                Scale : src.Scale,
                Segment : Thaw(src.Segment),
                Formatted : src.ToString()
            );

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline), Op]
        public UsedRegister Thaw(Iced.UsedRegister src)
            => new UsedRegister(Thaw(src.Register), Thaw(src.Access));

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline), Op]
        public IceOpAccess Thaw(Iced.OpAccess src)
            => (IceOpAccess)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline), Op]
        public IceOpCodeId Thaw(Iced.Code src)
            => Enums.parse(src.ToString(), IceOpCodeId.INVALID);

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline), Op]
        public IceCodeSize Thaw(Iced.CodeSize src)
            => (IceCodeSize)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline), Op]
        public IceConditionCode Thaw(Iced.ConditionCode src)
            => (IceConditionCode)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline), Op]
        public IceCpuidFeature Thaw(Iced.CpuidFeature src)
            => (IceCpuidFeature)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline), Op]
        public IceEncodingKind Thaw(Iced.EncodingKind src)
            => (IceEncodingKind)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline), Op]
        public IceFlowControl Thaw(Iced.FlowControl src)
            => (IceFlowControl)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline), Op]
        public IceMandatoryPrefix Thaw(Iced.MandatoryPrefix src)
            => (IceMandatoryPrefix)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline), Op]
        public MemorySize Thaw(Iced.MemorySize src)
            => (MemorySize)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline), Op]
        public IceMnemonic Thaw(Iced.Mnemonic src)
            => (IceMnemonic)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline), Op]
        public IceOpCodeOperandKind Thaw(Iced.OpCodeOperandKind src)
            => (IceOpCodeOperandKind)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline), Op]
        public IceOpCodeTableKind Thaw(Iced.OpCodeTableKind src)
            => (IceOpCodeTableKind)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline), Op]
        public IceOpKind Thaw(Iced.OpKind src)
            => (IceOpKind)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline), Op]
        public IceRegister Thaw(Iced.Register src)
            => (IceRegister)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline), Op]
        public IceRflagsBits Thaw(Iced.RflagsBits src)
            => (IceRflagsBits)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline), Op]
        public IceRoundingControl Thaw(Iced.RoundingControl src)
            => (IceRoundingControl)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline), Op]
        public IceTupleType Thaw(Iced.TupleType src)
            => (IceTupleType)src;
    }
}