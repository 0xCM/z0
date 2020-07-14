//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [AttributeUsage(AttributeTargets.Property)]
    public class InputFlagAttribute : Attribute
    {
        public InputFlagAttribute()           
        {

        }

        public InputFlagAttribute(string RenderAs, string ArgName, string Description)
        {
            this.RenderAs = RenderAs;
            this.ArgName = ArgName;
            this.Description = Description;
        }

        public string RenderAs { get; }

        public string ArgName { get; }

        public string Description { get; }

        public override string ToString()
            => text.blank(RenderAs) ? EmptyString : text.concat(RenderAs, text.ifblank(ArgName, EmptyString));
    }
}