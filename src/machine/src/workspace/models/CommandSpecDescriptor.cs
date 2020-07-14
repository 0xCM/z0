//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    public sealed class CommandSpecDescriptor
    {
        public static Option<CommandSpecDescriptor> TryGetFromType(Type SpecType)
            => Attribute.IsDefined(SpecType, typeof(CommandSpecAttribute)) 
            ? FromSpecType(SpecType) 
            : Option.none<CommandSpecDescriptor>();

        public static CommandSpecDescriptor FromSpecType(Type SpecType)
        {
            var attrib = SpecType.GetCustomAttribute<CommandSpecAttribute>();
            var commandName = text.ifblank(attrib?.CommandName, SpecType.FullName.Replace('.', '/'));
            return new CommandSpecDescriptor
            (
                commandName,
                SpecType,
                attrib?.CommandDescription ?? String.Empty
            );
        }

        public static CommandSpecDescriptor FromSpecType<TSpec>()
            => FromSpecType(typeof(TSpec));

        public CommandSpecDescriptor(CommandName CommandName, Type SpecType, string CommandDescription = null)
        {
            this.CommandName = CommandName;
            this.SpecType = SpecType;
            this.CommandDescription = CommandDescription ?? String.Empty;
        }

        public CommandName CommandName {get; set;}

        public Type SpecType { get; set; }

        public string CommandDescription { get; set; }

        public override string ToString()
            => CommandName.ToString();

        public string FormatDisplayString()
            => $"{CommandName} ({SpecType.FullName}): {text.ifblank(CommandDescription, "UnDocumented")}";
    }
}