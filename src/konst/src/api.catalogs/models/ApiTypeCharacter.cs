//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ApiTypeCharacter
    {
        readonly ulong Data;

        [MethodImpl(Inline)]
        internal ApiTypeCharacter(ulong data)
        {
            Data = data;
        }

        /// <summary>
        /// Specifies whether the type is primal
        /// </summary>
        public bool Primitive => default;

        /// <summary>
        /// Specifies whether the width of the type is known at compile-time
        /// </summary>
        public bool InvariantWidth => default;

        /// <summary>
        /// Specifies whether the type is defined in mscorelib
        /// </summary>
        public bool SystemDefined => default;

        /// <summary>
        /// Specifies whether the type is not defined in mscorelib
        /// </summary>
        public bool UserDefined => default;

        /// <summary>
        /// Specifies whether the type is a class
        /// </summary>
        public bool Class => default;

        /// <summary>
        /// Specifies whether the type is a delegate
        /// </summary>
        public bool Delegate => default;

        /// <summary>
        /// Specifies whether the type is a struct
        /// </summary>
        public bool Struct => default;

        /// <summary>
        /// Specifies whether the type is an interface
        /// </summary>
        public bool Interface => default;

        /// <summary>
        /// Specifies whether the type is an event
        /// </summary>
        public bool Event => default;

        /// <summary>
        /// Specifies whether the type is an enum
        /// </summary>
        public bool Enum => default;

        /// <summary>
        /// Specifies whether the type represents an intrinsic vector
        /// </summary>
        public bool CpuVector => default;

        /// <summary>
        /// Specifies whether the type is some sort of sequence
        /// </summary>
        public bool Sequence => default;

        /// <summary>
        /// Specifies whether the type is a framework-defined tuple
        /// </summary>
        public bool Tuple => default;

        public bool NonGeneric => default;

        public bool OpenGeneric => default;

        public bool ClosedGeneric => default;

        public bool Abstract => default;

        public bool Unmanaged => default;

        public uint5 GenericArity => default;
    }
}