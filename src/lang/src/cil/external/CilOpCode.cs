// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static CilOpCodeSpecs;

    public readonly struct CilOpCode : IEquatable<CilOpCode>
    {
        public readonly CilOpCodeKind Value;

        public ushort Index
        {
            [MethodImpl(Inline)]
            get => (ushort) Value;
        }

        readonly int m_flags;

        [MethodImpl(Inline)]
        internal CilOpCode(CilOpCodeKind value, int flags)
        {
            Value = value;
            m_flags = flags;
        }

        [MethodImpl(Inline)]
        internal bool EndsUncondJmpBlk() =>
            (m_flags & EndsUncondJmpBlkFlag) != 0;

        [MethodImpl(Inline)]
        internal int StackChange() =>
            m_flags >> StackChangeShift;

        public CilOperandType OperandType
        {
            [MethodImpl(Inline)]
            get => (CilOperandType)(m_flags & OperandTypeMask);
        }

        public CilFlowControl FlowControl
        {
            [MethodImpl(Inline)]
            get => (CilFlowControl)((m_flags >> FlowControlShift) & FlowControlMask);
        }

        public CilOpCodeType OpCodeType
        {
            [MethodImpl(Inline)]
            get => (CilOpCodeType)((m_flags >> OpCodeTypeShift) & OpCodeTypeMask);
        }

        public CilStackBehaviour StackBehaviourPop
        {
            [MethodImpl(Inline)]
            get => (CilStackBehaviour)((m_flags >> StackBehaviourPopShift) & StackBehaviourMask);
        }

        public CilStackBehaviour StackBehaviourPush
        {
            [MethodImpl(Inline)]
            get => (CilStackBehaviour)((m_flags >> StackBehaviourPushShift) & StackBehaviourMask);
        }

        public int Size
        {
            [MethodImpl(Inline)]
            get => (m_flags >> SizeShift) & SizeMask;
        }

        [MethodImpl(Inline)]
        public bool Equals(CilOpCode obj)
            => obj.Value == Value;

        [MethodImpl(Inline)]
        public static bool operator ==(CilOpCode a, CilOpCode b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(CilOpCode a, CilOpCode b)
            => !(a == b);

        public override bool Equals(object? obj)
            => obj is CilOpCode other && Equals(other);

        public override int GetHashCode()
            => (int)Value;
    }
}