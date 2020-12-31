//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;
    using static z;

    partial struct ResDataEmitter
    {
        public static ResEmission[] reference(IWfShell wf)
        {
            var flow = wf.Running("Emitting reference data");
            var descriptors = Resources.query(Parts.Res.Assembly).Descriptors();
            var count = descriptors.Length;
            var root = wf.Db().RefDataRoot();
            var emissions = sys.alloc<ResEmission>(count);
            for(var i=0; i<count; i++)
            {
                try
                {
                    ref var emission = ref seek(emissions,i);
                    emission = emit(skip(descriptors,i), root);
                    wf.EmittedFile((uint)emission.Source.Size, emission.Target);
                }
                catch(Exception e)
                {
                    wf.Error(e);
                }
            }
            wf.Ran(flow);
            return emissions;
        }
    }
}