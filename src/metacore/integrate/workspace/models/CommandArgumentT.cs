//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    
    public readonly struct CommandArgument<T>
    {
        public readonly string Name;

        public readonly T Value;

        public CommandArgument(string name, T value)
        {
            Name = name;
            Value = value;
        }

        public string Format()
            => $"{Name} := {Value}";
        
        public override string ToString()
            => Format();
    }
}