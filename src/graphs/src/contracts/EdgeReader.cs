//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Graphs
{
    using System;

    public delegate void EdgeReader<V>(in LabeledEdge<V> e)
        where V : unmanaged, IVertex, IEquatable<V>;
}