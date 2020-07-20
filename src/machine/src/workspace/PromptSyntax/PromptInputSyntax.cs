//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;
    using api = PromptSyntax;

    public readonly struct PromptInputSyntax : ITextual
    {
        public readonly string CommandName;

        public readonly StringRef Prototype;

        public readonly InputParameter[] Parameters;

        public readonly InputFlag[] Flags;

        [MethodImpl(Inline)]
        public static PromptInputSyntax define(in StringRef prototype, string command)
            => new PromptInputSyntax(prototype, command, sys.empty<InputFlag>(), sys.empty<InputParameter>());

        [MethodImpl(Inline)]
        public PromptInputSyntax(in StringRef prototype, string command, InputFlag[] flags, InputParameter[] parameters)
        {
            Prototype = prototype;
            Parameters = parameters;
            Flags = flags;
            CommandName = command;
        }

        public PromptInputSyntax WithFlags(params InputFlag[] flags)
            => new PromptInputSyntax(Prototype, CommandName, flags, Parameters);

        public PromptInputSyntax WithFlags(char marker, params string[] flags)
            => new PromptInputSyntax(Prototype, CommandName,
                flags.Select(f => new InputFlag(f, marker.ToString())).Array(),
                Parameters);

        public PromptInputSyntax WithFlags(params string[] flags)
            => new PromptInputSyntax(Prototype, CommandName, flags.Select(f => new InputFlag(f, "/")).Array(), Parameters);

        public PromptInputSyntax WithParameters(params InputParameter[] parameters)
            => new PromptInputSyntax(Prototype, CommandName, Flags, parameters);

        public PromptInputSyntax WithPositionalParameters(params string[] parameters)                               
            => new PromptInputSyntax(Prototype, CommandName, Flags, api.parameters(parameters));
        
        [MethodImpl(Inline)]
        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();

        static StringRef EmptyStringRef => EmptyString;
        
        public static PromptInputSyntax Empty 
            => new PromptInputSyntax(EmptyStringRef, EmptyString, sys.empty<InputFlag>(), sys.empty<InputParameter>());
    }
}