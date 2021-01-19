//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static z;

    partial class ImageDataEmitter
    {
        public void EmitUserStrings()
        {
            EmitUserStrings(Wf.Components);
        }

        public void EmitUserStrings(ReadOnlySpan<Assembly> src)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
                EmitUserStrings(skip(src,i));
        }

        public void EmitUserStrings(Assembly src)
        {
            using var reader = PeTableReader.open(FS.path(src.Location));
            Wf.Db().EmitTable<CliUserStringInfo>(reader.UserStrings(), src.GetSimpleName());
        }
    }
}