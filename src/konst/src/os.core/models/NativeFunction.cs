//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Security;

    using static Konst;

    public readonly struct NativeFunction : INativeFunction
    {
        public MemoryAddress Base {get;}

        public NativeModule Source {get;}

        public StringRef Name {get;}

        [MethodImpl(Inline)]
        public NativeFunction(NativeModule src, MemoryAddress @base, string name)
        {
            Source = src;
            Base = @base;
            Name = name;
        }

        public string Format()
            => Base.Format();
    }

    public readonly struct NativeFunction<D> : INativeFunction
        where D : Delegate
    {
        public MemoryAddress Base {get;}

        public NativeModule Source {get;}

        public StringRef Name {get;}
        public readonly D Invoke {get;}

        [MethodImpl(Inline)]
        internal NativeFunction(NativeModule src, MemoryAddress @base, string name, D f)
        {
            Source = src;
            Base = @base;
            Name = name;
            Invoke = f;
        }

        public string Format()
            => text.format(RP.PSx3, Base, Source, Name);
    }
}