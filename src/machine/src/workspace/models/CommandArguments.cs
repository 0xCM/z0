//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;

    using static Konst;

    public sealed class CommandArguments : IEnumerable<CommandArgument>
    {
        public static CommandArguments Emtpy => new CommandArguments();

        public static CommandArguments FromObject(object o)
            => new CommandArguments(o.GetType().GetPropertyValues(o));

        public static implicit operator CommandArguments(CommandArgument[] args)
            => new CommandArguments(args);

        public static implicit operator CommandArguments(ValueIndex<CommandArgument> args)
            => new CommandArguments(args);

        readonly IReadOnlyList<CommandArgument> Args;

        public CommandArguments()
        {

        }

        public CommandArguments(IReadOnlyDictionary<string, object> src)
        {
            Args = z.map(src.Keys, name => new CommandArgument(name, src[name]));
        }

        public CommandArguments(CommandArgument[] src)
        {
            Args = src.ToList();
        }

        public CommandArguments(IEnumerable<CommandArgument> src)
        {
            Args = src.ToList();
        }

        public IReadOnlyDictionary<string, object> ToValueIndex()
            => this.ToDictionary(x => x.Name, x => x.Value);

        public Option<string> CommandName
            => from a in Args.TryGetFirst(x => x.Name == nameof(CommandName)) select text.format(a.Value);
            
        public Option<string> SpecName
            => from a in Args.TryGetFirst(x => x.Name == nameof(SpecName)) select text.format(a.Value);

        public CorrelationToken? CorrelationToken
        {
            get
            {
                var value = Args.FirstOrDefault(x => x.Name == nameof(CorrelationToken)).Value;
                return (value is CorrelationToken) ? (CorrelationToken?)value : new CorrelationToken(value);
            }
        }
            
        IEnumerator<CommandArgument> IEnumerable<CommandArgument>.GetEnumerator()
            => Args.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => Args.GetEnumerator();

        public override string ToString()
            => text.join(";", Args);

        public string FormatMessage(string template)
        {
            var output = template;
            foreach (var arg in Args)
                output = output.Replace(arg.Name, text.format(arg.Value));
            return output;
        }
    }
}