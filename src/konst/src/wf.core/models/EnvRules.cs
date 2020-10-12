//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct EnvRules
    {
        public static EnvRules Default
        {
            [MethodImpl(Inline)]
            get => new EnvRules(EnvVars.Common);
        }

        public Env Base {get;}

        [MethodImpl(Inline)]
        public EnvRules(Env @base)
            => Base = @base;

        [MethodImpl(Inline)]
        public static implicit operator EnvRules(Env src)
            => new EnvRules(src);

        [MethodImpl(Inline)]
        public FS.FolderPath ProjectDataRoot()
            => Base.DevRoot + FS.folder("data");

        public FS.FolderPath DbRoot()
            => FS.dir("j:/database");
    }
}