//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct CilCode
    {
        /// <summary>
        /// The code's base address
        /// </summary>
        public readonly MemoryAddress Base;

        /// <summary>
        /// The operation uri
        /// </summary>
        public readonly string Name;

        public readonly BinaryCode Encoded;

        public readonly MethodImplAttributes ImplSpec;

        [MethodImpl(Inline)]
        public CilCode(MemoryAddress @base, OpUri uri, BinaryCode data, MethodImplAttributes impl)
        {
            Base = @base;
            Name = uri.Format();
            Encoded = data;
            ImplSpec = impl;
        }

        [MethodImpl(Inline)]
        public CilCode(string name, BinaryCode data, MethodImplAttributes impl)
        {
            Base = 0;
            Name = name;
            Encoded = data;
            ImplSpec = impl;
        }

        public string Format(int uripad)
            => text.concat(Base.Format(), Space, Name.PadRight(uripad), Space, Encoded.Format());

        public string Format()
            => Format(30);


        public override string ToString()
            => Format();
    }
}