//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;

    /// <summary>
    /// For a provided api, captures everything known/dervied about the operation, including
    /// a reference to the defining member function, the captured x86 assembly, and identifying/
    /// classifying metadata
    /// </summary>
    public readonly struct ApiDefinition
    {
        public readonly ApiHostUri HostUri;

        public readonly OpIdentity OpId;

        public readonly OpUri ApiUri;

        public readonly MethodInfo Method;

        public readonly BinaryCode BinaryCode;

        public readonly OpKindId KindId;

        public readonly ArityClass Arity;
       
    }
}