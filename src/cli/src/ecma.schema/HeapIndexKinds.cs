//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Ecma.Schema
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly partial struct HeapIndexKinds
    {
        [MethodImpl(Inline)]
        public static HeapIndexKind<T> lift<T>(T src)
            where T : unmanaged, IHeapIndexKind<T>
                => default;

        [MethodImpl(Inline)]
        public static T lower<T>(HeapIndexKind<T> src)
            where T : unmanaged, IHeapIndexKind<T>
                => src;

        [MethodImpl(Inline)]
        public static HeapIndexKind<UserStringIndexKind> lift(UserStringIndexKind src)
            => src;

        [MethodImpl(Inline)]
        public static HeapIndexKind<SystemStringIndexKind> lift(SystemStringIndexKind src)
            => src;

        [MethodImpl(Inline)]
        public static HeapIndexKind<BlobIndexKind> lift(BlobIndexKind src)
            => src;

        [MethodImpl(Inline)]
        public static HeapIndexKind<GuidIndexKind> lift(GuidIndexKind src)
            => src;

        [MethodImpl(Inline)]
        public static UserStringIndexKind ustring()
            => default;

        [MethodImpl(Inline)]
        public static SystemStringIndexKind sstring()
            => default;

        [MethodImpl(Inline)]
        public static BlobIndexKind blob()
            => default;

        [MethodImpl(Inline)]
        public static GuidIndexKind guid()
            => default;

        public readonly struct BlobIndexKind : IHeapIndexKind<BlobIndexKind>
        {
            public HeapIndexKind Classifier => HeapIndexKind.Blob;

            /// <summary>
            /// Projects an index onto its classifier
            /// </summary>
            /// <param name="src">The source index</param>
            [MethodImpl(Inline)]
            public static implicit operator HeapIndexKind(BlobIndexKind src)
                => src.Classifier;
        }

        public readonly struct GuidIndexKind : IHeapIndexKind<GuidIndexKind>
        {
            public HeapIndexKind Classifier => HeapIndexKind.Guid;

            /// <summary>
            /// Projects an index onto its classifier
            /// </summary>
            /// <param name="src">The source index</param>
            [MethodImpl(Inline)]
             public static implicit operator HeapIndexKind(GuidIndexKind src)
                => src.Classifier;
       }

        public readonly struct UserStringIndexKind : IHeapIndexKind<UserStringIndexKind>
        {
            public HeapIndexKind Classifier => HeapIndexKind.UserString;

            /// <summary>
            /// Projects an index onto its classifier
            /// </summary>
            /// <param name="src">The source index</param>
            [MethodImpl(Inline)]
            public static implicit operator HeapIndexKind(UserStringIndexKind src)
                => src.Classifier;
        }

        public readonly struct SystemStringIndexKind : IHeapIndexKind<SystemStringIndexKind>
        {
            public HeapIndexKind Classifier => HeapIndexKind.SystemString;

            /// <summary>
            /// Projects an index onto its classifier
            /// </summary>
            /// <param name="src">The source index</param>
            [MethodImpl(Inline)]
            public static implicit operator HeapIndexKind(SystemStringIndexKind src)
                => src.Classifier;
        }
    }
}