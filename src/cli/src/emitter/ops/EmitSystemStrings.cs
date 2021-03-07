//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static memory;

    partial class ImageDataEmitter
    {
        public void EmitSystemStrings()
        {
            EmitSystemStrings(Wf.Components);
        }

        public void EmitSystemStrings(ReadOnlySpan<Assembly> src)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
                EmitSystemStrings(skip(src,i));
        }

        public void EmitSystemStrings(Assembly src)
        {
            var srcPath = FS.path(src.Location);
            using var reader = PeTableReader.open(srcPath);
            Wf.Db().EmitTable<CliSystemStringInfo>(reader.SystemStrings(), src.GetSimpleName());
        }
    }
}