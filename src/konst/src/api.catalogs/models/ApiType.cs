//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Describes an api type
    /// </summary>
    public readonly struct ApiType
    {
        public Identifier Name {get;}

        public ApiTypeCharacter Character {get;}

    }

    public readonly struct ApiTypeCharacter
    {
        readonly ulong Data;

        public bool Primitive => default;

        public bool FixedWidth => default;

        public bool SystemDefined => default;

        public bool UserDefined => default;

        public bool Class => default;

        public bool Delegate => default;

        public bool Struct => default;

        public bool Interface => default;

        public bool Event => default;

        public bool Enum => default;

        public bool CpuVector => default;

        public bool Index => default;

        public bool Tuple => default;

        public bool NonGeneric => default;

        public bool OpenGeneric => default;

        public bool ClosedGeneric => default;

        public bool Abstract => default;

        public bool Unmanaged => default;

        public uint5 GenericArity => default;
    }
}