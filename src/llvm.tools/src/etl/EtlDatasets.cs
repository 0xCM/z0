//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Collects the records produced by the etl process
    /// </summary>
    public ref struct EtlDatasets
    {
       public ReadOnlySpan<TextLine> Records;

       public ReadOnlySpan<ItemList<string>> Lists;

       public ReadOnlySpan<ClassRelations> ClassRelations;

       public ReadOnlySpan<DefRelations> DefRelations;

       public ReadOnlySpan<TableGenField> Classes;

       public ReadOnlySpan<TableGenField> Defs;

       public Dictionary<Identifier, uint> ListIndex;

       public LineMap<Identifier> DefMap;

       public LineMap<Identifier> ClassMap;


   }
}