//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Konst;
    using static z;

    /// <summary>
    /// Represents a non-contextual workflow participant
    /// </summary>
    public readonly struct WfWorker : ITextual
    {        
        /// <summary>
        /// The participant name
        /// </summary>
        public readonly string Name;

        [MethodImpl(Inline)]
        public static implicit operator WfWorker(string name)
            => new WfWorker(name);

        [MethodImpl(Inline)]
        public WfWorker(string name)
            => Name = name;

        [MethodImpl(Inline)]
        public string Format()
            => Name;
    }
}