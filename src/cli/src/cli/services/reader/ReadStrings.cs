//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;
    using System.Reflection.PortableExecutable;
    using System.Reflection.Metadata.Ecma335;

    using static Root;
    using static core;
    using static CliRows;

    public enum CliStringKind : byte
    {
        None = 0,

        System = 1,

        User = 2
    }

    partial class CliReader
    {
        public ReadOnlySpan<string> ReadUserStrings()
        {
            int size = HeapSize(HeapIndex.UserString);
            if (size == 0)
                return sys.empty<string>();

            var values = root.list<string>();
            var handle = MetadataTokens.UserStringHandle(0);
            do
            {
                values.Add(Read(handle));
                handle = MD.GetNextHandle(handle);
            }
            while (!handle.IsNil);

            return values.ViewDeposited();
        }

        public ReadOnlySpan<string> ReadSystemStrings()
        {
            int size = HeapSize(HeapIndex.String);
            if (size == 0)
                return sys.empty<string>();

            var values = root.list<string>();
            var handle = MetadataTokens.StringHandle(0);
            do
            {
                values.Add(Read(handle));
                handle = MD.GetNextHandle(handle);
            }
            while (!handle.IsNil);

            return values.ViewDeposited();
        }
    }
}