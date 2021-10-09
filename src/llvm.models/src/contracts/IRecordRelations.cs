//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    public interface IRecordRelations<T> : IRecord<T>
        where T : struct, IRecordRelations<T>
    {
        LineNumber SourceLine {get;}

        Identifier Name {get;}

        Lineage Ancestors {get;}
    }
}