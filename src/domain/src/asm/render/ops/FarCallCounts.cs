//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;

    using F = FarCallCountsField;

    partial struct AsmRender
    {                        
        [MethodImpl(Inline), Op]
        public static void render(in FarCallCounts src, StringBuilder dst)
        {            
            var formatter = Tables.formatter<F>(dst);
            formatter.Delimit(F.TargetsFar, src.TargetsFar);
            formatter.Delimit(F.HostedReceivers, src.HostedReceivers);
            formatter.Delimit(F.UnhostedReceivers, src.UnhostedReceivers);        
        }        
    }
}
