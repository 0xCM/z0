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

    public class ApiMsil
    {
        public CliToken Token {get;}

        /// <summary>
        /// The operation identity
        /// </summary>
        public Name Uri {get;}

        /// <summary>
        /// The code's base address
        /// </summary>
        public MemoryAddress BaseAddress {get;}

        /// <summary>
        /// The Cli signature
        /// </summary>
        public CliSig CliSig {get;}

        /// <summary>
        /// The encoded cil
        /// </summary>
        public BinaryCode Code {get;}

        /// <summary>
        /// The method implementation attributes
        /// </summary>
        public MethodImplAttributes ImplSpec {get;}

        [MethodImpl(Inline)]
        public ApiMsil(CliToken token, MemoryAddress @base, OpUri uri, CliSig sig, BinaryCode data, MethodImplAttributes impl)
        {
            Token = token;
            BaseAddress = @base;
            Uri = uri.Format();
            Code = data;
            CliSig = sig;
            Code = data;
            ImplSpec = impl;
        }
    }
}