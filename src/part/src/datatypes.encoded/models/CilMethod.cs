//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct CilMethod : ITextual
    {
        const string FormatPattern = "{0,-16} | {1, -80} | {2}";

        /// <summary>
        /// The operation identity
        /// </summary>
        public Name Id {get;}

        /// <summary>
        /// The code's base address
        /// </summary>
        public MemoryAddress Base {get;}

        /// <summary>
        /// The encoded cil
        /// </summary>
        public BinaryCode Encoded {get;}

        /// <summary>
        /// The method implementation attributes
        /// </summary>
        public MethodImplAttributes ImplSpec {get;}

        public TextBlock Formatted {get;}

        [MethodImpl(Inline)]
        public CilMethod(MemoryAddress @base, Name name, BinaryCode data, MethodImplAttributes impl, TextBlock? formatted = null)
        {
            Base = @base;
            Id = name;
            Encoded = data;
            ImplSpec = impl;
            Formatted = formatted ?? TextBlock.Empty;
        }

        [MethodImpl(Inline)]
        public CilMethod(Name name, BinaryCode data, MethodImplAttributes impl, TextBlock? formatted = null)
        {
            Base = 0;
            Id = name;
            Encoded = data;
            ImplSpec = impl;
            Formatted = formatted ?? TextBlock.Empty;
        }

        [MethodImpl(Inline)]
        public string Format()
            => string.Format(FormatPattern, Base, Id, Encoded.Format());

        public override string ToString()
            => Format();
    }
}