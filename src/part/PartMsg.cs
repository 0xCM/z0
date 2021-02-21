//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    [ApiComplete]
    partial struct Msg
    {

    }

    [ApiComplete]
    public readonly partial struct PartMsg
    {
        public static RenderPattern<Type,Type> ContractMismatch => "The source type {0} does not reify {1}";

        public static RenderPattern<string> DispatchingCommand => "Dispatching {0}";

        public static RenderPattern<Assembly,uint> EmittingResources => "Emitting {1} {0} resources";
    }
}