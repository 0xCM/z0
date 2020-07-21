//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial struct AccessorCapture
    {
        static ApiHostUri InferHostUri(Type src)
        {
            var typename = src.Name;
            var partName = typename.LeftOf('_');
            var part = PartIdParser.single(partName);
            var host = text.ifblank(typename.RightOf('_'), "anonymous");
            return ApiHostUri.Define(part, host);            
        }
    }
}