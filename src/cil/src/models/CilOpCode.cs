//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Threading;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static CilKonst;

    using C = System.Reflection.Metadata.ILOpCode;
    using api = Cil;

    partial struct CilModel
    {
        public readonly struct CilOpCode : IEquatable<CilOpCode>
        {
            public readonly C Value;

            public ushort Index
            {
                [MethodImpl(Inline)]
                get => (ushort) Value;
            }

            readonly int m_flags;

            internal CilOpCode(OpCodeKind value, int flags)
            {
                Value = (C)value;
                m_flags = flags;
            }

            internal bool EndsUncondJmpBlk() =>
                (m_flags & EndsUncondJmpBlkFlag) != 0;

            internal int StackChange() =>
                m_flags >> StackChangeShift;

            public OperandType OperandType
                => (OperandType)(m_flags & OperandTypeMask);

            public FlowControl FlowControl
                => (FlowControl)((m_flags >> FlowControlShift) & FlowControlMask);

            public OpCodeType OpCodeType
                => (OpCodeType)((m_flags >> OpCodeTypeShift) & OpCodeTypeMask);

            public StackBehaviour StackBehaviourPop
                => (StackBehaviour)((m_flags >> StackBehaviourPopShift) & StackBehaviourMask);

            public StackBehaviour StackBehaviourPush
                => (StackBehaviour)((m_flags >> StackBehaviourPushShift) & StackBehaviourMask);

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

            public override string? ToString()
                => api.name(Value);
        }
    }
}