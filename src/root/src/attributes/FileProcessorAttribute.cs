//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class FileProcessorAttribute : Attribute
    {
        public FileKind[] Supported {get;}

        public FileProcessorAttribute(params FileKind[] kinds)
        {
            Supported = kinds;
        }
    }
}