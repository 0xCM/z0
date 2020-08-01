//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Linq;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    using static Konst;

    /// <summary>
    /// Represents a typed command specification
    /// </summary>
    public class CommandSpec<S> : CommandArgumentSet<S>, ICommandSpec<S>
        where S : CommandSpec<S>, new()
    {
        public CommandName CommandName { get; set; }

        public string CommandDescription { get; set; }

        public string SpecName { get; set; }

        bool Expanded { get; set; }

        public CommandSpec()
        {
            CommandName = Descriptor.CommandName;
            CommandDescription = Descriptor.CommandDescription;
            SpecName = $"{CommandName}: {DateTime.Now.ToLexicalString()}";
        }

        public CommandSpec(CommandName name)
            : this()
        {
            CommandName = name.IsEmpty ? Descriptor.CommandName : name;
            CommandDescription = Descriptor.CommandDescription;
        }
        
        protected static IAppMsg Describe<C>(C content, string template, [Caller] string caller = null, [File] string file = null, [Line] int?  line = null)
            => z.message(content, template,  AppMsgKind.Info, AppMsgColor.Green, caller, file, line);

        static IReadOnlyDictionary<string, PropertyInfo> argprops
            = typeof(S).GetProperties().Select(p => (p.Name, p)).ToDictionary();

        public static readonly CommandSpecDescriptor Descriptor
            = CommandSpecDescriptor.FromSpecType(typeof(S));
        
        public static S Expand(ICommandSpec src)
        {
            if ((src as S)?.Expanded ?? false)
                return src as S;

            var args = src.Arguments;
            var expansion = new S
            {
                CommandName = src.CommandName,
                Expanded = true,
            };

            z.iter(args, arg =>
            {
                if (ParameterIndex.ContainsKey(arg.Name))
                {
                    if ((arg.Value as string) != null)
                    {
                        throw new NotImplementedException("Need to implement: ScriptText.SpecifyEnvironmentParameters((string)arg.Value)");
                        //var argExpansion = EmptyString;
                        //expansion[arg.Name] = new CommandArgument(arg.Name, argExpansion);
                    }
                    else
                    {
                        expansion[arg.Name] = new CommandArgument(arg.Name, arg.Value);
                    }
                }

            });
            return expansion;
        }

        static string format(object o)
            => o is Date d ? d.ToIsoString() : text.format(o);

        protected string FormatSpecName(params object[] coordinates)
        {
            return coordinates.Length != 0 
                ? NormalizedCommandName + text.parenthetical(text.join(',', coordinates.Select(format))) 
                : NormalizedCommandName;
        }

        public static S Create(IEnumerable<CommandArgument> args)
        {
            if (typeof(S) == typeof(CommandArguments))
                return (z.cast<S>(new CommandArguments(args)));
            else
            {
                var _args = new S();
                _args.CommandName = Descriptor.CommandName;
                foreach (var arg in args)
                {
                    if (argprops.ContainsKey(arg.Name))
                        argprops[arg.Name].SetValue(_args, arg.Value);
                }

                return _args;
            }
        }

        public bool IsEmpty 
            => ReferenceEquals(this, Empty);

        public bool IsSpecifed 
            => !IsEmpty;

        public CommandArguments Arguments 
            => GetArguments();

        public CommandSpecDescriptor Describe()
            => Descriptor;

        public virtual string CommandArea
            => CommandName.Id.Split('/').FirstOrDefault() ?? CommandName;

        public virtual string CommandAction
            => CommandName.Id.Split('/').LastOrDefault() ?? CommandName;
        
        public Option<CommandArgument> this[string argname]
        {
            get
            {
                var value = ParameterIndex.ContainsKey(argname)
                        ? ParameterIndex[argname].Accessor.GetValue(this)
                        : null;

                return value != null
                    ? new CommandArgument(argname, value)
                    : Option.none<CommandArgument>();
            }
            set
            {
                
                ParameterIndex.TryFind(argname).OnSome(parameter 
                    => parameter.Accessor.SetValue(this, value.MapValueOrDefault(x => x.Value, null)));
            }
        }

        ICommandSpec ICommandSpec.ExpandVariables()
            => Expand(this);

        S ICommandSpec<S>.ExpandVariables()
            => Expand(this);

        public virtual IAppMsg DescribeIntent()
            => Describe(
                new
                {
                    CommandName,
                    SpecName
                }, "Beginning execution of the @CommandName command as specified by @SpecName");

        protected string NormalizedCommandName
            => CommandName.Id.Replace('-', '_').Replace('/', '-');

        public override string ToString()
            => SpecName;
 
         public static S Empty 
            => new S();
    }

    public abstract class CommandSpec<S,P> : CommandSpec<S>, ICommandSpec<S,P>
        where S : CommandSpec<S,P>, new()
    {
        public CommandSpec()
        { }
    }
}