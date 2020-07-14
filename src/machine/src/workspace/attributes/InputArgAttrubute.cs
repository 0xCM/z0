//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;

    using static Konst;

    [AttributeUsage(AttributeTargets.Property)]
    public class InputArgAttribute : Attribute
    {
        public string identifier { get; }

        public string description { get; }

        public int? position { get; }

        public InputArgAttribute()
            : this(string.Empty)
        { }

        public InputArgAttribute(int position, string description = null, string identifier = null)
            : this(description, identifier)
        {
            this.position = position;
        }

        public InputArgAttribute(string description)
            : this(description, string.Empty)
        {

        }

        public InputArgAttribute(string description, string identifier)
        {
            this.identifier = identifier ?? string.Empty;
            this.description = description ?? string.Empty;
        }


        public override string ToString()
            => string.IsNullOrEmpty(identifier) ? description : $"{identifier} {description}";
    }
}