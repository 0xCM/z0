//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    
    public readonly struct CommandArgument
    {
        public readonly string Name;

        public readonly object Value;

        public CommandArgument(string name, object value)
        {
            Name = name;
            Value = value;
        }

        public string Format()
            => $"{Name} := {Value}";
        
        public override string ToString()
            => Format();
        
        public bool IsBit 
            => Value is bool;

        public T GetValue<T>() 
            => (T)Value;
    }

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