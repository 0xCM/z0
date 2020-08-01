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
        public string Id {get;}                         
        
        [MethodImpl(Inline)]        
        public static implicit operator CommandName(string src)
            => new CommandName(src);

        [MethodImpl(Inline)]
        public static implicit operator string(CommandName src)
            => src.Id;

        [MethodImpl(Inline)]
        public CommandName(string id)
        {
            Id = id;
        }                    
        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => text.blank(Id);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }
    }
}