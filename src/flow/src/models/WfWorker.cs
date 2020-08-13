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

    public readonly struct WfWorker : ITextual
    {
        [MethodImpl(Inline)]
        public static WfWorker create([CallerFilePath] string name = null)
            => new WfWorker(Path.GetFileNameWithoutExtension(name));
        
        public readonly string Name;

        [MethodImpl(Inline)]
        public static implicit operator WfWorker(string name)
            => new WfWorker(name);

        [MethodImpl(Inline)]
        WfWorker(string name)
            => Name = name;

        [MethodImpl(Inline)]
        public string Format()
            => Name;
    }
}