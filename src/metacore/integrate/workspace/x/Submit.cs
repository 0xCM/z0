//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public static partial class XTend
    {        
        internal static c Submit<c>(this IProcess broker, c command = null)
            where c : ProcessCommand<c>, new()
        {
            var k = command ?? new c();             
            broker.Transmit(k);
            return k;
        }

        internal static c Submit<c>(this IProcess broker, params string[] args)
            where c : ProcessCommand<c>, new()
        {
            var command = ProcessCommand<c>.Init(broker, args);            
            broker.Transmit(command);
            return command;
        }

        internal static Func<string, c> get_input_parser<c>()
            where c : ProcessCommand<c>, new()
                => input => (new PromptInputParser<c>()).Parse(input);
    }
}