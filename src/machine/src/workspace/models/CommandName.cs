//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct CommandName : IIdentified<string>
    {
        public bool IsEmpty
        {
            get => text.blank(Id);
        }
        
        public string Id {get;}                         
    
        public static implicit operator CommandName(string src)
            => new CommandName(src);

        public static implicit operator string(CommandName src)
            => src.Id;

        public CommandName(string id)
        {
            Id = id;
        }                    
    }
}