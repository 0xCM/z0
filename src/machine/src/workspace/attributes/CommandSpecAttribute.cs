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

    /// <summary>
    /// Applied to a command specification to identify and describe it
    /// </summary>
    public class CommandSpecAttribute : Attribute
    {
        public CommandSpecAttribute(string CommandName = null, string CommandDescription = null)
        {
            this.CommandName = CommandName ?? String.Empty;
            this.CommandDescription = CommandDescription ??  String.Empty;
        }
        
        /// <summary>
        /// The name of the command, if different from the name of the type that represents it
        /// </summary>
        public string CommandName { get; }

        /// <summary>
        /// The purpose of the command
        /// </summary>
        public string CommandDescription { get; }
        
        public override string ToString()
            => CommandName;
    }

    public class CommandActionSpecAttribute : CommandSpecAttribute
    {
        public CommandActionSpecAttribute(string CommandName, string ActionName)
            : base(CommandName)
        {
            this.ActionName = ActionName;
        }

        public string ActionName { get; private set; }
     
        public string ActionDescription { get; set; }
    }
}