//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;
    using System.Reflection;

    using static Part;
    using static z;

    public readonly partial struct ResDataEmitter
    {
        public static Index<ResEmission> embedded(IWfShell wf, Assembly src, FS.FolderPath root, utf8 match = default,  bool clear = true)
        {
            var flow = wf.Running(string.Format("Emitting resources embedded in {0}", src.GetSimpleName()));

            var query = match.IsEmpty ? Resources.query(src) : Resources.query(src, match);
            var count = query.ResourceCount;

            if(count == 0)
                wf.Warn(Msg.NoMatchingResources.Format(src, match));
            else
                wf.Status(Msg.EmittingResources.Format(src, count));

            var buffer = sys.alloc<ResEmission>(count);
            ref var emission = ref first(buffer);

            if(clear)
                root.Clear();

            var invalid = Path.GetInvalidPathChars();
            var descriptors = query.Descriptors();
            for(var i=0; i<count; i++)
            {
                ref readonly var descriptor = ref skip(descriptors,i);
                seek(emission,i) = emit(descriptor, root);
                wf.EmittedFile((uint)descriptor.Size, emission.Target);
            }

            wf.Ran(flow);
            return buffer;
        }
    }
}