//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public class EvaluatorAttribute : Attribute
    {
        public EvaluatorAttribute(Type t)
        {
            SourceType = t;
        }

        public Type SourceType {get;}
    }
}