//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Reflection;

    using static Konst;

    public enum CodeKind : byte
    {
        None,

        Command,

        Document,

        IL,

        Asm,

        X86,
    }

    public interface ICodeKind<K>
    {
        CodeKind Kind {get;}
    }

    public readonly struct CodeKind<K>
    {

    }

    public readonly struct CodeKinds
    {
        public readonly struct Command
        {
            public CodeKind Kind => CodeKind.Command;
        }

        public readonly struct Document
        {
            public CodeKind Kind => CodeKind.Document;
        }

        public readonly struct IL
        {
            public CodeKind Kind => CodeKind.IL;
        }

        public readonly struct Asm
        {
            public CodeKind Kind => CodeKind.Asm;
        }

        public readonly struct X86
        {
            public CodeKind Kind => CodeKind.X86;
        }

    }

    public interface IOperationCode<K>
    {

    }

    public readonly struct ApiModel
    {


        public struct Operation
        {

        }

        public struct Code<T>
        {

        }
    }
}