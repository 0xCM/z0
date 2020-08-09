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

    public readonly struct WfActor : ITextual
    {
        [MethodImpl(Inline)]
        public static WfActor create([CallerFilePath] string name = null)
            => new WfActor(Path.GetFileNameWithoutExtension(name));
        
        public readonly asci32 Name;

        [MethodImpl(Inline)]
        WfActor(string name)
            => Name = name;

        [MethodImpl(Inline)]
        WfActor(asci32 name)
            => Name = name;

        [MethodImpl(Inline)]
        public string Format()
            => Name;
    }
}