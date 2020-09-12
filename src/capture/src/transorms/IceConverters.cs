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
                Access = IceExtractors.OpAccess(src)
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
        public OpAccess Thaw(Iced.OpAccess src)
            => (OpAccess)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline), Op]
        public OpCodeId Thaw(Iced.Code src)
            => (OpCodeId)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline), Op]
        public CodeSize Thaw(Iced.CodeSize src)
            => (CodeSize)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline), Op]
        public ConditionCode Thaw(Iced.ConditionCode src)
            => (ConditionCode)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline), Op]
        public CpuidFeature Thaw(Iced.CpuidFeature src)
            => (CpuidFeature)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline), Op]
        public EncodingKind Thaw(Iced.EncodingKind src)
            => (EncodingKind)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline), Op]
        public FlowControl Thaw(Iced.FlowControl src)
            => (FlowControl)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline), Op]
        public MandatoryPrefix Thaw(Iced.MandatoryPrefix src)
            => (MandatoryPrefix)src;

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
        public Mnemonic Thaw(Iced.Mnemonic src)
            => (Mnemonic)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline), Op]
        public OpCodeOperandKind Thaw(Iced.OpCodeOperandKind src)
            => (OpCodeOperandKind)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline), Op]
        public OpCodeTableKind Thaw(Iced.OpCodeTableKind src)
            => (OpCodeTableKind)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline), Op]
        public OpKind Thaw(Iced.OpKind src)
            => (OpKind)src;

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
        public RflagsBits Thaw(Iced.RflagsBits src)
            => (RflagsBits)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline), Op]
        public RoundingControl Thaw(Iced.RoundingControl src)
            => (RoundingControl)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline), Op]
        public TupleType Thaw(Iced.TupleType src)
            => (TupleType)src;
    }
}