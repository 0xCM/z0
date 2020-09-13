//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
    using static XedSourceMarkers;
    using Xed;

    partial struct XedOps
    {
        public static XedPattern[] patterns(XedInstructionData src)
        {
            var patterns = list<XedPattern>();
            for(var i=0; i<src.RowCount; i++)
            {
                if(src.IsProp(i,PATTERN) && i != (src.RowCount - 1))
                {
                    if(src.IsProp(i + 1, OPERANDS))
                    {
                        patterns.Add(new XedPattern(
                            src.Class,
                            src.Category,
                            src.Extension,
                            src.IsaSet,
                            src.ExtractProp(i),
                            src.ExtractProp(i + 1)
                            ));
                    }
                }
            }
            return patterns.ToArray();
        }

        [MethodImpl(Inline), Op]
        public static ListedFiles sources(in XedEtlConfig config)
            => Archives.list(FS.dir(config.SourceRoot.Name),"*.*", true);
    }
}