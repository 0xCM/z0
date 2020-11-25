//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Z0.Tools;

    using static CheckPrimal;


    public sealed class t_tools_models : t_tools<t_tools_models>
    {
        public void check_pdb2xml()
        {
            var model = Tooling.describe<Pdb2Xml>();
            eq(Pdb2Xml.Usage, model.Usage);
            var options = model.Options;
            var count = options.Count;
            for(ushort i=0; i<count; i++)
            {
                ref readonly var option = ref options[i];
                Trace($"{i}:{option.Format()}");
            }
        }
    }
}