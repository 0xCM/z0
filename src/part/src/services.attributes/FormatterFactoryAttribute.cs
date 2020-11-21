//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public class FormatterFactoryAttribute : ServiceFactoryAttribute
    {
        public Type SourceType {get;}

        public Type TargetType {get;}

        public FormatterFactoryAttribute(Type target)
        {
            SourceType = typeof(string);
            TargetType = target;
        }

        public FormatterFactoryAttribute(Type source, Type target)
        {
            SourceType = source;
            TargetType = target;
        }
    }
}