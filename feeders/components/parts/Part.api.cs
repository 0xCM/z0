//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Components;

    public static class Part
    {
        /// <summary>
        /// The vaccuous part
        /// </summary>
        public static EmptyPart Empty => default;

        [MethodImpl(Inline)]
        public static TargetPart<S,T> target<S,T>(S src = default, T dst = default)        
            where S : struct, IPartId<S>
            where T : struct, IPartId<T>
                => default;
    }

    public sealed class EmptyPart : PartId<EmptyPart> { public override PartId Id => PartId.None; }    
}