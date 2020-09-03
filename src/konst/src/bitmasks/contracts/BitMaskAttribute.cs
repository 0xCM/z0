//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;

    [AttributeUsage(AttributeTargets.Field)]
    public class BitMaskAttribute : BinaryLiteralAttribute
    {
        public BitMaskAttribute(string src)
            : base(src)
        {

        }

        public BitMaskAttribute(string src, BitMaskKind kind)
            : base(src)
        {
            Kind = (BitMaskKind)kind;
        }

        public BitMaskAttribute(string src, string pattern, byte arg0, byte arg1)
            : base(src,pattern,arg0,arg1)
        {


        }

        public BitMaskKind Kind {get;}
    }
}