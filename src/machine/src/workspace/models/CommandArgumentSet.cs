//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;

    public abstract class CommandArgumentSet<T> : DataObject<T>
        where T : CommandArgumentSet<T>, new()
    {
        static Option<CommandArgument> TryGetArgument(CommandParameterInfo p, object o)
        {
            var v = p.Accessor.GetValue(o);

            if (v != null)
                return new CommandArgument(p.ParameterName, v);

            return Option.none<CommandArgument>();
        }

        protected static IReadOnlyDictionary<string, CommandParameterInfo> ParameterIndex
            = (
                from member in typeof(T).DataMembers()
                let attrib = member.Member.Tag<CommandParameterAttribute>()
                where attrib.Exists
                let paramName = attrib.ValueOrDefault().ParameterName ?? member.Name
                select (paramName, new CommandParameterInfo(paramName, member))
            ).ToDictionary();

        public virtual CommandArguments GetArguments()
            => new CommandArguments(from p in ParameterIndex.Values
                                    let arg = TryGetArgument(p, this)
                                    where arg.Exists
                                    select arg.Require());
    }
}