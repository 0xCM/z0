//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;
        
    using static Konst;
    using static z;

    /// <summary>
    /// Represents a contextual worker
    /// </summary>
    public readonly struct WfActor : ITextual
    {
        [MethodImpl(Inline)]
        public static WfActor create([CallerFilePath] string name = null)
            => new WfActor(Path.GetFileNameWithoutExtension(name));
        
        public readonly string Name;

        [MethodImpl(Inline)]
        public static implicit operator WfActor(string name)
            => new WfActor(name);

        [MethodImpl(Inline)]
        public WfActor(string name)
            => Name = name;

        [MethodImpl(Inline)]
        public string Format()
            => Name;
    }
}