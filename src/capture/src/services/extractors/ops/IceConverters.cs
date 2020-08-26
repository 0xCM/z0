//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;

    using Iced = Iced.Intel;


    public interface IIceConversion
    {
        InstructionInfo Thaw(Iced.InstructionInfo src);
    }

    public readonly struct IceConversion : IIceConversion
    {
        public static IceConversion Service => default(IceConversion);

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
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
        [MethodImpl(Inline)]
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
        [MethodImpl(Inline)]
        public UsedRegister Thaw(Iced.UsedRegister src)
            => new UsedRegister(Thaw(src.Register), Thaw(src.Access));

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public OpAccess Thaw(Iced.OpAccess src)
            => (OpAccess)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public OpCodeId Thaw(Iced.Code src)
            => (OpCodeId)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public CodeSize Thaw(Iced.CodeSize src)
            => (CodeSize)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public ConditionCode Thaw(Iced.ConditionCode src)
            => (ConditionCode)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public CpuidFeature Thaw(Iced.CpuidFeature src)
            => (CpuidFeature)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public EncodingKind Thaw(Iced.EncodingKind src)
            => (EncodingKind)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public FlowControl Thaw(Iced.FlowControl src)
            => (FlowControl)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public MandatoryPrefix Thaw(Iced.MandatoryPrefix src)
            => (MandatoryPrefix)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public MemorySize Thaw(Iced.MemorySize src)
            => (MemorySize)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public Mnemonic Thaw(Iced.Mnemonic src)
            => (Mnemonic)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public OpCodeOperandKind Thaw(Iced.OpCodeOperandKind src)
            => (OpCodeOperandKind)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public OpCodeTableKind Thaw(Iced.OpCodeTableKind src)
            => (OpCodeTableKind)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public OpKind Thaw(Iced.OpKind src)
            => (OpKind)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public IceRegister Thaw(Iced.Register src)
            => (IceRegister)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public RflagsBits Thaw(Iced.RflagsBits src)
            => (RflagsBits)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public RoundingControl Thaw(Iced.RoundingControl src)
            => (RoundingControl)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public TupleType Thaw(Iced.TupleType src)
            => (TupleType)src;


    }
}