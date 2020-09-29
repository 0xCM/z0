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

    using static Part;
    using static CilOpCodes;

    using C = System.Reflection.Metadata.ILOpCode;

    public readonly struct CilOpCode : IEquatable<CilOpCode>
    {
        public readonly C Value;

        public ushort Index
        {
            [MethodImpl(Inline)]
            get => (ushort) Value;
        }

        readonly int m_flags;

        internal CilOpCode(CilOpCodeKind value, int flags)
        {
            Value = (C)value;
            m_flags = flags;
        }

        internal bool EndsUncondJmpBlk() =>
            (m_flags & EndsUncondJmpBlkFlag) != 0;

        internal int StackChange() =>
            m_flags >> StackChangeShift;

        public CilOperandType OperandType
            => (CilOperandType)(m_flags & OperandTypeMask);

        public CilFlowControl FlowControl
            => (CilFlowControl)((m_flags >> FlowControlShift) & FlowControlMask);

        public CilOpCodeType OpCodeType
            => (CilOpCodeType)((m_flags >> OpCodeTypeShift) & OpCodeTypeMask);

        public CilStackBehaviour StackBehaviourPop
            => (CilStackBehaviour)((m_flags >> StackBehaviourPopShift) & StackBehaviourMask);

        public CilStackBehaviour StackBehaviourPush
            => (CilStackBehaviour)((m_flags >> StackBehaviourPushShift) & StackBehaviourMask);

        public int Size
            => (m_flags >> SizeShift) & SizeMask;

        public override bool Equals(object? obj) =>
            obj is CilOpCode other && Equals(other);

        public bool Equals(CilOpCode obj)
            => obj.Value == Value;

        public static bool operator ==(CilOpCode a, CilOpCode b)
            => a.Equals(b);

        public static bool operator !=(CilOpCode a, CilOpCode b)
            => !(a == b);

        public override int GetHashCode()
            => (int)Value;
    }
}