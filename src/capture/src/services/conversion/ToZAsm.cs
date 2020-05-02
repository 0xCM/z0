//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Seed;

    using Iced = Iced.Intel;

    static partial class AsmSpecConversion
    {
        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        public static InstructionInfo ToZAsm(this Iced.InstructionInfo src)
        {
            return new InstructionInfo
            {
                Encoding = src.Encoding.ToZAsm(),
                FlowControl = src.FlowControl.ToZAsm(),
                IsProtectedMode = src.IsProtectedMode,
                IsPrivileged = src.IsPrivileged,
                IsSaveRestoreInstruction = src.IsSaveRestoreInstruction,
                IsStackInstruction = src.IsStackInstruction,
                RflagsCleared = src.RflagsCleared.ToZAsm(),
                RflagsRead = src.RflagsRead.ToZAsm(),
                RflagsWritten = src.RflagsWritten.ToZAsm(),
                RflagsModified = src.RflagsModified.ToZAsm(),
                RflagsSet = src.RflagsSet.ToZAsm(),
                RflagsUndefined = src.RflagsUndefined.ToZAsm(),
                UsedMemory = src.ExtractZAsmUsedMemory(),
                UsedRegisters = src.ExtractUsedRegisters(),
                CpuidFeatures = src.CpuidFeatures.Map(x => x.ToZAsm()),
                Access = src.ExtractZAsmOpAccess()
            };
        }

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static UsedMemory ToZAsm(this Iced.UsedMemory src)
            => new UsedMemory
            {
                Access = src.Access.ToZAsm(),
                Base  = src.Base.ToZAsm(),
                Displacement = src.Displacement,
                Index = src.Index.ToZAsm(),
                MemorySize = src.MemorySize.ToZAsm(),
                Scale = src.Scale,
                Segment = src.Segment.ToZAsm(),
                Formatted = src.ToString()
            };

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static UsedRegister ToZAsm(this Iced.UsedRegister src)
            => new UsedRegister(src.Register.ToZAsm(), src.Access.ToZAsm());

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static OpAccess ToZAsm(this Iced.OpAccess src)
            => (OpAccess)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static Code ToZAsm(this Iced.Code src)
            => (Code)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static CodeSize ToZAsm(this Iced.CodeSize src)
            => (CodeSize)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static ConditionCode ToZAsm(this Iced.ConditionCode src)
            => (ConditionCode)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static CpuidFeature ToZAsm(this Iced.CpuidFeature src)
            => (CpuidFeature)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static EncodingKind ToZAsm(this Iced.EncodingKind src)
            => (EncodingKind)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static FlowControl ToZAsm(this Iced.FlowControl src)
            => (FlowControl)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static MandatoryPrefix ToZAsm(this Iced.MandatoryPrefix src)
            => (MandatoryPrefix)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static MemorySize ToZAsm(this Iced.MemorySize src)
            => (MemorySize)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static Mnemonic ToZAsm(this Iced.Mnemonic src)
            => (Mnemonic)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static OpCodeOperandKind ToZAsm(this Iced.OpCodeOperandKind src)
            => (OpCodeOperandKind)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static OpCodeTableKind ToZAsm(this Iced.OpCodeTableKind src)
            => (OpCodeTableKind)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static OpKind ToZAsm(this Iced.OpKind src)
            => (OpKind)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static Register ToZAsm(this Iced.Register src)
            => (Register)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static RflagsBits ToZAsm(this Iced.RflagsBits src)
            => (RflagsBits)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static RoundingControl ToZAsm(this Iced.RoundingControl src)
            => (RoundingControl)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static TupleType ToZAsm(this Iced.TupleType src)
            => (TupleType)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static MemoryOperand ToZAsm(this Iced.MemoryOperand src)
            => new MemoryOperand(
                    src.Base.ToZAsm(), 
                    src.Index.ToZAsm(), 
                    src.Scale, 
                    src.Displacement, 
                    src.DisplSize, 
                    src.IsBroadcast, 
                    src.SegmentPrefix.ToZAsm()
                    );

    }
}