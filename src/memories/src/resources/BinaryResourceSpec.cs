//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines the content of a binary resource
    /// </summary>
    public readonly struct BinaryResourceSpec
    {
        public readonly string Identifier;

        public readonly BinaryCode Encoded;

        [MethodImpl(Inline)]
        public BinaryResourceSpec(string name, BinaryCode code)        
        {
            Identifier = name;
            Encoded = code;
        }
    }
}