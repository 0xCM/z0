//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class)]
    public class ParserAttribute : Attribute
    {
        public ParserAttribute(Type target)
        {
            TargetType = target;
        }

        public ParserAttribute()
        {
            TargetType = typeof(void);
        }

        public Type TargetType {get;}
    }
}