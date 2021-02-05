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

        [MethodImpl(Inline)]
        public ApiType(Identifier name, ApiTypeCharacter c)
        {
            Name = name;
            Character = c;
        }
    }
}