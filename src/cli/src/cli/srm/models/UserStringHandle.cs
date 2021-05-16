//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft/.NET Foundation
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class SRM
    {
        /// <summary>
        /// #UserString heap handle.
        /// </summary>
        /// <remarks>
        /// The handle is 32-bit wide.
        /// </remarks>
        public readonly struct UserStringHandle : IEquatable<UserStringHandle>
        {
            // bits:
            //     31: 0
            // 24..30: 0
            //  0..23: index
            readonly int _offset;

            public UserStringHandle(int offset)
            {
                // #US string indices must fit into 24bits since they are used in IL stream tokens
                Debug.Assert((offset & 0xFF000000) == 0);
                _offset = offset;
            }

            [MethodImpl(Inline)]
            public static UserStringHandle FromOffset(int heapOffset)
                => new UserStringHandle(heapOffset);

            [MethodImpl(Inline)]
            public static implicit operator Handle(UserStringHandle handle)
                => new Handle((byte)HandleType.UserString, handle._offset);

            [MethodImpl(Inline)]
            public static explicit operator UserStringHandle(Handle handle)
                => new UserStringHandle(handle.Offset);

            public bool IsNil
            {
                [MethodImpl(Inline)]
                get { return _offset == 0; }
            }

            [MethodImpl(Inline)]
            public int GetHeapOffset()
            {
                return _offset;
            }

            [MethodImpl(Inline)]
            public static bool operator ==(UserStringHandle left, UserStringHandle right)
                => left._offset == right._offset;

            [MethodImpl(Inline)]
            public override bool Equals(object? obj)
                => obj is UserStringHandle && ((UserStringHandle)obj)._offset == _offset;


            [MethodImpl(Inline)]
            public bool Equals(UserStringHandle other)
            {
                return _offset == other._offset;
            }

            public override int GetHashCode()
            {
                return _offset.GetHashCode();
            }

            [MethodImpl(Inline)]
            public static bool operator !=(UserStringHandle left, UserStringHandle right)
            {
                return left._offset != right._offset;
            }
        }
    }
}