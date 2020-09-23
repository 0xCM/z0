//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;


    public abstract class LiteralAttachmentAttribute : Attribute
    {
        public object[] Attached {get;}

        protected LiteralAttachmentAttribute(params object[] values)
        {
            Attached = values;
        }
    }
}