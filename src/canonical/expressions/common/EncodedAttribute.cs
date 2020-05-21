//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    public class EncodedAttribute : Attribute
    {
        public EncodedAttribute(string data)
        {
            this.Encoding = data;
        }

        public EncodedAttribute(string opcode, string encoding)
        {
            OpCode = opcode;
            Encoding = encoding;
        }

        public string OpCode {get;}
        
        public string Encoding {get;}
    }
}