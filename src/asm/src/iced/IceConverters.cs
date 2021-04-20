//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using Iced = Iced.Intel;

    public readonly struct IceConverters
    {
        public static IceConverters Service => default(IceConverters);

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline), Op]
        public IceUsedMemory Thaw(Iced.UsedMemory src)
            => new IceUsedMemory(
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
        public IceUsedRegister Thaw(Iced.UsedRegister src)
            => new IceUsedRegister(Thaw(src.Register), Thaw(src.Access));

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
            => ClrEnums.parse(src.ToString(), IceOpCodeId.INVALID);

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
        public IceMemorySize Thaw(Iced.MemorySize src)
            => (IceMemorySize)src;

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